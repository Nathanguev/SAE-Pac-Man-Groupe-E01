using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque_PacMan
{
    public class Objet
    {
        // Déclaration des champs privés de la classe

        private PictureBox _sprite; // Représente l'image de l'objet
        private Point _position; // Représente la position de l'objet

        /* ----------------- Constructeur de la classe Objet ----------------- */

        // Initialise un nouvel objet avec une image et une position spécifiées
        public Objet(Image image, Point position)
        {
            _position = position; // Initialisation de la position
            Init_Sprite();
            _sprite.Image = image; // Affectation de l'image au sprite
        }

        /* ----------------- Fonction d'initialisation ----------------- */

        // Méthode pour initialiser le sprite (PictureBox)
        public void Init_Sprite()
        {
            _sprite = new PictureBox(); // Création d'une nouvelle instance de PictureBox
            _sprite.Size = new Size(46, 46);
            _sprite.SizeMode = PictureBoxSizeMode.Zoom;
            _sprite.Location = _position; // Définition de la position du sprite
            _sprite.BackColor = Color.Transparent;
        }

        /* ----------------- Fonctions getter et setter ----------------- */

        // Propriété publique pour accéder et modifier le sprite
        public PictureBox sprite
        {
            get { return _sprite; }
            set { _sprite = value; }
        }

        // Propriété publique pour accéder et modifier la position
        public Point position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
