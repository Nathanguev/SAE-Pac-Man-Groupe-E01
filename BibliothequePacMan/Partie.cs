using System.Configuration;

namespace BibliothequePacMan
{
    public class Partie
    {
        /* ---------------- Variables globales ---------------- */

        private int _volumeEffets; // Volume des effets sonores
        private int _volumeGlobal; // Volume global du jeu
        private int _volumeMusique; // Volume de la musique

        private char _toucheHaut; // Touche pour déplacer vers le haut
        private char _toucheBas; // Touche pour déplacer vers le bas
        private char _toucheDroite; // Touche pour déplacer vers la droite
        private char _toucheGauche; // Touche pour déplacer vers la gauche

        private bool[] _bonus; // Tableau de booléens pour les bonus (Vie, Vitesse, Temps, Score)

        private string _pseudo; // Pseudo du joueur
        private int _difficulte; // Niveau de difficulté (1: facile, 2: moyen, 3: difficile)
        private string _couleur; // Couleur de PacMan

        private int _nbVie; // Nombre de vies du joueur
        private int _level; // Niveau actuel du jeu
        private int _seed; // Graine pour la génération aléatoire du niveau
        private int _score; // Score actuel du joueur

        private int _hauteur; // Hauteur du labyrinthe
        private int _largeur; // Largeur du labyrinthe
        private double _hauteurMax = 1080; // Hauteur maximale du labyrinthe
        private double _largeurMax = 1920; // Largeur maximale du labyrinthe

        private Point _pacManPosition;

        /* ----------------- Constructeur de la classe Partie ----------------- */

        // Constructeur par défaut (Déstiné par la suite pour la lecture en BD)
        // Informations de jeu d'une partie type avec une graine de génération aléatoire fixe
        public Partie()
        {
            _bonus = new[] { true, true, true, true }; // Vie, Vitesse, Temps, Score

            _pseudo = "Nathan";
            _difficulte = 2;
            _couleur = "#ffcb01";

            _level = 30;
            _seed = 7;
            _score = 0;

            Init_Volumes();
            Init_Touches();
            Init_NbVie();
        }

        // Constructeur avec paramètres
        public Partie(string pseudo, int difficulte, string couleur, bool[] bonus)
        {
            _pseudo = pseudo; // Initialisation du pseudo
            _difficulte = difficulte; // Initialisation de la difficulté
            _couleur = couleur; // Initialisation de la couleur

            _bonus = bonus; // Initialisation des bonus

            _level = 0; // Initialisation du niveau à 0
            _score = 0; // Initialisation du score

            Init_Volumes();
            Init_Touches();
            Init_NbVie();
        }

        /* ----------------- Méthodes d'initialisation ----------------- */

        // Méthode pour initialiser les volumes
        // Lecture des informations dans le fichier AppSetting
        private void Init_Volumes()
        {
            _volumeEffets = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeEffets"]);
            _volumeGlobal = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeGlobal"]);
            _volumeMusique = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeMusique"]);
        }

        // Méthode pour initialiser les touches
        // Lecture des informations dans le fichier AppSetting
        private void Init_Touches()
        {
            _toucheHaut = Convert.ToChar(ConfigurationManager.AppSettings["ToucheHaut"]);
            _toucheBas = Convert.ToChar(ConfigurationManager.AppSettings["ToucheBas"]);
            _toucheDroite = Convert.ToChar(ConfigurationManager.AppSettings["ToucheDroite"]);
            _toucheGauche = Convert.ToChar(ConfigurationManager.AppSettings["ToucheGauche"]);
        }

        // Méthode pour initialiser le nombre de vies en fonction de la difficulté
        private void Init_NbVie()
        {
            switch (_difficulte)
            {
                case 1:
                    _nbVie = 5; // 5 vies pour la difficulté facile
                    break;

                case 2:
                    _nbVie = 3; // 3 vies pour la difficulté moyenne
                    break;

                case 3:
                    _nbVie = 1; // 1 vie pour la difficulté difficile
                    break;
            }
        }

        // Méthode pour initialiser les dimensions du labyrinthe
        public void Init_Dimensions()
        {
            _hauteur = 8 + 1 * _level; // Calcul de la hauteur en fonction du niveau
            _largeur = 14 + 2 * _level; // Calcul de la largeur en fonction du niveau

            if (_hauteurMax < _hauteur)
                _hauteur = (int)_hauteurMax - 1; // Ajustement de la hauteur si elle dépasse la hauteur maximale

            if (_largeurMax < Largeur)
                _largeur = (int)_largeurMax - 1; // Ajustement de la largeur si elle dépasse la largeur maximale
        }

        /* ----------------- Fonctions getter et setter ----------------- */

        public int VolumeEffets
        {
            get { return _volumeEffets; }
            set { _volumeEffets = value; }
        }

        public int VvolumeGlobal
        {
            get { return _volumeGlobal; }
            set { _volumeGlobal = value; }
        }

        public int VolumeMusique
        {
            get { return _volumeMusique; }
            set { _volumeMusique = value; }
        }

        public char ToucheHaut
        {
            get { return _toucheHaut; }
            set { _toucheHaut = value; }
        }

        public char ToucheBas
        {
            get { return _toucheBas; }
            set { _toucheBas = value; }
        }

        public char ToucheDroite
        {
            get { return _toucheDroite; }
            set { _toucheDroite = value; }
        }

        public char ToucheGauche
        {
            get { return _toucheGauche; }
            set { _toucheGauche = value; }
        }

        public string Pseudo
        {
            get { return _pseudo; }
        }

        public int Difficulte
        {
            get { return _difficulte; }
        }

        public string Couleur
        {
            get { return _couleur; }
        }

        public int NbVie
        {
            get { return _nbVie; }
            set { _nbVie = value; }
        }

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public int Seed
        {
            get { return _seed; }
            set { _seed = value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public int Largeur
        {
            get { return _largeur; }
        }

        public int Hauteur
        {
            get { return _hauteur; }
        }

        public double HauteurMax
        {
            get { return _hauteurMax; }
            set { _hauteurMax = value; }
        }

        public double LargeurMax
        {
            get { return _largeurMax; }
            set { _largeurMax = value; }
        }

        public Point PacManPosition
        {
            get { return _pacManPosition; }
            set { _pacManPosition = value; }
        }

        public bool[] Bonus
        {
            get { return _bonus; }
        }
    }
}
