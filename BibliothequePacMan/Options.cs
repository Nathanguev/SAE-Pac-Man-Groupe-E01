namespace BibliothequePacMan
{
    public class Options
    {
        private int _volumeEffets;
        private int _volumeGlobal;
        private int _volumeMusique;

        private char _toucheHaut;
        private char _toucheBas;
        private char _toucheDroite;
        private char _toucheGauche;

        public Options()
        {
            _volumeEffets = 80;
            _volumeGlobal = 80;
            _volumeMusique = 80;

            _toucheHaut = 'Z';
            _toucheBas = 'S';
            _toucheDroite = 'D';
            _toucheGauche = 'Q';
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
    }
}
