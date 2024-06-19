using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque_PacMan
{
    /* ----------------- Classe RoundTableLayoutPanel hérité de TableLayoutPanel ----------------- */

    public class RoundTableLayoutPanel : TableLayoutPanel
    {
        // Ajout de 3 attributs privés à la classe RoundTableLayoutPanel

        private int _borderRadius = 10; // Détermine l'angle de l'arrondi du TableLayoutPanel
        private int _borderWidth = 0; // Détermine l'épaisseur de la bordure
        private Color _borderColor = Color.Transparent; // Détermine la couleur de la bordure

        /* ----------------- Constructeur par défaut pour RoundTableLayoutPanel ----------------- */
        public RoundTableLayoutPanel()
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
            this.Margin = new Padding(0);
            this.Dock = DockStyle.Fill;
        }

        /* ----------------- Propriété pour accéder et modifier _borderRadius ----------------- */
        public int BorderRadius
        {
            get
            {
                return _borderRadius;
            }
            set
            {
                _borderRadius = value;
                this.Invalidate(); // Redessine le tableLayoutPanel pour refléter les modifications
            }
        }

        /* ----------------- Propriété pour accéder et modifier _borderWidth ----------------- */
        public int BorderWidth
        {
            get
            {
                return _borderWidth;
            }
            set
            {
                _borderWidth = value;
                this.Invalidate(); // Redessine le tableLayoutPanel pour refléter les modifications
            }
        }

        /* ----------------- Propriété pour accéder et modifier _borderColor ----------------- */
        public Color BorderColor
        {
            get
            {
                return _borderColor;
            }
            set
            {
                _borderColor = value;
                this.Invalidate(); // Redessine le tableLayoutPanel pour refléter les modifications
            }
        }

        /* ----------------- Méthode appelée lors du dessin du tableLayoutPanel ----------------- */
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();

            // Ajoute les arcs pour créer des coins arrondis
            path.AddArc(new Rectangle(0, 0, _borderRadius * 2, _borderRadius * 2), 180, 90);
            path.AddArc(new Rectangle(this.Width - _borderRadius * 2, 0, _borderRadius * 2, _borderRadius * 2), 270, 90);
            path.AddArc(new Rectangle(this.Width - _borderRadius * 2, this.Height - _borderRadius * 2, _borderRadius * 2, _borderRadius * 2), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - _borderRadius * 2, _borderRadius * 2, _borderRadius * 2), 90, 90);
            path.CloseFigure();

            this.Region = new Region(path); // Définit la région du tableLayoutPanel

            // Dessine la bordure si nécessaire
            if (_borderRadius > 0)
            {
                using (Pen borderPen = new Pen(_borderColor, _borderWidth))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        /* ----------------- Méthode appelée lors du changement de taille du tableLayoutPanel ----------------- */
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.Height < this.Width)
            {
                BorderRadius = this.Height / 2;
            }
            else
            {
                BorderRadius = this.Width / 2;
            }
            this.Invalidate(); // Redessine le tableLayoutPanel pour refléter les modifications
        }
    }
}
