using Bibliotheque_PacMan;
using BibliothequePacMan;
using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private System.Windows.Forms.Timer timer;

        private Partie partie;
        private Labyrinthe labyrinthe;

        private TableLayoutPanel tlpLabyrinthe;

        private PacMan pacMan;
        private Character fantomeAleatoire;

        private List<Point> positionsPiecesSuppr;

        private Point pacmanSpawnPosition;
        private Point fantomeSpawnPosition;

        private UneCellule pacmanSpawnCellule;
        private UneCellule fantomeSpawnCellule;

        private int speed = 400;
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
            Init_Timer();
            lblPseudoChange.Text = partie.pseudo;

            Size autoScrollSize = new Size(panelLabyrinthe.Width, panelLabyrinthe.Height);
            tlpGrille.AutoScrollMinSize = autoScrollSize;

            affichageLabyrinthe();
            Init_PacMan(panelLabyrinthe);
            Init_Pieces(panelLabyrinthe);
            Init_FantomeAleatoire(panelLabyrinthe);

            pacMan.BringToFront();
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
            lblScoreCount.Text = Convert.ToString(positionsPiecesSuppr.Count + partie.score);
        }

        private void Init_PacMan(Panel panel)
        {
            int index = partie.largeur + 1;
            pacMan = new PacMan(partie.couleur, labyrinthe.getCellules()[index]);
            positionsPiecesSuppr = [pacMan.Position];

            panel.Controls.Add(pacMan);
            pacMan.Index = index;
            pacmanSpawnPosition = pacMan.Position;
            pacmanSpawnCellule = pacMan.CurrentCellule;
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
            for (int i = 1; i < partie.nbVie + 1; i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Margin = new Padding(5);
                pictureBox.Dock = DockStyle.Fill;
                pictureBox.Image = Properties.Resources.coeur;
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Name = "vie" + i;

                tlpVies.Controls.Add(pictureBox, i, 0);
            }
        }

        private void Init_Timer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            lblTimerChange.Text = "02:00";
        }

        /* ---------------- Fonctions de réinitialisation ---------------- */

        private void Reset_PacMan()
        {
            pacMan.Position = pacmanSpawnPosition;
            pacMan.CurrentCellule = pacmanSpawnCellule;
            pacMan.Index = pacmanSpawnCellule.getY() * partie.largeur + pacmanSpawnCellule.getX();
        }

        private void Reset_Fantome()
        {
            fantomeAleatoire.position = fantomeSpawnPosition;
            fantomeAleatoire.currentCellule = fantomeSpawnCellule;
            fantomeAleatoire.index = fantomeSpawnCellule.getY() * partie.largeur + fantomeSpawnCellule.getX();
            isRunning = false;
        }

        /* ---------------- Condition de victoire et défaite ---------------- */

        private void GameClose()
        {
            Reset_PacMan();
            Reset_Fantome();
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
                partie.score = Convert.ToInt32(lblScoreCount.Text);
                partie.level += 1;
                partie.Init_Dimensions();
                GameClose();
            }
        }

        private void IsGameDefeat()
        {
            if (partie.nbVie == 0)
            {
                isRunning = false;
                isDefeat = true;
                partie.score = Convert.ToInt32(lblScoreCount.Text);
                GameClose();
            }
            else
            {
                isRunning = false;
                MessageBox.Show($"Vous perdez une vie, il vous en reste {partie.nbVie}.");
            }
        }

        /* ---------------- Récolte des pieces ---------------- */

        private void RemoveControlAtPosition(Point point)
        {
            foreach (Control control in panelLabyrinthe.Controls)
            {
                if (control.Location == point && control != pacMan && control != fantomeAleatoire.sprite)
                {
                    panelLabyrinthe.Controls.Remove(control);
                    positionsPiecesSuppr.Add(point); // enregistrement de la position des pièces supprimées
                    lblScoreCount.Text = Convert.ToString(positionsPiecesSuppr.Count + partie.score);
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
                if (pacMan.Position.Y > 2)
                {
                    rotateImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    int index = pacMan.Index - partie.largeur;
                    if (pacMan.CurrentCellule.isLien(labyrinthe.getCellules()[index]))
                    {
                        pacMan.Position = new Point(pacMan.Position.X, pacMan.Position.Y - 50);
                        pacMan.CurrentCellule = labyrinthe.getCellules()[index];
                        pacMan.Index = index;
                        if (pacMan.Direction != PacManDirection.Up)
                        {
                            pacMan.Direction = PacManDirection.Up;
                        }
                    }
                }
            }
            else if (char.ToUpper(e.KeyChar) == partie.toucheBas)
            {
                if (pacMan.Position.Y < partie.hauteur * 50 - 52)
                {
                    rotateImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    int index = pacMan.Index + partie.largeur;
                    if (pacMan.CurrentCellule.isLien(labyrinthe.getCellules()[index]))
                    {
                        pacMan.Position = new Point(pacMan.Position.X, pacMan.Position.Y + 50);
                        pacMan.CurrentCellule = labyrinthe.getCellules()[index];
                        pacMan.Index = index;
                        if (pacMan.Direction != PacManDirection.Down)
                        {
                            pacMan.Direction = PacManDirection.Down;
                        }
                    }
                }
            }
            else if (char.ToUpper(e.KeyChar) == partie.toucheGauche)
            {
                if (pacMan.Position.X > 2)
                {
                    rotateImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    int index = pacMan.Index - 1;
                    if (pacMan.CurrentCellule.isLien(labyrinthe.getCellules()[index]))
                    {
                        pacMan.Position = new Point(pacMan.Position.X - 50, pacMan.Position.Y);
                        pacMan.CurrentCellule = labyrinthe.getCellules()[index];
                        pacMan.Index = index;
                        if (pacMan.Direction != PacManDirection.Left)
                        {
                            pacMan.Direction = PacManDirection.Left;
                        }
                    }
                }
            }
            else if (char.ToUpper(e.KeyChar) == partie.toucheDroite)
            {
                if (pacMan.Position.X < partie.largeur * 50 - 52)
                {
                    int index = pacMan.Index + 1;
                    if (pacMan.CurrentCellule.isLien(labyrinthe.getCellules()[index]))
                    {
                        pacMan.Position = new Point(pacMan.Position.X + 50, pacMan.Position.Y);
                        pacMan.CurrentCellule = labyrinthe.getCellules()[index];
                        pacMan.Index = index;
                        if (pacMan.Direction != PacManDirection.Right)
                        {
                            pacMan.Direction = PacManDirection.Right;
                        }
                    }
                }
            }
            Colision_PacMan_Fantome(fantomeAleatoire);
            RemoveControlAtPosition(pacMan.Position);
            LoopStart();
        }

        /* ---------------- Colision PacMan Fantome ---------------- */

        private void Colision_PacMan_Fantome(Character fantome)
        {
            if (fantome.position == pacMan.Position)
            {
                isRunning = false;
                Reset_PacMan();
                Reset_Fantome();
                tlpVies.Controls.RemoveAt(partie.nbVie);
                partie.nbVie--;
                IsGameDefeat();
            }
        }

        /* ---------------- Fonction asynchrone ---------------- */

        private async void LoopStart()
        {
            if (!isRunning && !isVictory && !isDefeat)
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
                Colision_PacMan_Fantome(fantomeAleatoire);
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

                Console.WriteLine($"{isRunning}");
                Colision_PacMan_Fantome(fantomeAleatoire);
                await Task.Delay(speed);
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
                FormFinPartie formFinPartie = new FormFinPartie(formMenuPrincipal, partie, isVictory);
                formFinPartie.Show();
            }
            else
            {
                formMenuPrincipal.Close();
            }
        }

        private async Task Pause(FormMenuPause formMenuPause)
        {
            while (formMenuPause.IsDisposed == false)
            {
                isRunning = false;
                await Task.Delay(100);
            }
            SaveTouches();
        }

        private void SaveTouches()
        {
            partie.toucheHaut = Convert.ToChar(ConfigurationManager.AppSettings["ToucheHaut"]);
            partie.toucheBas = Convert.ToChar(ConfigurationManager.AppSettings["ToucheBas"]);
            partie.toucheDroite = Convert.ToChar(ConfigurationManager.AppSettings["ToucheDroite"]);
            partie.toucheGauche = Convert.ToChar(ConfigurationManager.AppSettings["ToucheGauche"]);
        }

        private async void FormPartie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormMenuPause formMenuPause = new FormMenuPause(formMenuPrincipal, this);
                formMenuPause.Show();
                this.Hide();
                Pause(formMenuPause);
            }
        }

        private void FormPartie_SizeChanged(object sender, EventArgs e)
        {
            float fontHeight = lblScore.Size.Height / 5;

            if (fontHeight > 0)
            {
                lblScore.Font = new Font(lblScore.Font.FontFamily, fontHeight, FontStyle.Bold);
                lblScoreCount.Font = new Font(lblScoreCount.Font.FontFamily, fontHeight, FontStyle.Bold);
                lblVies.Font = new Font(lblVies.Font.FontFamily, fontHeight, FontStyle.Bold);
                lblPseudo.Font = new Font(lblPseudo.Font.FontFamily, fontHeight, FontStyle.Bold);
                lblPseudoChange.Font = new Font(lblPseudoChange.Font.FontFamily, fontHeight, FontStyle.Bold);
                lblTimer.Font = new Font(lblTimer.Font.FontFamily, fontHeight, FontStyle.Bold);
                lblTimerChange.Font = new Font(lblTimerChange.Font.FontFamily, fontHeight, FontStyle.Bold);
            }
        }
    }
}
