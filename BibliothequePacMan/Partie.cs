using System.Configuration;

namespace BibliothequePacMan
{
    public class Partie
    {
        /* ---------------- Variables globales ---------------- */

        private int _volumeEffets;
        private int _volumeGlobal;
        private int _volumeMusique;

        private char _toucheHaut;
        private char _toucheBas;
        private char _toucheDroite;
        private char _toucheGauche;

        private bool[] _bonus;

        private string _pseudo;
        private int _difficulte;
        private string _couleur;

        private int _nbVie;
        private int _level;
        private int _seed;
        private int _score;

        private int _hauteur;
        private int _largeur;
        private double _hauteurMax = 1080;
        private double _largeurMax = 1920;

        private Point _pacManPosition;

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
            // Init_Dimensions();
        }

        public Partie(string pseudo, int difficulte, string couleur, bool[] bonus)
        {
            _pseudo = pseudo;
            _difficulte = difficulte;
            _couleur = couleur;

            _bonus = bonus;

            _level = 0;
            _score = 0;

            Init_Volumes();
            Init_Touches();
            Init_NbVie();
            // Init_Dimensions();
        }

        private void Init_Volumes()
        {
            _volumeEffets = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeEffets"]);
            _volumeGlobal = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeGlobal"]);
            _volumeMusique = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeMusique"]);
        }

        private void Init_Touches()
        {
            _toucheHaut = Convert.ToChar(ConfigurationManager.AppSettings["ToucheHaut"]);
            _toucheBas = Convert.ToChar(ConfigurationManager.AppSettings["ToucheBas"]);
            _toucheDroite = Convert.ToChar(ConfigurationManager.AppSettings["ToucheDroite"]);
            _toucheGauche = Convert.ToChar(ConfigurationManager.AppSettings["ToucheGauche"]);
        }

        private void Init_NbVie()
        {
            switch (_difficulte)
            {
                case 1:
                    _nbVie = 5;
                    break;

                case 2:
                    _nbVie = 3;
                    break;

                case 3:
                    _nbVie = 1;
                    break;
            }
        }

        public void Init_Dimensions()
        {
            _hauteur = 8 + 1 * _level;
            _largeur = 14 + 2 * _level;

            if (_hauteurMax < _hauteur)
                _hauteur = (int)_hauteurMax - 1;

            if (_largeurMax < Largeur)
                _largeur = (int)_largeurMax - 1;
        }

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
