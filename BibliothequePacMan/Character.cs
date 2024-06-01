using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque_PacMan
{
    public class Character
    {
        private PictureBox _sprite;
        private UneCellule _currentCellule;
        private int _index;

        public Character(PictureBox sprite, UneCellule currentCellule)
        {
            _sprite = sprite;
            _currentCellule = currentCellule;
        }

        public Character(Image image, UneCellule currentCellule)
        {
            _currentCellule = currentCellule;
            Init_Sprite();
            _sprite.Image = image;
        }

        public Character()
        {
            Init_Sprite();
            Init_Position();
        }

        private void Init_Sprite()
        {
            _sprite = new PictureBox();
            _sprite.Size = new Size(46, 46);
            _sprite.SizeMode = PictureBoxSizeMode.Zoom;
            _sprite.Location = new Point(currentCellule.getY() * 50 + 2, currentCellule.getX() * 50 + 2);
            _sprite.BackColor = Color.Transparent;
        }

        private void Init_Position()
        {
            _currentCellule = new UneCellule(1,1);
        }

        public UneCellule currentCellule
        {
            get
            {
                return _currentCellule;
            }
            set
            {
                _currentCellule = value;
            }
        }

        public Point position
        {
            get
            {
                return _sprite.Location;
            }
            set
            {
                _sprite.Location = value;
            }
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

        public int index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value;
            }
        }
    }
}
