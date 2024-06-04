using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque_PacMan
{
    public enum PacManDirection
    {
        Up,
        Down,
        Left,
        Right
    }

    public class PacMan : Label
    {
        private PacManDirection _direction = PacManDirection.Right;
        private string _hexaColor = "";
        private UneCellule _currentCellule;
        private int _index;
        private System.Windows.Forms.Timer _animationtimer;
        private int _animationStep = 0;

        public PacMan(string hexaColor, UneCellule currentCellule)
        {
            this._hexaColor = hexaColor;
            this._currentCellule = currentCellule;

            _animationtimer = new System.Windows.Forms.Timer();
            _animationtimer.Interval = 200;
            _animationtimer.Tick += AnimationTick;
            _animationtimer.Start();
        }

        private void Init_Label()
        {
            this.BackColor = Color.Transparent;
            this.ForeColor = ColorTranslator.FromHtml(_hexaColor);
            this.Margin = new Padding(0);
            this.Size = new Size(50, 50);
            this.Location = new Point(_currentCellule.getY() * 50 + 2, _currentCellule.getX() * 50 + 2);
        }

        public PacManDirection Direction
        {
            get
            {
                return _direction;
            }
            set
            {
                _direction = value;
                this.Invalidate();
            }
        }

        public UneCellule CurrentCellule
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

        public Point Position
        {
            get
            {
                return Location;
            }
            set
            {
                Location = value;
            }
        }

        public int Index
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

        private void AnimationTick(object sender, EventArgs e)
        {
            _animationStep = (_animationStep + 1) % 4;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.Clear(this.BackColor);

            float startAngle = GetStartAngle();
            float sweepAngle = GetSweepAngle();
            float padding = 0;

            RectangleF pacmanRect = new RectangleF(
                padding,
                padding,
                this.Width - 2 * padding,
                this.Height - 2 * padding
            );

            using (Brush brush = new SolidBrush(this.ForeColor))
            {
                e.Graphics.FillPie(brush, pacmanRect, startAngle, sweepAngle);
            }
        }

        private float GetStartAngle()
        {
            switch (_direction)
            {
                case PacManDirection.Up:
                    return 300;
                case PacManDirection.Down:
                    return 120;
                case PacManDirection.Left:
                    return 210;
                case PacManDirection.Right:
                    return 30;
                default:
                    return 30;
            }
        }

        private float GetSweepAngle()
        {
            switch (_animationStep)
            {
                case 0:
                    return 300;
                case 1:
                    return 320;
                case 2:
                    return 340;
                case 3:
                    return 320;
                default:
                    return 300;
            }
        }
    }
}
