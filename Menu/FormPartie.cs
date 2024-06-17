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
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Threading;
using System.Linq.Expressions;
using NAudio.Utils;

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
        private Character fantomePCC;

        private List<Point> positionsPieces;
        private List<Point> positionsBonus;

        private Point pacmanSpawnPosition;
        private Point fantomeSpawnPosition;

        private UneCellule pacmanSpawnCellule;

        private int timeLeft;
        private int pacManSpeed = 8;

        private bool isMoving = false;
        private bool isRunning = false;
        private bool isVictory = false;
        private bool isDefeat = false;

        private char currentDirection = '\0';

        private CancellationTokenSource cancellationTokenSource;
        private CancellationTokenSource pacManTokenSource;

        /* ---------------- Constructeur FormPartie ---------------- */

        public FormPartie(FormMenuPrincipal formMenuPrincipal, Partie partie)
        {
            InitializeComponent();
            this.partie = partie;
            this.formMenuPrincipal = formMenuPrincipal;
            cancellationTokenSource = new CancellationTokenSource();
            pacManTokenSource = new CancellationTokenSource();
        }

        /* ---------------- Fonction lancement du formulaire ---------------- */

        private void FormPartie_Load(object sender, EventArgs e)
        {
            Init_DimensionsMax();
            partie.Init_Dimensions();

            labyrinthe = new Labyrinthe(partie.Hauteur, partie.Largeur);
            labyrinthe.algoParcoursProfondeur();

            Init_CenterTableLayoutPanel();
            tlpLabyrinthe = new TableLayoutPanel();
            Init_TableLayoutPanel(tlpLabyrinthe);
            panelLabyrinthe.Controls.Add(tlpLabyrinthe);
            Init_Vies();
            Init_Timer();
            lblPseudoChange.Text = partie.Pseudo;

            Size autoScrollSize = new(panelLabyrinthe.Width, panelLabyrinthe.Height);
            tlpGrille.AutoScrollMinSize = autoScrollSize;

            AffichageLabyrinthe();
            Init_PacMan(panelLabyrinthe);
            Init_Bonus(panelLabyrinthe);
            Init_Pieces(panelLabyrinthe);
            pacMan.BringToFront();

            Init_FantomePCC(panelLabyrinthe);
            Init_FantomeAleatoire(panelLabyrinthe);
        }

        /* ---------------- Fonctions d'initialisation ---------------- */

        private void Init_DimensionsMax()
        {
            partie.HauteurMax = (this.Height * 0.80) / 50;
            partie.LargeurMax = (this.Width - 20) / 50;
        }

        private void Init_Pieces(Panel panel)
        {
            positionsPieces = new List<Point>();

            for (int i = 2; i < partie.Hauteur * 50; i += 50)
            {
                for (int j = 2; j < partie.Largeur * 50; j += 50)
                {
                    Point point = new(j, i);
                    if (!point.Equals(pacmanSpawnPosition) && !positionsBonus.Contains(point))
                    {
                        Objet piece = new(Properties.Resources.piece, point);

                        positionsPieces.Add(point);
                        panel.Controls.Add(piece.sprite);
                        piece.sprite.BringToFront();
                    }
                }
            }
            lblScoreCount.Text = Convert.ToString(partie.Score);
        }

        private Objet Select_Bonus(Random random, Point point)
        {
            Objet bonus;
            switch (random.Next(3))
            {
                case 0:
                    bonus = new Objet(Properties.Resources.bonus_vie, point);
                    bonus.sprite.Tag = "bonusVie";
                    break;

                case 1:
                    bonus = new Objet(Properties.Resources.bonus_vitesse, point);
                    bonus.sprite.Tag = "bonusVitesse";
                    break;

                default:
                    bonus = new Objet(Properties.Resources.bonus_temps, point);
                    bonus.sprite.Tag = "bonusTemps";
                    break;
            }
            return bonus;
        }

        private void Init_Bonus(Panel panel)
        {
            Random random = new Random();
            positionsBonus = new List<Point>();
            
            for (int i = 0; i < 3 + partie.Level; i++)
            {
                Point point;

                do
                {
                    point = new Point(random.Next(partie.Largeur) * 50 + 2, random.Next(partie.Hauteur) * 50 + 2);
                } while (positionsBonus.Contains(point) && point == pacmanSpawnPosition); // point.Equals(pacmanSpawnPosition);

                Objet bonus = Select_Bonus(random, point);

                positionsBonus.Add(bonus.position);
                panel.Controls.Add(bonus.sprite);
                bonus.sprite.BringToFront();
            }
        }

        private void Init_PacMan(Panel panel)
        {
            int index = partie.Largeur + 1;
            pacMan = new PacMan(partie.Couleur, labyrinthe.getCellules()[index]);

            panel.Controls.Add(pacMan);
            pacMan.Index = index;
            pacmanSpawnPosition = pacMan.Position;
            pacmanSpawnCellule = pacMan.CurrentCellule;
        }

        private void Init_FantomeAleatoire(Panel panel)
        {
            int index = (partie.Largeur * (partie.Hauteur / 2) + (partie.Largeur / 2));
            Image image = Properties.Resources.fantomeRouge;
            fantomeAleatoire = new Character(image, labyrinthe.getCellules()[index]);

            panel.Controls.Add(fantomeAleatoire.Sprite);
            fantomeAleatoire.Index = index;
            fantomeAleatoire.Sprite.BringToFront();

            fantomeSpawnPosition = fantomeAleatoire.Position;
        }

        private void Init_FantomePCC(Panel panel)
        {
            int index = (partie.Largeur * (partie.Hauteur / 2) + (partie.Largeur / 2) + 1);
            Image image = Properties.Resources.fantomeBleu;
            fantomePCC = new Character(image, labyrinthe.getCellules()[index]);

            panel.Controls.Add(fantomePCC.Sprite);
            fantomePCC.Index = index;
            fantomePCC.Sprite.BringToFront();
        }

        private void Init_TableLayoutPanel(TableLayoutPanel tlp)
        {
            tlp.RowCount = partie.Hauteur;
            tlp.ColumnCount = partie.Largeur;
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
                    tlpGrille.RowStyles.Add(new RowStyle(SizeType.Absolute, partie.Hauteur * 50 + 4));
                    tlpGrille.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, partie.Largeur * 50 + 4));
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
            for (int i = 1; i < partie.NbVie + 1; i++)
            {
                PictureBox pictureBox = new()
                {
                    Margin = new Padding(5),
                    Dock = DockStyle.Fill,
                    Image = Properties.Resources.coeur,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Name = "vie" + i
                };

                tlpVies.Controls.Add(pictureBox, i, 0);
            }
        }

        private void Init_Timer()
        {
            timeLeft = partie.Init_TimerStatValue();
            timer = new System.Windows.Forms.Timer
            {
                Interval = 1000,
            };
            timer.Tick += Timer_Tick;
            UpdateTimerDisplay();
        }

        /* ---------------- Fonctions Timer ---------------- */

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                UpdateTimerDisplay();
            }
            else
            {
                timer.Stop();
                lblTimerChange.Text = "00:00";
                partie.NbVie = 0;
                IsGameDefeat();
            }
        }

        private void UpdateTimerDisplay()
        {
            int minutes = timeLeft / 60;
            int seconds = timeLeft % 60;
            lblTimerChange.Text = $"{minutes:D2}:{seconds:D2}";

            if (timeLeft <= 20)
            {
                lblTimer.ForeColor = Color.Red;
                lblTimerChange.ForeColor = Color.Red;
            }
        }

        /* ---------------- Fonctions de réinitialisation ---------------- */
        // Réinitialisation de PacMan
        // Réinitialisation du fantome
        // Réinitialisation de toutes les fonctions asyncrones

        private void Reset_PacMan()
        {
            pacMan.Position = pacmanSpawnPosition;
            pacMan.CurrentCellule = pacmanSpawnCellule;
            pacMan.Index = pacmanSpawnCellule.getY() * partie.Largeur + pacmanSpawnCellule.getX();
            isMoving = false;
        }
        
        private void Reset_Fantome()
        {
            fantomeAleatoire.Position = fantomeSpawnPosition;
            fantomePCC.Position = new(fantomeSpawnPosition.X + 50, fantomeSpawnPosition.Y);

            fantomeAleatoire.CurrentCellule = labyrinthe.getCellules()[fantomeAleatoire.Index];
            fantomePCC.CurrentCellule = labyrinthe.getCellules()[fantomePCC.Index];

            isRunning = false;
        }

        private void Reset_Token()
        {
            if (cancellationTokenSource.IsCancellationRequested)
                cancellationTokenSource = new CancellationTokenSource();
        }

        private void Reset_PacManToken()
        {
            pacManTokenSource.Cancel();
            pacManTokenSource = new CancellationTokenSource();
        }

        /* ---------------- Fermeture du jeu ---------------- */

        private void GameClose()
        {
            cancellationTokenSource.Cancel();
            Reset_PacMan();
            Reset_Fantome();
            tlpLabyrinthe.Controls.Clear();
            panelLabyrinthe.Controls.Clear();
            this.Close();
        }

        /* ---------------- Condition de victoire et défaite ---------------- */

        private void IsGameVictory()
        {
            if (positionsPieces.Count == 0)
            {
                timer.Stop();
                isRunning = false;
                isVictory = true;
                partie.Score = Convert.ToInt32(lblScoreCount.Text);
                partie.Level += 1;
                partie.Init_Dimensions();
                GameClose();
            }
        }

        private void IsGameDefeat()
        {
            timer.Stop();
            if (partie.NbVie == 0)
            {
                isRunning = false;
                isDefeat = true;
                partie.Score = Convert.ToInt32(lblScoreCount.Text);
                GameClose();
            }
            else
            {
                isRunning = false;
                MessageBox.Show($"Vous perdez une vie, il vous en reste {partie.NbVie}.");
            }
        }

        /* ---------------- Récolte des pieces et/ou bonus ---------------- */

        private void RemoveControlAtPosition(Point point)
        {
            foreach (Control control in panelLabyrinthe.Controls)
            {
                if (control.Location == point && control != pacMan && control != fantomeAleatoire.Sprite)
                {
                    if (positionsPieces.Contains(point))
                    {
                        positionsPieces.Remove(point);
                        lblScoreCount.Text = Convert.ToString(Convert.ToInt32(lblScoreCount.Text) + 1);
                    }
                    else if (positionsBonus.Contains(point))
                    {
                        switch (control.Tag)
                        {
                            case "bonusVie":
                                if (tlpVies.Controls.Count < 6)
                                {
                                    PictureBox pictureBox = new()
                                    {
                                        Margin = new Padding(5),
                                        Dock = DockStyle.Fill,
                                        Image = Properties.Resources.coeur,
                                        SizeMode = PictureBoxSizeMode.Zoom,
                                        Name = "vie" + tlpVies.Controls.Count
                                    };

                                    tlpVies.Controls.Add(pictureBox, tlpVies.Controls.Count, 0);
                                    partie.NbVie++;
                                }
                                break;

                            case "bonusTemps":
                                timeLeft += 10;
                                break;
                        }
                        positionsBonus.Remove(point);
                        lblScoreCount.Text = Convert.ToString(Convert.ToInt32(lblScoreCount.Text) + 10);
                    }
                    panelLabyrinthe.Controls.Remove(control);
                    IsGameVictory();
                }
            }
        }

        /* ---------------- Déplacement de PacMan ---------------- */
        // Ces 4 fonctions asyncrones permettent le mouvement fluide de PacMan à l'interieur du labyrinthe

        private async Task Up(CancellationToken cancellationToken)
        {
            if (pacMan.Position.Y > 2 && !isMoving)
            {
                int index = pacMan.Index - partie.Largeur;

                isMoving = true;
                Point point = new Point(pacMan.Position.X, pacMan.Position.Y - 50);

                if (pacMan.Direction != PacManDirection.Up)
                {
                    pacMan.Direction = PacManDirection.Up;
                }

                while (pacMan.Position != point)
                {
                    pacMan.Position = new Point(pacMan.Position.X, pacMan.Position.Y - 2);
                    try
                    {
                        Colision_PacMan_Fantome(fantomeAleatoire);
                        await Task.Delay(pacManSpeed, cancellationToken);
                    }
                    catch
                    {
                        Reset_PacMan();
                        return;
                    }
                }

                pacMan.Index = index;
                pacMan.CurrentCellule = labyrinthe.getCellules()[index];
                isMoving = false;
            }
            VerifApresDeplacement();
        }

        private async Task Down(CancellationToken cancellationToken)
        {
            if (pacMan.Position.Y < partie.Hauteur * 50 - 52 && !isMoving)
            {
                int index = pacMan.Index + partie.Largeur;

                isMoving = true;
                Point point = new Point(pacMan.Position.X, pacMan.Position.Y + 50);

                if (pacMan.Direction != PacManDirection.Down)
                {
                    pacMan.Direction = PacManDirection.Down;
                }

                while (pacMan.Position != point)
                {
                    pacMan.Position = new Point(pacMan.Position.X, pacMan.Position.Y + 2);
                    try
                    {
                        Colision_PacMan_Fantome(fantomeAleatoire);
                        await Task.Delay(pacManSpeed, cancellationToken);
                    }
                    catch
                    {
                        Reset_PacMan();
                        return;
                    }
                }

                pacMan.Index = index;
                pacMan.CurrentCellule = labyrinthe.getCellules()[index];
                isMoving = false;
            }
            VerifApresDeplacement();
        }

        private async Task Left(CancellationToken cancellationToken)
        {
            if (pacMan.Position.X > 2 && !isMoving)
            {
                int index = pacMan.Index - 1;

                isMoving = true;
                Point point = new Point(pacMan.Position.X - 50, pacMan.Position.Y);

                if (pacMan.Direction != PacManDirection.Left)
                {
                    pacMan.Direction = PacManDirection.Left;
                }

                while (pacMan.Position != point)
                {
                    pacMan.Position = new Point(pacMan.Position.X - 2, pacMan.Position.Y);
                    try
                    {
                        Colision_PacMan_Fantome(fantomeAleatoire);
                        await Task.Delay(pacManSpeed, cancellationToken);
                    }
                    catch
                    {
                        Reset_PacMan();
                        return;
                    }
                }

                pacMan.Index = index;
                pacMan.CurrentCellule = labyrinthe.getCellules()[index];
                isMoving = false;
            }
            VerifApresDeplacement();
        }

        private async Task Right(CancellationToken cancellationToken)
        {
            if (pacMan.Position.X < partie.Largeur * 50 - 52 && !isMoving)
            {
                int index = pacMan.Index + 1;

                isMoving = true;
                Point point = new Point(pacMan.Position.X + 50, pacMan.Position.Y);

                if (pacMan.Direction != PacManDirection.Right)
                {
                    pacMan.Direction = PacManDirection.Right;
                }

                while (pacMan.Position != point)
                {
                    pacMan.Position = new Point(pacMan.Position.X + 2, pacMan.Position.Y);
                    try
                    {
                        Colision_PacMan_Fantome(fantomeAleatoire);
                        await Task.Delay(pacManSpeed, cancellationToken);
                    }
                    catch
                    {
                        Reset_PacMan();
                        return;
                    }
                }

                pacMan.Index = index;
                pacMan.CurrentCellule = labyrinthe.getCellules()[index];
                isMoving = false;
            }
            VerifApresDeplacement();
        }

        /* ---------------- Fonctions de vérifications du déplacement de PacMan ---------------- */
        // Ces 4 fonctions permettent de vérifier si le mouvement de PacMan est possible
        // Mouvement possible si la cellule cible existe et elle est liée a la cellule actuelle

        private bool MouvementPossibleHaut()
        {
            try
            {
                int index = pacMan.Index - partie.Largeur;
                currentDirection = partie.ToucheHaut;
                return pacMan.CurrentCellule.isLien(labyrinthe.getCellules()[index]);
            }
            catch
            {
                return false;
            }
        }

        private bool MouvementPossibleBas()
        {
            try
            {
                int index = pacMan.Index + partie.Largeur;
                currentDirection = partie.ToucheBas;
                return pacMan.CurrentCellule.isLien(labyrinthe.getCellules()[index]);
            }
            catch
            {
                return false;
            }
        }

        private bool MouvementPossibleGauche()
        {
            try
            {
                int index = pacMan.Index - 1;
                currentDirection = partie.ToucheGauche;
                return pacMan.CurrentCellule.isLien(labyrinthe.getCellules()[index]);
            }
            catch
            {
                return false;
            }
        }

        private bool MouvementPossibleDroite()
        {
            try
            {
                int index = pacMan.Index + 1;
                currentDirection = partie.ToucheDroite;
                return pacMan.CurrentCellule.isLien(labyrinthe.getCellules()[index]);
            }
            catch
            {
                return false;
            }
        }

        /* ---------------- Fonction de vérification des touches ---------------- */

        private async void Deplacement(char touche)
        {
            Reset_Token();

            if (touche == currentDirection)
                return;

            Reset_PacManToken();
            currentDirection = touche;

            while (!pacManTokenSource.Token.IsCancellationRequested && currentDirection == touche)
            {
                try
                {
                    await Task.Delay(pacManSpeed, pacManTokenSource.Token);
                    if (touche == partie.ToucheHaut && MouvementPossibleHaut())
                    {
                        Console.WriteLine("Touche Haut");
                        await Up(cancellationTokenSource.Token);
                    }
                    else if (touche == partie.ToucheBas && MouvementPossibleBas())
                    {
                        Console.WriteLine("Touche Bas");
                        await Down(cancellationTokenSource.Token);
                    }
                    else if (touche == partie.ToucheGauche && MouvementPossibleGauche())
                    {
                        Console.WriteLine("Touche Gauche");
                        await Left(cancellationTokenSource.Token);
                    }
                    else if (touche == partie.ToucheDroite && MouvementPossibleDroite())
                    {
                        Console.WriteLine("Touche Droite");
                        await Right(cancellationTokenSource.Token);
                    }
                    else
                    {
                        break;
                    }
                }
                catch (OperationCanceledException)
                {
                    break;
                }
            }

            currentDirection = '\0';
        }

        /* ---------------- Touches alpha-numériques ---------------- */

        private async void FormPartie_KeyPress(object sender, KeyPressEventArgs e)
        {
            char touche = char.ToUpper(e.KeyChar);
            if (touche == partie.ToucheHaut || touche == partie.ToucheBas || touche == partie.ToucheGauche || touche == partie.ToucheDroite)
            {
                Deplacement(touche);
            }
        }

        /* ---------------- Vérifications après le déplacement de PacMan ---------------- */

        private void VerifApresDeplacement()
        {
            partie.PacManPosition = pacMan.Position;

            LoopStart();
            timer.Start();
            RemoveControlAtPosition(pacMan.Position);
        }

        /* ---------------- Colision PacMan Fantome ---------------- */

        private static bool Colision(Point fantomePosition, Point pacManPosition)
        {
            int deltaX = Math.Abs(fantomePosition.X - pacManPosition.X);
            int deltaY = Math.Abs(fantomePosition.Y - pacManPosition.Y);

            return deltaX <= 24 && deltaY <= 24;
        }

        private void Colision_PacMan_Fantome(Character fantome)
        {
            if (Colision(fantome.Position, pacMan.Position) && fantome.Position != pacMan.Position)
            {
                cancellationTokenSource.Cancel();
                pacManTokenSource.Cancel();
                isRunning = false;
                Reset_PacMan();
                Reset_Fantome();
                tlpVies.Controls.RemoveAt(partie.NbVie);
                partie.NbVie--;
                IsGameDefeat();
            }
        }

        /* ---------------- Mise en marche du fantome ---------------- */

        private async void LoopStart()
        {
            if (!isRunning && !isVictory && !isDefeat)
            {
                isRunning = true;
                FantomeAleatoireLoop();
                FantomePCCLoop();
            }
        }

        /* ---------------- Fonction asyncrone (Actions du fantome) ---------------- */

        private async void FantomeAleatoireLoop()
        {
            Random random = new();
            UneCellule lastCellule = fantomeAleatoire.CurrentCellule;
            List<UneCellule> cellulesVisited = new() { lastCellule };

            while (isRunning)
            {
                UneCellule nextCellule = fantomeAleatoire.CurrentCellule.getVoisins().First(cellule => cellule.isLien(fantomeAleatoire.CurrentCellule) && cellule != cellulesVisited.Last());

                await FantomeDeplacement(fantomeAleatoire, nextCellule, 14, cancellationTokenSource.Token);
                if (cancellationTokenSource.IsCancellationRequested)
                    return;

                lastCellule = fantomeAleatoire.CurrentCellule;
                cellulesVisited.Add(fantomeAleatoire.CurrentCellule);
                fantomeAleatoire.CurrentCellule = nextCellule;

                if (cellulesVisited.Contains(fantomeAleatoire.CurrentCellule))
                {
                    for (int i = 0; i < cellulesVisited.Count; i++)
                    {
                        cellulesVisited[i].randomVoisin(random);
                    }
                    cellulesVisited.Clear();
                    cellulesVisited = new() { fantomeAleatoire.CurrentCellule, lastCellule };
                }
            }
        }

        private async void FantomePCCLoop()
        {
            List<UneCellule> Chemin = new();

            while (isRunning)
            {
                Chemin = AlgoPlusCourtChemin(fantomePCC.CurrentCellule);
                Chemin.Remove(fantomePCC.CurrentCellule);

                await FantomeDeplacement(fantomePCC, Chemin.First(), 16, cancellationTokenSource.Token);
                if (cancellationTokenSource.IsCancellationRequested)
                    return;

                fantomePCC.CurrentCellule = Chemin.First();
            }
        }

        private List<UneCellule> AlgoPlusCourtChemin(UneCellule depart)
        {
            // Initialisation de la file et du dictionnaire des parents
            Queue<UneCellule> file = new Queue<UneCellule>();
            Dictionary<UneCellule, UneCellule> parents = new Dictionary<UneCellule, UneCellule>();

            file.Enqueue(depart);
            parents[depart] = null; // La cellule de départ n'a pas de parent

            while (file.Count > 0)
            {
                UneCellule current = file.Dequeue();

                // Vérifier si nous avons atteint la cellule cible
                if (current.Equals(pacMan.CurrentCellule))
                {
                    return ConstruireChemin(parents, current);
                }

                // Explorer les voisins
                foreach (UneCellule voisin in current.getLiens())
                {
                    if (!parents.ContainsKey(voisin)) // Si le voisin n'a pas encore été visité
                    {
                        file.Enqueue(voisin);
                        parents[voisin] = current; // Enregistrer le parent du voisin
                    }
                }
            }

            // Si aucun chemin trouvé, retourner une liste vide
            return new List<UneCellule>();
        }

        private List<UneCellule> ConstruireChemin(Dictionary<UneCellule, UneCellule> parents, UneCellule cible)
        {
            List<UneCellule> chemin = new List<UneCellule>();

            for (UneCellule cellule = cible; cellule != null; cellule = parents[cellule])
            {
                chemin.Insert(0, cellule); // Ajouter à la tête pour reconstruire le chemin dans le bon ordre
            }

            return chemin;
        }

        /* ---------------- Déplacement du fantome ---------------- */

        private async Task FantomeDeplacement(Character fantome, UneCellule cellule, int speed, CancellationToken cancellationToken)
        {
            Point point = new(cellule.getY() * 50 + 2, cellule.getX() * 50 + 2);

            if (fantome.Position.X < point.X)
            {
                while (fantome.Position != point)
                {
                    fantome.Position = new Point(fantome.Position.X + 2, fantome.Position.Y);
                    try
                    {
                        Colision_PacMan_Fantome(fantome);
                        await Task.Delay(speed, cancellationToken);
                    }
                    catch (TaskCanceledException)
                    {
                        Reset_Fantome();
                        return;
                    }
                }
            }
            else if (fantome.Position.X > point.X)
            {
                while (fantome.Position != point)
                {
                    fantome.Position = new Point(fantome.Position.X - 2, fantome.Position.Y);
                    try
                    {
                        Colision_PacMan_Fantome(fantome);
                        await Task.Delay(speed, cancellationToken);
                    }
                    catch (TaskCanceledException)
                    {
                        Reset_Fantome();
                        return;
                    }
                }
            }
            else if (fantome.Position.Y < point.Y)
            {
                while (fantome.Position != point)
                {
                    fantome.Position = new Point(fantome.Position.X, fantome.Position.Y + 2);
                    try
                    {
                        Colision_PacMan_Fantome(fantome);
                        await Task.Delay(speed, cancellationToken);
                    }
                    catch (TaskCanceledException)
                    {
                        Reset_Fantome();
                        return;
                    }
                }
            }
            else if (fantome.Position.Y > point.Y)
            {
                while (fantome.Position != point)
                {
                    fantome.Position = new Point(fantome.Position.X, fantome.Position.Y - 2);
                    try
                    {
                        Colision_PacMan_Fantome(fantome);
                        await Task.Delay(speed, cancellationToken);
                    }
                    catch (TaskCanceledException)
                    {
                        Reset_Fantome();
                        return;
                    }
                }
            }
        }

        /* ---------------- Affichage du labyrinthe ---------------- */

        private void AffichageLabyrinthe()
        {
            int index = 0;
            UneCellule currentCellule;

            for (int i = 0; i < partie.Hauteur; i++)
            {
                for (int j = 0; j < partie.Largeur; j++)
                {
                    CaseLabyrinthe caseLabyrinthe = new(tlpLabyrinthe);
                    currentCellule = labyrinthe.getCellules()[index];

                    if (currentCellule.getVoisins().Count == 4)
                    {
                        if (Utils.BinaireConvert(currentCellule, index, 1, labyrinthe, partie) == "1110")
                            caseLabyrinthe.Image = Properties.Resources.droite;

                        else if (Utils.BinaireConvert(currentCellule, index, 1, labyrinthe, partie) == "1101")
                            caseLabyrinthe.Image = Properties.Resources.gauche;

                        else if (Utils.BinaireConvert(currentCellule, index, 1, labyrinthe, partie) == "1011")
                            caseLabyrinthe.Image = Properties.Resources.bas;

                        else if (Utils.BinaireConvert(currentCellule, index, 1, labyrinthe, partie) == "0111")
                            caseLabyrinthe.Image = Properties.Resources.haut;

                        else if (Utils.BinaireConvert(currentCellule, index, 1, labyrinthe, partie) == "1100")
                            caseLabyrinthe.Image = Properties.Resources.gauche_droite;

                        else if (Utils.BinaireConvert(currentCellule, index, 1, labyrinthe, partie) == "1001")
                            caseLabyrinthe.Image = Properties.Resources.angle_bas_gauche;

                        else if (Utils.BinaireConvert(currentCellule, index, 1, labyrinthe, partie) == "0011")
                            caseLabyrinthe.Image = Properties.Resources.haut_bas;

                        else if (Utils.BinaireConvert(currentCellule, index, 1, labyrinthe, partie) == "0110")
                            caseLabyrinthe.Image = Properties.Resources.angle_haut_droite;

                        else if (Utils.BinaireConvert(currentCellule, index, 1, labyrinthe, partie) == "1010")
                            caseLabyrinthe.Image = Properties.Resources.angle_bas_droite;

                        else if (Utils.BinaireConvert(currentCellule, index, 1, labyrinthe, partie) == "0101")
                            caseLabyrinthe.Image = Properties.Resources.angle_haut_gauche;

                        else { }
                    }
                    else if (currentCellule.getVoisins().Count == 3)
                    {
                        if (i == 0)
                        {
                            if (Utils.BinaireConvert(currentCellule, index, 2, labyrinthe, partie) == "0111")
                                caseLabyrinthe.Image = Properties.Resources.haut;

                            else if (Utils.BinaireConvert(currentCellule, index, 2, labyrinthe, partie) == "0011")
                                caseLabyrinthe.Image = Properties.Resources.haut_bas;

                            else if (Utils.BinaireConvert(currentCellule, index, 2, labyrinthe, partie) == "0110")
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_droite;

                            else if (Utils.BinaireConvert(currentCellule, index, 2, labyrinthe, partie) == "0101")
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_gauche;

                            else { }
                        }
                        else if (i == partie.Hauteur - 1)
                        {
                            if (Utils.BinaireConvert(currentCellule, index, 3, labyrinthe, partie) == "1011")
                                caseLabyrinthe.Image = Properties.Resources.bas;

                            else if (Utils.BinaireConvert(currentCellule, index, 3, labyrinthe, partie) == "1001")
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_gauche;

                            else if (Utils.BinaireConvert(currentCellule, index, 3, labyrinthe, partie) == "0011")
                                caseLabyrinthe.Image = Properties.Resources.haut_bas;

                            else if (Utils.BinaireConvert(currentCellule, index, 3, labyrinthe, partie) == "1010")
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_droite;

                            else { }
                        }
                        else if (j == 0)
                        {
                            if (Utils.BinaireConvert(currentCellule, index, 4, labyrinthe, partie) == "1101")
                                caseLabyrinthe.Image = Properties.Resources.gauche;

                            else if (Utils.BinaireConvert(currentCellule, index, 4, labyrinthe, partie) == "1100")
                                caseLabyrinthe.Image = Properties.Resources.gauche_droite;

                            else if (Utils.BinaireConvert(currentCellule, index, 4, labyrinthe, partie) == "1001")
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_gauche;

                            else if (Utils.BinaireConvert(currentCellule, index, 4, labyrinthe, partie) == "0101")
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_gauche;

                            else { }
                        }
                        else
                        {
                            if (Utils.BinaireConvert(currentCellule, index, 5, labyrinthe, partie) == "1110")
                                caseLabyrinthe.Image = Properties.Resources.droite;

                            else if (Utils.BinaireConvert(currentCellule, index, 5, labyrinthe, partie) == "1100")
                                caseLabyrinthe.Image = Properties.Resources.gauche_droite;

                            else if (Utils.BinaireConvert(currentCellule, index, 5, labyrinthe, partie) == "0110")
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_droite;

                            else if (Utils.BinaireConvert(currentCellule, index, 5, labyrinthe, partie) == "1010")
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_droite;

                            else { }
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            if (j == 0)
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_gauche;
                            else
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_droite;
                        }
                        else
                        {
                            if (j == 0)
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_gauche;
                            else
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_droite;
                        }
                    }
                    index++;
                }
            }
        }

        /* ---------------- Fermeture du formulaire ---------------- */

        private void FormPartie_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isVictory == true || isDefeat == true)
            {
                FormFinPartie formFinPartie = new(formMenuPrincipal, partie, isVictory);
                formFinPartie.Show();
            }
            else
            {
                cancellationTokenSource.Cancel();
                formMenuPrincipal.Close();
            }
        }

        /* ---------------- Mise en pause du formulaire ---------------- */

        private async Task Pause(FormMenuPause formMenuPause)
        {
            while (formMenuPause.IsDisposed == false)
            {
                isRunning = false;
                timer.Stop();
                await Task.Delay(100);
            }
            SaveTouches();
        }

        /* ---------------- Sauvegarde des touches ---------------- */

        private void SaveTouches()
        {
            partie.ToucheHaut = Convert.ToChar(ConfigurationManager.AppSettings["ToucheHaut"]);
            partie.ToucheBas = Convert.ToChar(ConfigurationManager.AppSettings["ToucheBas"]);
            partie.ToucheDroite = Convert.ToChar(ConfigurationManager.AppSettings["ToucheDroite"]);
            partie.ToucheGauche = Convert.ToChar(ConfigurationManager.AppSettings["ToucheGauche"]);
        }

        /* ---------------- Flèches directionnelles + Touche échap ---------------- */

        private async void FormPartie_KeyDown(object sender, KeyEventArgs e)
        {
            Reset_Token();

            if (e.KeyCode == Keys.Escape)
            {
                FormMenuPause formMenuPause = new(formMenuPrincipal, this);
                formMenuPause.Show();
                this.Hide();
                Pause(formMenuPause);
            }
            else if (e.KeyCode == Keys.Up)
            {
                Deplacement(partie.ToucheHaut);
            }
            else if (e.KeyCode == Keys.Down)
            {
                Deplacement(partie.ToucheBas);
            }
            else if (e.KeyCode == Keys.Left)
            {
                Deplacement(partie.ToucheGauche);
            }
            else if (e.KeyCode == Keys.Right)
            {
                Deplacement(partie.ToucheDroite);
            }
        }

        /* ---------------- Changement de taille du formulaire ---------------- */

        private void FormPartie_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this);
        }
    }
}
