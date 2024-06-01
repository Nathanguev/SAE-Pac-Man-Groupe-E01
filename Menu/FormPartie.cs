using Bibliotheque_PacMan;
using BibliothequePacMan;
using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_PacMan
{
    public partial class FormPartie : Form
    {
        /* ---------------- Variables globales ---------------- */

        private FormMenuPrincipal formMenuPrincipal;

        private Partie partie;
        private Labyrinthe labyrinthe;

        private TableLayoutPanel tlpLabyrinthe;

        private Character pacman;
        private Character fantomeAleatoire;

        private List<Point> positionsPiecesSuppr;

        private Point pacmanSpawnPosition;
        private Point fantomeSpawnPosition;

        private UneCellule pacmanSpawnCellule;
        private UneCellule fantomeSpawnCellule;

        private int speed = 400;
        private int nbVie;
        private bool isRunning = false;
        private bool isVictory = false;
        private bool isDefeat = false;

        /* ---------------- Constructeur FormPartie ---------------- */

        public FormPartie(FormMenuPrincipal formMenuPrincipal, Partie partie)
        {
            InitializeComponent();
            this.partie = partie;
            this.formMenuPrincipal = formMenuPrincipal;

            labyrinthe = new Labyrinthe(partie.hauteur, partie.largeur);
            // labyrinthe.setSeed(partie.seed);
            labyrinthe.algoParcoursProfondeur();
        }

        /* ---------------- Au lancement du formulaire ---------------- */

        private void FormPartie_Load(object sender, EventArgs e)
        {
            Init_CenterTableLayoutPanel();
            tlpLabyrinthe = new TableLayoutPanel();
            Init_TableLayoutPanel(tlpLabyrinthe);
            panelLabyrinthe.Controls.Add(tlpLabyrinthe);
            Init_Vies();

            Size autoScrollSize = new Size(panelLabyrinthe.Width, panelLabyrinthe.Height);
            tlpGrille.AutoScrollMinSize = autoScrollSize;

            affichageLabyrinthe();
            Init_PacMan(panelLabyrinthe);
            Init_Pieces(panelLabyrinthe);
            Init_FantomeAleatoire(panelLabyrinthe);

            pacman.sprite.BringToFront();
            fantomeAleatoire.sprite.BringToFront();
        }

        /* ---------------- Fonctions d'initialisation ---------------- */

        private void Init_Pieces(Panel panel)
        {
            for (int i = 2; i < partie.hauteur * 50; i = i + 50)
            {
                for (int j = 2; j < partie.largeur * 50; j = j + 50)
                {
                    Point point = new Point(j, i);
                    if (positionsPiecesSuppr.Contains(point))
                    {

                    }
                    else
                    {
                        Objet objet = new Objet(Properties.Resources.piece, point);

                        panel.Controls.Add(objet.sprite);
                        objet.sprite.BringToFront();
                    }
                }
            }
            lblScoreCount.Text = Convert.ToString(positionsPiecesSuppr.Count);
        }

        private void Init_PacMan(Panel panel)
        {
            int index = partie.largeur + 1;
            Image image = Properties.Resources.pacMan;
            pacman = new Character(image, labyrinthe.getCellules()[index]);
            positionsPiecesSuppr = [pacman.position];

            panel.Controls.Add(pacman.sprite);
            pacman.index = index;
            pacmanSpawnPosition = pacman.position;
            pacmanSpawnCellule = pacman.currentCellule;
        }

        private void Init_FantomeAleatoire(Panel panel)
        {
            int index = (partie.largeur * (partie.hauteur / 2) + (partie.largeur / 2));
            Image image = Properties.Resources.fantomeRouge;
            fantomeAleatoire = new Character(image, labyrinthe.getCellules()[index]);

            panel.Controls.Add(fantomeAleatoire.sprite);
            fantomeAleatoire.index = index;
            fantomeSpawnPosition = fantomeAleatoire.position;
            fantomeSpawnCellule = fantomeAleatoire.currentCellule;
        }

        private void Init_TableLayoutPanel(TableLayoutPanel tlp)
        {
            tlp.RowCount = partie.hauteur;
            tlp.ColumnCount = partie.largeur;
            tlp.Margin = new Padding(0);
            tlp.Location = new Point(0, 0);
            tlp.AutoSize = true;

            tlp.ColumnStyles.Clear();
            tlp.RowStyles.Clear();
            for (int i = 0; i < tlp.RowCount; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            }
            for (int i = 0; i < tlp.ColumnCount; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            }
        }

        private void Init_CenterTableLayoutPanel()
        {
            tlpGrille.RowStyles.Clear();
            tlpGrille.ColumnStyles.Clear();
            for (int i = 0; i < 3; i++)
            {
                if (i == 1)
                {
                    tlpGrille.RowStyles.Add(new RowStyle(SizeType.Absolute, partie.hauteur * 50 + 4));
                    tlpGrille.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, partie.largeur * 50 + 4));
                }
                else
                {
                    tlpGrille.RowStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                    tlpGrille.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                }
            }
        }

        private void Init_Vies()
        {
            switch (partie.difficulte)
            {
                case 1:
                    nbVie = 5;
                    break;

                case 2:
                    nbVie = 3;
                    break;

                case 3:
                    nbVie = 1;
                    break;
            }

            for (int i = 1; i < nbVie + 1; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Margin = new Padding(10);
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Image = Properties.Resources.coeur;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                tlpVies.Controls.Add(pictureBox, i, 0);
            }
        }

        /* ---------------- Fonctions de réinitialisation ---------------- */

        private void Reset_PacMan()
        {
            pacman.position = pacmanSpawnPosition;
            pacman.currentCellule = pacmanSpawnCellule;
            pacman.index = pacmanSpawnCellule.getY() * partie.largeur + pacmanSpawnCellule.getX();
        }

        private void Reset_Fantome(Character fantome)
        {
            fantome.position = fantomeSpawnPosition;
            fantome.currentCellule = fantomeSpawnCellule;
            fantome.index = fantomeSpawnCellule.getY() * partie.largeur + fantomeSpawnCellule.getX();
            isRunning = false;
        }

        /* ---------------- Condition de victoire et défaite ---------------- */

        private void GameClose()
        {
            tlpLabyrinthe.Controls.Clear();
            panelLabyrinthe.Controls.Clear();
            this.Close();
        }

        private void IsGameVictory()
        {
            if (tlpLabyrinthe.Controls.Count == positionsPiecesSuppr.Count)
            {
                isRunning = false;
                isVictory = true;
                MessageBox.Show("Vous avez gagné la partie.");
                GameClose();
            }
        }

        private void IsGameDefeat()
        {
            if (nbVie == 0)
            {
                MessageBox.Show("Vous avez perdu !");
                isDefeat = true;
                GameClose();
            }
            else
            {
                MessageBox.Show($"Vous perdez une vie, il vous en reste {nbVie}.");
            }
        }

        /* ---------------- Récolte des pieces ---------------- */

        private void RemoveControlAtPosition(Point point)
        {
            foreach (Control control in panelLabyrinthe.Controls)
            {
                if (control.Location == point && control != pacman.sprite && control != fantomeAleatoire.sprite)
                {
                    panelLabyrinthe.Controls.Remove(control);
                    positionsPiecesSuppr.Add(point); // enregistrement de la position des pièces supprimées
                    lblScoreCount.Text = Convert.ToString(positionsPiecesSuppr.Count);
                    IsGameVictory();
                }
            }
        }

        /* ---------------- Déplacement de PacMan ---------------- */

        private async void FormPartie_KeyPress(object sender, KeyPressEventArgs e)
        {
            Image rotateImage = Properties.Resources.pacMan;
            if (char.ToUpper(e.KeyChar) == partie.toucheHaut)
            {
                if (pacman.position.Y > 2)
                {
                    rotateImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    int index = pacman.index - partie.largeur;
                    if (pacman.currentCellule.isLien(labyrinthe.getCellules()[index]))
                    {
                        pacman.position = new Point(pacman.position.X, pacman.position.Y - 50);
                        pacman.currentCellule = labyrinthe.getCellules()[index];
                        pacman.index = index;
                        if (pacman.sprite.Image != rotateImage)
                        {
                            pacman.sprite.Image = rotateImage;
                        }
                    }
                }
            }
            else if (char.ToUpper(e.KeyChar) == partie.toucheBas)
            {
                if (pacman.position.Y < partie.hauteur * 50 - 52)
                {
                    rotateImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    int index = pacman.index + partie.largeur;
                    if (pacman.currentCellule.isLien(labyrinthe.getCellules()[index]))
                    {
                        pacman.position = new Point(pacman.position.X, pacman.position.Y + 50);
                        pacman.currentCellule = labyrinthe.getCellules()[index];
                        pacman.index = index;
                        if (pacman.sprite.Image != rotateImage)
                        {
                            pacman.sprite.Image = rotateImage;
                        }
                    }
                }
            }
            else if (char.ToUpper(e.KeyChar) == partie.toucheGauche)
            {
                if (pacman.position.X > 2)
                {
                    rotateImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    int index = pacman.index - 1;
                    if (pacman.currentCellule.isLien(labyrinthe.getCellules()[index]))
                    {
                        pacman.position = new Point(pacman.position.X - 50, pacman.position.Y);
                        pacman.currentCellule = labyrinthe.getCellules()[index];
                        pacman.index = index;
                        if (pacman.sprite.Image != rotateImage)
                        {
                            pacman.sprite.Image = rotateImage;
                        }
                    }
                }
            }
            else if (char.ToUpper(e.KeyChar) == partie.toucheDroite)
            {
                if (pacman.position.X < partie.largeur * 50 - 52)
                {
                    int index = pacman.index + 1;
                    if (pacman.currentCellule.isLien(labyrinthe.getCellules()[index]))
                    {
                        pacman.position = new Point(pacman.position.X + 50, pacman.position.Y);
                        pacman.currentCellule = labyrinthe.getCellules()[index];
                        pacman.index = index;
                        if (pacman.sprite.Image != rotateImage)
                        {
                            pacman.sprite.Image = rotateImage;
                        }
                    }
                }
            }
            Colision_PacMan_Fantome(pacman, fantomeAleatoire);
            RemoveControlAtPosition(pacman.position);
            LoopStart();
        }

        /*
        private async void FormPartie_KeyPress(object sender, KeyPressEventArgs e)
        {
            Image rotateImage = Properties.Resources.pacMan;
            if (char.ToUpper(e.KeyChar) == partie.toucheHaut)
            {                
                if (pacman.position.Y > 2)
                {
                    int index = pacman.index - partie.largeur;

                    rotateImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    if (pacman.sprite.Image != rotateImage)
                    {
                        pacman.sprite.Image = rotateImage;
                    }

                    while (pacman.currentCellule.isLien(labyrinthe.getCellules()[index]) && pacman.position.Y > 2)
                    {
                        pacman.position = new Point(pacman.position.X, pacman.position.Y - 50);
                        pacman.currentCellule = labyrinthe.getCellules()[index];
                        pacman.index = index;
                        RemoveControlAtPosition(pacman.position);
                        index = pacman.index - partie.largeur;
                        await Task.Delay(speed);
                    }
                }
            }
            else if (char.ToUpper(e.KeyChar) == partie.toucheBas)
            {
                if (pacman.position.Y < partie.hauteur * 50 - 52)
                {
                    int index = pacman.index + partie.largeur;

                    rotateImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    if (pacman.sprite.Image != rotateImage)
                    {
                        pacman.sprite.Image = rotateImage;
                    }

                    while (pacman.currentCellule.isLien(labyrinthe.getCellules()[index]) && pacman.position.Y < partie.hauteur * 50 - 52)
                    {
                        pacman.position = new Point(pacman.position.X, pacman.position.Y + 50);
                        pacman.currentCellule = labyrinthe.getCellules()[index];
                        pacman.index = index;
                        RemoveControlAtPosition(pacman.position);
                        index = pacman.index + partie.largeur;
                        await Task.Delay(speed);
                    }
                }
            }
            else if (char.ToUpper(e.KeyChar) == partie.toucheGauche)
            {
                if (pacman.position.X > 2)
                {
                    int index = pacman.index - 1;

                    rotateImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    if (pacman.sprite.Image != rotateImage)
                    {
                        pacman.sprite.Image = rotateImage;
                    }

                    while (pacman.currentCellule.isLien(labyrinthe.getCellules()[index]) && pacman.position.X > 2)
                    {
                        pacman.position = new Point(pacman.position.X - 50, pacman.position.Y);
                        pacman.currentCellule = labyrinthe.getCellules()[index];
                        pacman.index = index;
                        RemoveControlAtPosition(pacman.position);
                        index = pacman.index + partie.largeur;
                        await Task.Delay(speed);
                    }
                }
            }
            else if (char.ToUpper(e.KeyChar) == partie.toucheDroite)
            {
                if (pacman.position.X < partie.largeur * 50 - 52)
                {
                    int index = pacman.index + 1;

                    if (pacman.sprite.Image != rotateImage)
                    {
                        pacman.sprite.Image = rotateImage;
                    }

                    while (pacman.currentCellule.isLien(labyrinthe.getCellules()[index]) && pacman.position.X < partie.largeur * 50 - 52)
                    {
                        pacman.position = new Point(pacman.position.X + 50, pacman.position.Y);
                        pacman.currentCellule = labyrinthe.getCellules()[index];
                        pacman.index = index;
                        RemoveControlAtPosition(pacman.position);
                        index = pacman.index + 1;
                        await Task.Delay(speed);
                    }
                }
            }
            LoopStart();
        }
        */

        /* ---------------- Colision PacMan Fantome ---------------- */

        private void Colision_PacMan_Fantome(Character pacman, Character fantome)
        {
            if (fantome.position == pacman.position)
            {
                isRunning = false;
                Reset_PacMan();
                Reset_Fantome(fantome);
                tlpVies.Controls.RemoveAt(nbVie);
                nbVie--;
                IsGameDefeat();
            }
        }

        /* ---------------- Fonction asynchrone ---------------- */

        private async void LoopStart()
        {
            if (!isRunning)
            {
                isRunning = true;
                await RunLoopAsyncFantome2();
            }
        }

        private async Task RunLoopAsyncFantome1()
        {
            UneCellule lastCellule = fantomeAleatoire.currentCellule;
            while (isRunning)
            {
                UneCellule nextCellule = fantomeAleatoire.currentCellule.getLiens().First(cellule => cellule != lastCellule);
                Point point = new Point(nextCellule.getY() * 50 + 2, nextCellule.getX() * 50 + 2);
                fantomeAleatoire.position = point;
                lastCellule = fantomeAleatoire.currentCellule;
                fantomeAleatoire.currentCellule = nextCellule;
                Colision_PacMan_Fantome(pacman, fantomeAleatoire);
                await Task.Delay(speed);
            }
        }

        private async Task RunLoopAsyncFantome2()
        {
            Random random = new Random();
            UneCellule lastCellule = fantomeAleatoire.currentCellule;
            List<UneCellule> cellulesVisited = [lastCellule];
            while (isRunning)
            {
                UneCellule nextCellule = fantomeAleatoire.currentCellule.getVoisins().First(cellule => cellule.isLien(fantomeAleatoire.currentCellule) && cellule != cellulesVisited.Last());
                Point point = new Point(nextCellule.getY() * 50 + 2, nextCellule.getX() * 50 + 2);
                fantomeAleatoire.position = point;
                lastCellule = fantomeAleatoire.currentCellule;
                cellulesVisited.Add(fantomeAleatoire.currentCellule);
                fantomeAleatoire.currentCellule = nextCellule;

                if (cellulesVisited.Contains(fantomeAleatoire.currentCellule))
                {
                    for (int i = 0; i < cellulesVisited.Count; i++)
                    {
                        cellulesVisited[i].randomVoisin(random);
                    }
                    cellulesVisited.Clear();
                    cellulesVisited = [fantomeAleatoire.currentCellule, lastCellule];
                }
                Colision_PacMan_Fantome(pacman, fantomeAleatoire);
                await Task.Delay(500);
            }
        }

        /* ---------------- Binaire ---------------- */

        public string binaireConvert(UneCellule currentCellule, int index, int mode)
        {
            switch (mode)
            {
                case 1:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1111";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1110";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1101";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1100";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1011";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1010";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1001";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1000";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0111";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0110";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0101";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0100";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0011";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0010";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0001";
                    }
                    else
                    {
                        return "0000"; // haut, bas, gauche, droite
                    }

                case 2:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0111";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0110";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0101";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0100";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0011";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0010";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0001";
                    }
                    else
                    {
                        return "0000"; // haut, bas, gauche, droite
                    }

                case 3:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1011";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1010";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1001";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1000";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0011";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0010";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0001";
                    }
                    else
                    {
                        return "0000"; // haut, bas, gauche, droite
                    }

                case 4:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1101";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1100";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1001";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1000";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0101";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0100";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0001";
                    }
                    else
                    {
                        return "0000"; // haut, bas, gauche, droite
                    }

                case 5:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "1110";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "1100";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "1010";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "1000";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "0110";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "0100";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "0010";
                    }
                    else
                    {
                        return "0000"; // haut, bas, gauche, droite
                    }

                default:
                    return "0000";
            }
        }

        /* ---------------- Affichage ---------------- */

        private void affichageLabyrinthe()
        {
            int index = 0;
            UneCellule currentCellule;

            for (int i = 0; i < partie.hauteur; i++)
            {
                for (int j = 0; j < partie.largeur; j++)
                {
                    CaseLabyrinthe caseLabyrinthe = new CaseLabyrinthe(tlpLabyrinthe);
                    currentCellule = labyrinthe.getCellules()[index];

                    if (currentCellule.getVoisins().Count == 4)
                    {
                        if (binaireConvert(currentCellule, index, 1) == "1110")
                        {
                            caseLabyrinthe.Image = Properties.Resources.droite;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "1101")
                        {
                            caseLabyrinthe.Image = Properties.Resources.gauche;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "1011")
                        {
                            caseLabyrinthe.Image = Properties.Resources.bas;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "0111")
                        {
                            caseLabyrinthe.Image = Properties.Resources.haut;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "1100")
                        {
                            caseLabyrinthe.Image = Properties.Resources.gauche_droite;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "1001")
                        {
                            caseLabyrinthe.Image = Properties.Resources.angle_bas_gauche;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "0011")
                        {
                            caseLabyrinthe.Image = Properties.Resources.haut_bas;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "0110")
                        {
                            caseLabyrinthe.Image = Properties.Resources.angle_haut_droite;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "1010")
                        {
                            caseLabyrinthe.Image = Properties.Resources.angle_bas_droite;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "0101")
                        {
                            caseLabyrinthe.Image = Properties.Resources.angle_haut_gauche;
                        }
                        else
                        {

                        }
                    }
                    else if (currentCellule.getVoisins().Count == 3)
                    {
                        if (i == 0)
                        {
                            if (binaireConvert(currentCellule, index, 2) == "0111")
                            {
                                caseLabyrinthe.Image = Properties.Resources.haut;
                            }
                            else if (binaireConvert(currentCellule, index, 2) == "0011")
                            {
                                caseLabyrinthe.Image = Properties.Resources.haut_bas;
                            }
                            else if (binaireConvert(currentCellule, index, 2) == "0110")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_droite;
                            }
                            else if (binaireConvert(currentCellule, index, 2) == "0101")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_gauche;
                            }
                            else
                            {

                            }
                        }
                        else if (i == partie.hauteur - 1)
                        {
                            if (binaireConvert(currentCellule, index, 3) == "1011")
                            {
                                caseLabyrinthe.Image = Properties.Resources.bas;
                            }
                            else if (binaireConvert(currentCellule, index, 3) == "1001")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_gauche;
                            }
                            else if (binaireConvert(currentCellule, index, 3) == "0011")
                            {
                                caseLabyrinthe.Image = Properties.Resources.haut_bas;
                            }
                            else if (binaireConvert(currentCellule, index, 3) == "1010")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_droite;
                            }
                            else
                            {

                            }
                        }
                        else if (j == 0)
                        {
                            if (binaireConvert(currentCellule, index, 4) == "1101")
                            {
                                caseLabyrinthe.Image = Properties.Resources.gauche;
                            }
                            else if (binaireConvert(currentCellule, index, 4) == "1100")
                            {
                                caseLabyrinthe.Image = Properties.Resources.gauche_droite;
                            }
                            else if (binaireConvert(currentCellule, index, 4) == "1001")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_gauche;
                            }
                            else if (binaireConvert(currentCellule, index, 4) == "0101")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_gauche;
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            if (binaireConvert(currentCellule, index, 5) == "1110")
                            {
                                caseLabyrinthe.Image = Properties.Resources.droite;
                            }
                            else if (binaireConvert(currentCellule, index, 5) == "1100")
                            {
                                caseLabyrinthe.Image = Properties.Resources.gauche_droite;
                            }
                            else if (binaireConvert(currentCellule, index, 5) == "0110")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_droite;
                            }
                            else if (binaireConvert(currentCellule, index, 5) == "1010")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_droite;
                            }
                            else
                            {

                            }
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_gauche;
                            }
                            else
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_droite;
                            }
                        }
                        else
                        {
                            if (j == 0)
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_gauche;
                            }
                            else
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_droite;
                            }
                        }
                    }
                    index++;
                }
            }
        }

        private void FormPartie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isVictory == true || isDefeat == true)
            {
                formMenuPrincipal.Show();
            }
            else
            {
                formMenuPrincipal.Close();
            }
        }
    }
}
