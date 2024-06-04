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
            Init_Label();

            _animationtimer = new System.Windows.Forms.Timer();
            _animationtimer.Interval = 50;
            _animationtimer.Tick += AnimationTick;
            _animationtimer.Start();
        }

        private void Init_Label()
        {
            this.BackColor = Color.Transparent;
            this.ForeColor = ColorTranslator.FromHtml(_hexaColor);
            this.Margin = new Padding(0);
            this.Size = new Size(46, 46);
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
            _animationStep = (_animationStep + 1) % 14;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.Clear(this.BackColor);

            float sweepAngle = GetSweepAngle();
            float startAngle = GetStartAngle(sweepAngle);
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

        private float GetStartAngle(float sweepAngle)
        {
            float midAngle;
            switch (_direction)
            {
                case PacManDirection.Up:
                    midAngle = 90;
                    break;
                case PacManDirection.Down:
                    midAngle = 270;
                    break;
                case PacManDirection.Left:
                    midAngle = 0;
                    break;
                case PacManDirection.Right:
                    midAngle = 180;
                    break;
                default:
                    midAngle = 180;
                    break;
            }
            return midAngle - (sweepAngle / 2);
        }

        private float GetSweepAngle()
        {
            switch (_animationStep)
            {
                case 0:
                    return 280;
                case 1:
                    return 290;
                case 2:
                    return 300;
                case 3:
                    return 310;
                case 4:
                    return 320;
                case 5:
                    return 330;
                case 6:
                    return 340;
                case 7:
                    return 350;
                case 8:
                    return 340;
                case 9:
                    return 330;
                case 10:
                    return 320;
                case 11:
                    return 310;
                case 12:
                    return 300;
                case 13:
                    return 290;
                case 14:
                    return 380;
                default:
                    return 280;
            }
        }
    }
}
