using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque_PacMan
{
    public class Character
    {
        // Déclaration des champs privés de la classe

        private PictureBox _sprite; // Représente l'image du personnage
        private UneCellule _currentCellule; // Représente la cellule actuelle où se trouve le personnage
        private int _index; // Représente l'index du personnage (sont numéro de cellule à l'intérieur du labyrinthe)

        /* ----------------- Constructeur de la classe Character ----------------- */

        // Initialise un nouvel character avec une image et une cellule spécifique
        public Character(Image image, UneCellule currentCellule)
        {
            _currentCellule = currentCellule; // Initialisation de la cellule actuelle
            Init_Sprite();
            _sprite.Image = image; // Affectation de l'image
        }

        /* ----------------- Fonction d'initialisation ----------------- */

        // Méthode pour initialiser le sprite (PictureBox)
        private void Init_Sprite()
        {
            _sprite = new PictureBox
            {
                Size = new Size(46, 46),
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(CurrentCellule.getY() * 50 + 2, CurrentCellule.getX() * 50 + 2),
                BackColor = Color.Transparent
            };
            _sprite.BringToFront(); // Amène le sprite au premier plan
        }

        /* ----------------- Fonctions getter et setter ----------------- */

        public UneCellule CurrentCellule
        {
            get { return _currentCellule; }
            set { _currentCellule = value; }
        }

        public Point Position
        {
            get { return _sprite.Location; }
            set { _sprite.Location = value; }
        }

        public PictureBox Sprite
        {
            get { return _sprite; }
            set { _sprite = value; }
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }
    }
}
