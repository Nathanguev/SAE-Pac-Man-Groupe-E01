using Bibliotheque_PacMan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_PacMan
{
    public partial class FormMenuCouleur : Form
    {
        private FormMenuParametre formMenuParametre; // Référence vers le formulaire FormMenuParametre
        private Button btnSelected; // Bouton sélectionné pour la couleur
        private bool isBtnRetourClicked = false; // Indique si le bouton "Retour" a été cliqué

        /* ----------------- Constructeur de la classe FormMenuCouleur ----------------- */

        // Constructeur prenant en paramètre la référence vers le formulaire FormMenuParametre
        public FormMenuCouleur(FormMenuParametre formMenuParametre)
        {
            InitializeComponent();
            this.formMenuParametre = formMenuParametre;
        }

        /* ----------------- Gestionnaire d'événement WinForms ----------------- */

        // Chargement du formulaire
        private void FormMenuCouleur_Load(object sender, EventArgs e)
        {
            // Sélectionne visuellement le bouton correspondant à la couleur actuelle
            btn_Select();
        }

        // Clic sur le bouton "Retour"
        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true; // Indique que le bouton "Retour" a été cliqué
            this.Close(); // Ferme le formulaire actuel
        }

        // Survole de souris sur un bouton
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Utils.btn_MouseEnter(sender, e);
        }

        // Sortie de souris d'un bouton
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Utils.btn_MouseLeave(sender, e);
        }

        // Fermeture du formulaire
        private void FormMenuCouleur_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked)
                formMenuParametre.Show(); // Affiche le formulaire FormMenuParametre si le bouton "Retour" a été cliqué
            else
                formMenuParametre.Close(); // Ferme le formulaire FormMenuParametre si le bouton "Retour" n'a pas été cliqué
        }

        // Clic sur un des boutons de couleur prédéfinie
        private void btnCouleur_Click(object sender, EventArgs e)
        {
            RoundButton btn = (RoundButton)sender;
            formMenuParametre.couleur = btn.HexaColor; // Définit la couleur sélectionnée dans FormMenuParametre
            btn_Select(); // Sélectionne visuellement le bouton cliqué
        }

        // Redimensionnement du formulaire
        private void FormMenuCouleur_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this);
        }

        // Clic sur le bouton "Couleur personnalisée"
        private void btnPerso_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    btnPerso.BackColor = selectedColor;

                    // Convertit la couleur sélectionnée en code hexadécimal et l'enregistre dans le bouton personnalisé
                    btnPerso.HexaColor = $"#{btnPerso.BackColor.A:X2}{btnPerso.BackColor.R:X2}{btnPerso.BackColor.G:X2}{btnPerso.BackColor.B:X2}";

                    formMenuParametre.couleur = btnPerso.HexaColor; // Définit la couleur personnalisée dans FormMenuParametre
                    btn_Select(); // Sélectionne visuellement le bouton personnalisé
                }
            }
        }

        /* ----------------- Fonction supplémentaire ----------------- */

        // Méthode pour sélectionner visuellement le bouton de couleur actuelle
        private void btn_Select()
        {
            RoundButton[] buttons = { btnJaune, btnViolet, btnRouge, btnBeige, btnVert, btnPerso };
            foreach (RoundButton btn in buttons)
            {
                if (formMenuParametre.couleur == btn.HexaColor)
                {
                    btnSelected = btn;
                    btn.BorderWidth = 15; // Largeur de bordure augmentée pour indiquer la sélection
                    btn.BorderColor = Color.DeepSkyBlue; // Couleur de bordure modifiée pour indiquer la sélection
                }
                else
                {
                    btn.BorderWidth = 0; // Aucune bordure pour les autres boutons
                    btn.BorderColor = Color.Transparent; // Bordure transparente pour les autres boutons
                }
            }
        }
    }
}
