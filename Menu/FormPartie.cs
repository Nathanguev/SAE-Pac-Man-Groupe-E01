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
        private int tempsBonus = 10;

        private bool isMoving = false;
        private bool isRunning = false;
        private bool isVictory = false;
        private bool isDefeat = false;
        private bool bonusVitesseActif = false;

        private char lastTouche = '\0';
        private Queue<char> toucheQueue = new Queue<char>();

        private CancellationTokenSource cancellationTokenSource;

        /* ---------------- Constructeur de la fenêtre de jeu ---------------- */

        // Initialise la fenêtre de jeu avec les données de la partie en cours et un jeton d'annulation pour les opérations asynchrones.
        public FormPartie(FormMenuPrincipal formMenuPrincipal, Partie partie)
        {
            InitializeComponent();
            this.partie = partie;
            this.formMenuPrincipal = formMenuPrincipal;
            cancellationTokenSource = new CancellationTokenSource();
        }

        /* ---------------- Chargement du formulaire ---------------- */

        // Cette méthode est appelée lors du chargement du formulaire de jeu.
        private void FormPartie_Load(object sender, EventArgs e)
        {
            // Initialisation des dimensions maximales du labyrinthe et du jeu
            Init_DimensionsMax();
            partie.Init_Dimensions();

            // Création du labyrinthe et génération du parcours par l'algorithme de parcours en profondeur
            labyrinthe = new Labyrinthe(partie.Hauteur, partie.Largeur);
            labyrinthe.algoParcoursProfondeur();

            // Initialisation du TableLayoutPanel central pour l'affichage du labyrinthe
            Init_CenterTableLayoutPanel();
            tlpLabyrinthe = new TableLayoutPanel();
            Init_TableLayoutPanel(tlpLabyrinthe);
            panelLabyrinthe.Controls.Add(tlpLabyrinthe);

            // Initialisation de l'affichage des vies, du timer et des touches
            Init_Vies();
            Init_Timer();
            AffichageTouches();

            // Affichage du pseudo du joueur
            lblPseudoChange.Text = partie.Pseudo;

            // Configuration du panneau de défilement automatique pour le TableLayoutPanel du labyrinthe
            Size autoScrollSize = new(panelLabyrinthe.Width, panelLabyrinthe.Height);
            tlpGrille.AutoScrollMinSize = autoScrollSize;

            // Affichage du labyrinthe, initialisation de Pac-Man, des bonus et des pièces
            AffichageLabyrinthe();
            Init_PacMan(panelLabyrinthe);
            Init_Bonus(panelLabyrinthe);
            Init_Pieces(panelLabyrinthe);
            pacMan.BringToFront();

            // Initialisation et affichage des fantômes PCC et aléatoire
            Init_FantomePCC(panelLabyrinthe);
            Init_FantomeAleatoire(panelLabyrinthe);
        }

        /* ---------------- Fonctions d'initialisation ---------------- */

        // Initialise les dimensions maximales du labyrinthe en fonction de la taille du formulaire.
        private void Init_DimensionsMax()
        {
            partie.HauteurMax = (this.Height * 0.80) / 50;
            partie.LargeurMax = (this.Width - 20) / 50;
        }

        // Crée et place les pièces dans le labyrinthe, en excluant la position de départ de Pac-Man et les bonus.
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

        // Place Pac-Man dans le labyrinthe à sa position de départ.
        private void Init_PacMan(Panel panel)
        {
            int index = partie.Largeur + 1;
            pacMan = new PacMan(partie.Couleur, labyrinthe.getCellules()[index]);

            panel.Controls.Add(pacMan);
            pacMan.Index = index;
            pacmanSpawnPosition = pacMan.Position;
            pacmanSpawnCellule = pacMan.CurrentCellule;
        }

        // Place le fantôme aléatoire dans le labyrinthe à sa position de départ.
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

        // Place le fantôme PCC (Plus Court Chemin) dans le labyrinthe à sa position de départ.
        private void Init_FantomePCC(Panel panel)
        {
            int index = (partie.Largeur * (partie.Hauteur / 2) + (partie.Largeur / 2) + 1);
            Image image = Properties.Resources.fantomeBleu;
            fantomePCC = new Character(image, labyrinthe.getCellules()[index]);

            panel.Controls.Add(fantomePCC.Sprite);
            fantomePCC.Index = index;
            fantomePCC.Sprite.BringToFront();
        }

        // Initialise le TableLayoutPanel pour afficher le labyrinthe en fonction des dimensions du jeu.
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

        // Configure le TableLayoutPanel central pour afficher correctement le labyrinthe.
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

        // Initialise l'affichage des vies restantes du joueur dans le jeu.
        private void Init_Vies()
        {
            for (int i = 1; i < partie.NbVie + 1; i++)
            {
                PictureBox pictureBox = new()
                {
                    Margin = new Padding(5),
                    Dock = DockStyle.Fill,
                    Image = Properties.Resources.coeur_rouge,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Name = "vie" + i
                };

                tlpVies.Controls.Add(pictureBox, i, 0);
            }
        }

        /* ---------------- Fonctions Timer ---------------- */

        // Initialisation du timer
        private void Init_Timer()
        {
            timeLeft = partie.Init_TimerStatValue();
            timer = new System.Windows.Forms.Timer
            {
                Interval = 1000, // Intervalle de 1 seconde
            };
            timer.Tick += Timer_Tick; // Événement déclenché à chaque tick du timer
            Update_TimerDisplay(); // Initialisation de l'affichage du timer
        }

        // Tick du timer (toutes les secondes)
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--; // Décrémentation du temps restant
                Update_TimerDisplay(); // Mise à jour de l'affichage du timer
            }
            else
            {
                timer.Stop(); // Arrêt du timer
                lblTimerChange.Text = "00:00"; // Affichage de "00:00" lorsque le temps est écoulé
                partie.NbVie = 0; // Mise à jour du nombre de vies
                IsGameDefeat(); // Appel de la fonction de défaite
            }
        }

        // Affichage du timer au format Minutes : Secondes
        private void Update_TimerDisplay()
        {
            int minutes = timeLeft / 60; // Calcul des minutes restantes
            int seconds = timeLeft % 60; // Calcul des secondes restantes
            lblTimerChange.Text = $"{minutes:D2}:{seconds:D2}"; // Mise à jour de l'affichage du timer

            if (timeLeft <= 20)
            {
                // Changement de la couleur du texte en rouge si le temps restant est inférieur ou égal à 20 secondes
                lblTimer.ForeColor = Color.Red;
                lblTimerChange.ForeColor = Color.Red;
            }
        }

        /* ---------------- Fonctions Bonus ---------------- */

        // Place les bonus de manière aléatoire dans le labyrinthe, en évitant la position de départ de Pac-Man.
        private void Init_Bonus(Panel panel)
        {
            Random random = new Random();
            positionsBonus = new List<Point>();

            if (!partie.Bonus.All(bonus => !bonus))
            {
                while (positionsBonus.Count < 3 + partie.Level)
                {
                    Point point;

                    do
                    {
                        point = new Point(random.Next(partie.Largeur) * 50 + 2, random.Next(partie.Hauteur) * 50 + 2);
                    } while (positionsBonus.Contains(point) || point == pacmanSpawnPosition);

                    Objet bonus = Select_Bonus(random, point);

                    positionsBonus.Add(bonus.position);
                    panel.Controls.Add(bonus.sprite);
                    bonus.sprite.BringToFront();
                }
            }
        }

        // Sélectionne un bonus aléatoire en fonction d'un générateur de nombres aléatoires et d'une position donnée.
        private Objet Select_Bonus(Random random, Point point)
        {
            Objet bonus;
            int numero;

            do
            {
                numero = random.Next(3);
            } while (!partie.Bonus[numero]);

            switch (numero)
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

        // Activation du Bonus de Vitesse pendant 10 secondes
        private async void Bonus_Vitesse()
        {
            tempsBonus = 10;
            pacManSpeed = 1;

            if (!bonusVitesseActif)
            {
                Bonus_Actif(true);
                while (tempsBonus > 0)
                {
                    lblTempsBonus.Text = tempsBonus.ToString();
                    await Task.Delay(1000);
                    tempsBonus--;
                }
                lblTempsBonus.Text = "";
                Bonus_Actif(false);
                pacManSpeed = 8;
            }
        }

        private void Bonus_Actif(bool etat)
        {
            bonusVitesseActif = etat;
            picBonus.Visible = etat;
        }

        /* ---------------- Fonctions de réinitialisation ---------------- */

        // Réinitialisation de PacMan
        private void Reset_PacMan()
        {
            pacMan.Position = pacmanSpawnPosition; // Réinitialisation de la position de PacMan
            pacMan.CurrentCellule = pacmanSpawnCellule; // Réinitialisation de la cellule actuelle de PacMan
            pacMan.Index = pacmanSpawnCellule.getY() * partie.Largeur + pacmanSpawnCellule.getX(); // Mise à jour de l'index de PacMan
            isMoving = false;
        }

        // Réinitialisation des fantômes
        private void Reset_Fantome()
        {
            isRunning = false;

            fantomeAleatoire.Position = fantomeSpawnPosition; // Réinitialisation de la position du fantôme aléatoire
            fantomePCC.Position = new(fantomeSpawnPosition.X + 50, fantomeSpawnPosition.Y); // Réinitialisation de la position du fantôme PCC

            fantomeAleatoire.CurrentCellule = labyrinthe.getCellules()[fantomeAleatoire.Index]; // Réinitialisation de la cellule actuelle du fantôme aléatoire
            fantomePCC.CurrentCellule = labyrinthe.getCellules()[fantomePCC.Index]; // Réinitialisation de la cellule actuelle du fantôme PCC
        }

        // Réinitialisation de toutes les fonctions asynchrones
        private void Reset_Token()
        {
            if (cancellationTokenSource.IsCancellationRequested)
                cancellationTokenSource = new CancellationTokenSource(); // Réinitialisation du token d'annulation si une annulation a été demandée
        }

        /* ---------------- Fermeture du jeu ---------------- */

        // Cette fonction s'occupe de réinitialiser l'ensemble des éléments de la partie au moment de la fermeture du jeu
        private void GameClose()
        {
            cancellationTokenSource.Cancel(); // Annulation des tâches en cours
            Reset_PacMan();
            Reset_Fantome();
            tlpLabyrinthe.Controls.Clear(); // Nettoyage des contrôles dans le TableLayoutPanel du labyrinthe
            panelLabyrinthe.Controls.Clear(); // Nettoyage des contrôles dans le panel du labyrinthe
            this.Close(); // Fermeture de la fenêtre de jeu
        }

        /* ---------------- Condition de victoire et défaite ---------------- */

        // Ces fonctions vérifient respectivement si la partie est gagnée ou perdue
        private void IsGameVictory()
        {
            if (positionsPieces.Count == 0)
            {
                timer.Stop(); // Arrêt du timer
                isRunning = false;
                isVictory = true;
                partie.Score = Convert.ToInt32(lblScoreCount.Text); // Mise à jour du score
                partie.Level += 1; // Mise à jour du niveau de la partie
                partie.Init_Dimensions(); // Réinitialisation des dimensions du labyrinthe
                GameClose(); // Fermeture du jeu
            }
        }

        private void IsGameDefeat()
        {
            timer.Stop(); // Arrêt du timer
            if (partie.NbVie == 0)
            {
                isRunning = false;
                isDefeat = true;
                partie.Score = Convert.ToInt32(lblScoreCount.Text); // Mise à jour du score
                GameClose(); // Fermeture du jeu
            }
            else
            {
                isRunning = false;
                MessageBox.Show($"Vous perdez une vie, il vous en reste {partie.NbVie}.");
            }
        }

        /* ---------------- Récolte des pièces et/ou bonus ---------------- */

        // Cette fonction retire l'objet à la position donnée.
        // Si l'objet est une pièce : incrémentation du score de +1.
        // Si l'objet est un bonus : incrémentation du score de +10 et gestion spécifique du bonus.
        private void RemoveControlAtPosition(Point point)
        {
            foreach (Control control in panelLabyrinthe.Controls)
            {
                if (control.Location == point && control != pacMan && control != fantomeAleatoire.Sprite)
                {
                    if (positionsPieces.Contains(point))
                    {
                        positionsPieces.Remove(point); // Retire la pièce de la liste des positions de pièces
                        lblScoreCount.Text = Convert.ToString(Convert.ToInt32(lblScoreCount.Text) + 1); // Incrémente le score de +1
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
                                        Image = Properties.Resources.coeur_rouge,
                                        SizeMode = PictureBoxSizeMode.Zoom,
                                        Name = "vie" + tlpVies.Controls.Count
                                    };

                                    // Ajoute une vie supplémentaire à l'interface graphique
                                    tlpVies.Controls.Add(pictureBox, tlpVies.Controls.Count, 0);
                                    partie.NbVie++;
                                }
                                break;

                            case "bonusTemps":
                                timeLeft += 10; // Ajoute 10 secondes au temps restant
                                break;

                            case "bonusVitesse":
                                Bonus_Vitesse();
                                break;
                        }
                        positionsBonus.Remove(point); // Retire le bonus de la liste des positions de bonus
                        lblScoreCount.Text = Convert.ToString(Convert.ToInt32(lblScoreCount.Text) + 10); // Incrémente le score de +10
                    }
                    panelLabyrinthe.Controls.Remove(control); // Retire le contrôle du panel du labyrinthe
                    IsGameVictory(); // Vérifie si la condition de victoire est atteinte
                }
            }
        }

        /* ---------------- Déplacement de PacMan ---------------- */

        // Ces 4 fonctions asynchrones permettent le déplacement de PacMan à l'intérieur du labyrinthe.
        // PacMan se déplace de 2 pixels par 2 pixels dans la direction souhaitée avec un délai constant.
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

        /* ---------------- Fonctions de vérification du déplacement de PacMan ---------------- */

        // Ces 4 fonctions permettent de vérifier si le déplacement de PacMan est possible.
        // Le déplacement est possible si la cellule cible existe et est liée à la cellule actuelle.
        private bool MouvementPossibleHaut()
        {
            try
            {
                int index = pacMan.Index - partie.Largeur;
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
                return pacMan.CurrentCellule.isLien(labyrinthe.getCellules()[index]);
            }
            catch
            {
                return false;
            }
        }

        /* ---------------- Vérification des touches ---------------- */

        // Cette fonction gère les touches à l'aide d'une 'Queue'.
        // Elle permet le déplacement fluide de Pac-Man dans le labyrinthe.
        // Tant qu'aucune nouvelle touche n'est pressée et que
        // le mouvement en cours est possible, Pac-Man continue d'avancer.
        private async void Deplacement()
        {
            Reset_Token(); // Réinitialisation du jeton d'annulation

            while (!cancellationTokenSource.IsCancellationRequested)
            {
                char touche;
                if (toucheQueue.Count > 0)
                {
                    touche = toucheQueue.Dequeue(); // Récupération de la prochaine touche de la file d'attente
                    lastTouche = touche; // Mise à jour de la dernière touche utilisée
                }
                else
                {
                    touche = lastTouche; // Utilisation de la dernière touche si aucune nouvelle n'est disponible
                }

                bool moved = false;

                // Vérification et traitement du déplacement selon la touche pressée
                if (touche == partie.ToucheHaut && MouvementPossibleHaut())
                {
                    await Up(cancellationTokenSource.Token); // Déplacement vers le haut
                    moved = true;
                }
                else if (touche == partie.ToucheBas && MouvementPossibleBas())
                {
                    await Down(cancellationTokenSource.Token); // Déplacement vers le bas
                    moved = true;
                }
                else if (touche == partie.ToucheGauche && MouvementPossibleGauche())
                {
                    await Left(cancellationTokenSource.Token); // Déplacement vers la gauche
                    moved = true;
                }
                else if (touche == partie.ToucheDroite && MouvementPossibleDroite())
                {
                    await Right(cancellationTokenSource.Token); // Déplacement vers la droite
                    moved = true;
                }

                // Si aucun mouvement n'a été possible, sortir de la boucle
                if (!moved)
                {
                    break;
                }

                await Task.Delay(pacManSpeed); // Délai avant le prochain déplacement
            }
        }

        /* ---------------- Touches alpha-numériques ---------------- */

        // Cette fonction s'exécute lorsqu'une touche alpha-numérique est pressée.
        private async void FormPartie_KeyPress(object sender, KeyPressEventArgs e)
        {
            char touche = char.ToUpper(e.KeyChar); // Convertit la touche en majuscule
            if (touche == partie.ToucheHaut || touche == partie.ToucheBas || touche == partie.ToucheGauche || touche == partie.ToucheDroite)
            {
                toucheQueue.Enqueue(touche); // Ajoute la touche à la file d'attente
                Deplacement(); // Démarre le déplacement de Pac-Man    
            }
        }

        /* ---------------- Vérifications après déplacement ---------------- */

        // Cette fonction est appelée après chaque déplacement de Pac-Man.
        // Elle vérifie si un objet est sur la même case que lui.
        // Elle relance également le Timer si le jeu est en pause.
        private void VerifApresDeplacement()
        {
            partie.PacManPosition = pacMan.Position; // Met à jour la position de Pac-Man

            LoopStart();
            timer.Start(); // Redémarre le Timer
            RemoveControlAtPosition(pacMan.Position); // Vérifie et retire tout objet sur la case de Pac-Man
        }

        /* ---------------- Collision PacMan Fantome ---------------- */

        // Ces fonctions sont utilisées pour vérifier s'il y a une collision entre Pac-Man et un fantôme.
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
                cancellationTokenSource.Cancel(); // Annule le jeton d'annulation
                isRunning = false; // Indique que le jeu n'est plus en cours
                Reset_PacMan(); // Réinitialise Pac-Man
                Reset_Fantome(); // Réinitialise les fantômes
                tlpVies.Controls.RemoveAt(partie.NbVie); // Retire une vie visuellement
                partie.NbVie--; // Réduit le nombre de vies
                IsGameDefeat(); // Vérifie si c'est une défaite
            }
        }

        /* ---------------- Mise en marche des fantômes ---------------- */

        // Cette fonction lance le déplacement des fantômes s'ils ne bougent pas déjà.
        private async void LoopStart()
        {
            if (!isRunning && !isVictory && !isDefeat)
            {
                isRunning = true; // Marque le jeu comme en cours
                FantomeAleatoireLoop(); // Lance la boucle de déplacement du fantôme aléatoire
                FantomePCCLoop(); // Lance la boucle de déplacement du fantôme PCC
            }
        }

        /* ---------------- Fonctions asynchrones (Actions des fantômes) ---------------- */

        // Ces fonctions représentent les actions des fantômes :
        // - Fantôme aléatoire
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

        // - Fantôme plus court chemin
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

        /* ---------------- Fonctions Plus Court Chemin ---------------- */

        // Ces fonctions permettent le calcul du plus court chemin entre une cellule de départ et Pac-Man.
        // Elles retournent la liste de cellules qui correspond à ce chemin.
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

        /* ---------------- Déplacement des fantômes ---------------- */

        // Cette fonction permet le déplacement d'un fantôme vers une cellule cible à l'écran.
        // Elle ajuste la position du fantôme progressivement jusqu'à atteindre la position cible
        // avec une vitesse spécifiée, tout en vérifiant les collisions avec Pac-Man.
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

        // Cette fonction permet d'afficher le labyrinthe à l'écran.
        private void AffichageLabyrinthe()
        {
            int index = 0;
            UneCellule currentCellule;

            for (int i = 0; i < partie.Hauteur; i++)
            {
                for (int j = 0; j < partie.Largeur; j++)
                {
                    PictureBox caseLabyrinthe = new();
                    AutoFill(caseLabyrinthe, tlpLabyrinthe);
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

        private static void AutoFill(PictureBox pictureBox, TableLayoutPanel tlp)
        {
            pictureBox.Margin = new Padding(0);
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            tlp.Controls.Add(pictureBox);
        }

        /* ---------------- Fermeture du formulaire ---------------- */

        // Fonction exécutée à la fermeture du formulaire.
        // Vérifie si la partie est terminée (victoire ou défaite) pour afficher l'écran de fin de partie,
        // sinon annule les tâches en cours et ferme le formulaire principal du jeu.
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

        // Fonction qui tourne en boucle tant que le formulaire de pause est actif.
        // Met le jeu en pause en arrêtant le timer et sauvegarde les touches en cours.
        private async Task Pause(FormMenuPause formMenuPause)
        {
            toucheQueue.Enqueue('\0');
            await Task.Delay(100);
            while (!formMenuPause.IsDisposed)
            {
                isRunning = false;
                timer.Stop();
                await Task.Delay(100);
            }
            SaveTouches();
            toucheQueue.Clear();
        }

        /* ---------------- Sauvegarde des touches ---------------- */

        // Fonction de sauvegarde des touches à l'intérieur des paramètres de l'application (AppSettings).
        private void SaveTouches()
        {
            partie.ToucheHaut = Convert.ToChar(ConfigurationManager.AppSettings["ToucheHaut"]);
            partie.ToucheBas = Convert.ToChar(ConfigurationManager.AppSettings["ToucheBas"]);
            partie.ToucheDroite = Convert.ToChar(ConfigurationManager.AppSettings["ToucheDroite"]);
            partie.ToucheGauche = Convert.ToChar(ConfigurationManager.AppSettings["ToucheGauche"]);
            AffichageTouches();
        }

        private void AffichageTouches()
        {
            lblToucheHaut.Text = ": " + partie.ToucheHaut;
            lblToucheBas.Text = ": " + partie.ToucheBas;
            lblToucheGauche.Text = ": " + partie.ToucheGauche;
            lblToucheDroite.Text = ": " + partie.ToucheDroite;

            lblHaut.TextAlign = ContentAlignment.MiddleRight;
            lblBas.TextAlign = ContentAlignment.MiddleRight;
            lblGauche.TextAlign = ContentAlignment.MiddleRight;
            lblDroite.TextAlign = ContentAlignment.MiddleRight;
            lblPause.TextAlign = ContentAlignment.MiddleRight;
        }

        /* ---------------- Flèches directionnelles + Touche échap ---------------- */

        // Fonction qui s'exécute lors de l'appui sur une des touches directionnelles ou la touche Échap.
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
                char touche = partie.ToucheHaut;
                toucheQueue.Enqueue(touche);
                Deplacement();
            }
            else if (e.KeyCode == Keys.Down)
            {
                char touche = partie.ToucheBas;
                toucheQueue.Enqueue(touche);
                Deplacement();
            }
            else if (e.KeyCode == Keys.Left)
            {
                char touche = partie.ToucheGauche;
                toucheQueue.Enqueue(touche);
                Deplacement();
            }
            else if (e.KeyCode == Keys.Right)
            {
                char touche = partie.ToucheDroite;
                toucheQueue.Enqueue(touche);
                Deplacement();
            }
        }

        /* ---------------- Changement de taille du formulaire ---------------- */

        // Fonction qui s'exécute lors du changement de taille du formulaire et qui appelle une autre fonction de la classe
        // Utils pour ajuster automatiquement la taille du texte en fonction de la nouvelle taille du formulaire.
        private void FormPartie_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this);
        }
    }
}
