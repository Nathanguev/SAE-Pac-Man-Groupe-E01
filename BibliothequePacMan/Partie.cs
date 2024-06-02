using System.Configuration;

namespace BibliothequePacMan
{
    public class Partie
    {
        private int _volumeEffets;
        private int _volumeGlobal;
        private int _volumeMusique;

        private char _toucheHaut;
        private char _toucheBas;
        private char _toucheDroite;
        private char _toucheGauche;

        private bool _bonusVitesse;
        private bool _bonusScore;
        private bool _bonusVie;
        private bool _bonusTrainee;
        private bool _bonusFantome;

        private string _pseudo;
        private int _difficulte;
        private string _couleur;

        private int _nbVie;
        private int _level;
        private int _seed;
        private int _score;

        private int _hauteur;
        private int _largeur;

        public Partie()
        {
            _bonusVitesse = true;
            _bonusScore = true;
            _bonusVie = true;
            _bonusTrainee = true;
            _bonusFantome = true;

            _pseudo = "Idaho";
            _difficulte = 1;
            _couleur = "#000000";

            _level = 0;
            _seed = 0;
            _score = 0;

            Init_Volumes();
            Init_Touches();
            Init_NbVie();
            Init_Dimensions();
        }

        public Partie(string pseudo, int difficulte, string couleur, bool bonusVitesse, bool bonusScore, bool bonusVie, bool bonusTrainee, bool bonusFantome)
        {
            _pseudo = pseudo;
            _difficulte = difficulte;
            _couleur = couleur;

            _bonusVitesse = bonusVitesse;
            _bonusScore = bonusScore;
            _bonusVie = bonusVie;
            _bonusTrainee = bonusTrainee;
            _bonusFantome = bonusFantome;

            _level = 0;
            _score = 0;

            Init_Volumes();
            Init_Touches();
            Init_NbVie();
            Init_Dimensions();
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

        private void Init_Dimensions()
        {
            _hauteur = 8;
            _largeur = 14;
        }

        public void Update_Dimensions()
        {
            _hauteur += 1 * _level;
            _largeur += 2 * _level;
        }

        public int volumeEffets
        {
            get { return _volumeEffets; }
            set { _volumeEffets = value; }
        }

        public int volumeGlobal
        {
            get { return _volumeGlobal; }
            set { _volumeGlobal = value; }
        }

        public int volumeMusique
        {
            get { return _volumeMusique; }
            set { _volumeMusique = value; }
        }

        public char toucheHaut
        {
            get { return _toucheHaut; }
            set { _toucheHaut = value; }
        }

        public char toucheBas
        {
            get { return _toucheBas; }
            set { _toucheBas = value; }
        }

        public char toucheDroite
        {
            get { return _toucheDroite; }
            set { _toucheDroite = value; }
        }

        public char toucheGauche
        {
            get { return _toucheGauche; }
            set { _toucheGauche = value; }
        }

        public string pseudo
        {
            get { return _pseudo; }
        }

        public int difficulte
        {
            get { return _difficulte; }
        }

        public string couleur
        {
            get { return _couleur; }
        }

        public int nbVie
        {
            get { return _nbVie; }
            set { _nbVie = value; }
        }

        public int level
        {
            get { return _level; }
            set { _level = value; }
        }

        public int seed
        {
            get { return _seed; }
            set { _seed = value; }
        }

        public int score
        {
            get { return _score; }
            set { _score = value; }
        }


        public int largeur
        {
            get { return _largeur; }
        }

        public int hauteur
        {
            get { return _hauteur; }
        }
    }
}
