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

        public Character(Image image, UneCellule currentCellule)
        {
            _currentCellule = currentCellule;
            Init_Sprite();
            _sprite.Image = image;
        }

        private void Init_Sprite()
        {
            _sprite = new PictureBox
            {
                Size = new Size(46, 46),
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(CurrentCellule.getY() * 50 + 2, CurrentCellule.getX() * 50 + 2),
                BackColor = Color.Transparent
            };
            _sprite.BringToFront();
        }

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
