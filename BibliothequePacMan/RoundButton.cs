using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque_PacMan
{
    public class RoundButton : Button
    {
        private int _borderRadius = 10;
        private int _borderWidth = 0;
        private Color _borderColor = Color.Transparent;
        private bool _rounded = true;

        public RoundButton()
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Margin = new Padding(0);
            this.Dock = DockStyle.Fill;
            this.Font = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get
            {
                return _borderRadius;
            }
            set
            {
                if (!_rounded)
                {
                    _borderRadius = value;
                    this.Invalidate();
                }
                else
                {
                    if (this.Height < this.Width)
                    {
                        _borderRadius = this.Height / 2;
                    }
                    else
                    {
                        _borderRadius = this.Width / 2;
                    }
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderWidth
        {
            get
            {
                return _borderWidth;
            }
            set
            {
                _borderWidth = value;
                this.Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Rounded
        {
            get
            {
                return _rounded;
            }
            set
            {
                _rounded = value;
                if (_rounded)
                {
                    if (this.Height < this.Width)
                    {
                        _borderRadius = this.Height / 2;
                    }
                    else
                    {
                        _borderRadius = this.Width / 2;
                    }
                }
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, _borderRadius * 2, _borderRadius * 2), 180, 90);
            path.AddArc(new Rectangle(this.Width - _borderRadius * 2, 0, _borderRadius * 2, _borderRadius * 2), 270, 90);
            path.AddArc(new Rectangle(this.Width - _borderRadius * 2, this.Height - _borderRadius * 2, _borderRadius * 2, _borderRadius * 2), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - _borderRadius * 2, _borderRadius * 2, _borderRadius * 2), 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);

            if (_borderRadius > 0)
            {
                using (Pen borderPen = new Pen(_borderColor, _borderWidth))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (Rounded)
            {
                if (this.Height < this.Width)
                {
                    BorderRadius = this.Height / 2;
                }
                else
                {
                    BorderRadius = this.Width / 2;
                }
            }
        }
    }
}
