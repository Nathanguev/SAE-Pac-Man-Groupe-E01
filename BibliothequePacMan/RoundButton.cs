using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque_PacMan
{
    /* ----------------- Classe RoundButton hérité de Button ----------------- */

    public class RoundButton : Button
    {
        // Ajout de 5 attributs privés à la classe RoundButton

        private int _borderRadius = 10; // Détermine l'angle de l'arrondi du bouton
        private int _borderWidth = 0; // Détermine l'épaisseur de la bordure
        private Color _borderColor = Color.Transparent; // Détermine la couleur de la bordure
        private bool _rounded = true; // Permet de rendre le bouton complètement rond en fonction de la valeur de _borderRadius
        private string _hexaColor = ""; // Représente la couleur de fond du bouton en hexadécimal

        /* ----------------- Constructeur par défaut pour RoundButton ----------------- */
        public RoundButton()
        {
            // Initialisation des propriétés du bouton
            this.BackColor = Color.FromArgb(224, 224, 224);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Margin = new Padding(0);
            this.Dock = DockStyle.Fill;
            this.Font = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
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
                if (!_rounded)
                {
                    _borderRadius = value;
                    this.Invalidate(); // Redessine le bouton pour refléter les modifications
                }
                else
                {
                    // Si le bouton est arrondi, ajuster le rayon pour qu'il soit parfaitement rond
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
                this.Invalidate(); // Redessine le bouton pour refléter les modifications
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
                this.Invalidate(); // Redessine le bouton pour refléter les modifications
            }
        }

        /* ----------------- Propriété pour accéder et modifier _rounded ----------------- */
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
                    // Ajuster le rayon pour que le bouton soit parfaitement rond
                    if (this.Height < this.Width)
                    {
                        _borderRadius = this.Height / 2;
                    }
                    else
                    {
                        _borderRadius = this.Width / 2;
                    }
                }
                this.Invalidate(); // Redessine le bouton pour refléter les modifications
            }
        }

        /* ----------------- Propriété pour accéder et modifier _hexaColor ----------------- */
        public string HexaColor
        {
            get
            {
                return _hexaColor;
            }
            set
            {
                _hexaColor = value;
                if (_hexaColor != "")
                {
                    // Convertit le code hexadécimal en couleur
                    this.BackColor = ColorTranslator.FromHtml(_hexaColor);
                }
                this.Invalidate(); // Redessine le bouton pour refléter les modifications
            }
        }

        /* ----------------- Méthode appelée lors du dessin du bouton ----------------- */
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

            this.Region = new Region(path); // Définit la région du bouton

            // Dessine la bordure si nécessaire
            if (_borderRadius > 0)
            {
                using (Pen borderPen = new Pen(_borderColor, _borderWidth))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        /* ----------------- Méthode appelée lors du changement de taille du bouton ----------------- */
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (Rounded)
            {
                // Ajuster le rayon pour que le bouton soit parfaitement rond
                if (this.Height < this.Width)
                {
                    BorderRadius = this.Height / 2;
                }
                else
                {
                    BorderRadius = this.Width / 2;
                }
            }
            this.Invalidate(); // Redessine le bouton pour refléter les modifications
        }
    }
}
