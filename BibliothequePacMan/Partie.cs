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

        private int _hauteur;
        private int _largeur;

        public Partie()
        {
            _volumeEffets = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeEffets"]);
            _volumeGlobal = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeGlobal"]);
            _volumeMusique = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeMusique"]);
            
            _toucheHaut = Convert.ToChar(ConfigurationManager.AppSettings["ToucheHaut"]);
            _toucheBas = Convert.ToChar(ConfigurationManager.AppSettings["ToucheBas"]);
            _toucheDroite = Convert.ToChar(ConfigurationManager.AppSettings["ToucheDroite"]);
            _toucheGauche = Convert.ToChar(ConfigurationManager.AppSettings["ToucheGauche"]);

            _bonusVitesse = true;
            _bonusScore = true;
            _bonusVie = true;
            _bonusTrainee = true;
            _bonusFantome = true;

            _pseudo = "Idaho";
            _difficulte = 1;
            _couleur = "#000000";

            _nbVie = 3;
            _level = 1;
            _seed = 0;

            _hauteur = 15;
            _largeur = 30;
        }

        public int volumeEffets
        {
            get
            {
                return _volumeEffets;
            }
            set
            {
                _volumeEffets = value;
            }
        }

        public int volumeGlobal
        {
            get
            {
                return _volumeGlobal;
            }
            set
            {
                _volumeGlobal = value;
            }
        }

        public int volumeMusique
        {
            get
            {
                return _volumeMusique;
            }
            set
            {
                _volumeMusique = value;
            }
        }

        public char toucheHaut
        {
            get
            {
                return _toucheHaut;
            }
            set
            {
                _toucheHaut = value;
            }
        }

        public char toucheBas
        {
            get
            {
                return _toucheBas;
            }
            set
            {
                _toucheBas = value;
            }
        }

        public char toucheDroite
        {
            get
            {
                return _toucheDroite;
            }
            set
            {
                _toucheDroite = value;
            }
        }

        public char toucheGauche
        {
            get
            {
                return _toucheGauche;
            }
            set
            {
                _toucheGauche = value;
            }
        }

        public int seed
        {
            get
            {
                return _seed;
            }
        }

        public int largeur
        {
            get
            {
                return _largeur;
            }
        }

        public int hauteur
        {
            get
            {
                return _hauteur;
            }
        }
    }
}
