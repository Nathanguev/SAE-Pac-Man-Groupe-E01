using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque_PacMan
{
    public class Objet
    {
        private PictureBox _sprite;
        private Point _position;

        public Objet(Image image, Point position)
        {
            _position = position;
            Init_Sprite();
            _sprite.Image = image;
        }

        public void Init_Sprite()
        {
            _sprite = new PictureBox();
            _sprite.Size = new Size(46, 46);
            _sprite.SizeMode = PictureBoxSizeMode.Zoom;
            _sprite.Location = _position;
            _sprite.BackColor = Color.Transparent;
        }

        public PictureBox sprite
        {
            get
            {
                return _sprite;
            }
            set
            {
                _sprite = value;
            }
        }

        public Point position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }
    }
}
