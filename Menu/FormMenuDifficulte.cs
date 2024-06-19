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
    public partial class FormMenuDifficulte : Form
    {
        private FormMenuParametre formMenuParametre; // Référence vers le formulaire FormMenuParametre
        private RoundButton btnSelected; // Bouton sélectionné pour la difficulté
        private bool isBtnRetourClicked = false; // Indique si le bouton "Retour" a été cliqué

        /* ----------------- Constructeur de la classe FormMenuDifficulte ----------------- */

        // Constructeur prenant en paramètre la référence vers le formulaire FormMenuParametre
        public FormMenuDifficulte(FormMenuParametre formMenuParametre)
        {
            InitializeComponent();
            this.formMenuParametre = formMenuParametre;
            btnSelected = new RoundButton(); // Initialise un nouveau bouton pour la sélection
        }

        /* ----------------- Gestionnaire d'événement WinForms ----------------- */

        // Clic sur le bouton "Retour"
        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true; // Indique que le bouton "Retour" a été cliqué
            this.Close(); // Ferme le formulaire actuel
        }

        // Fermeture du formulaire
        private void FormMenuDifficulte_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked == true)
                formMenuParametre.Show(); // Affiche le formulaire FormMenuParametre si le bouton "Retour" a été cliqué
            else
                formMenuParametre.Close(); // Ferme le formulaire FormMenuParametre si le bouton "Retour" n'a pas été cliqué
        }

        // Redimensionnement du formulaire
        private void FormMenuDifficulte_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this);
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

        // Clic sur un des boutons de difficulté
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Définit la difficulté sélectionnée dans FormMenuParametre
            formMenuParametre.difficulte = Convert.ToInt32(btn.Tag);
            btn_Select(); // Sélectionne visuellement le bouton cliqué
        }

        // Chargement du formulaire
        private void FormMenuDifficulte_Load(object sender, EventArgs e)
        {
            // Sélectionne le bouton de difficulté correspondant à la difficulté actuelle
            btn_Select();
        }

        /* ----------------- Fonction supplémentaire ----------------- */

        // Méthode pour sélectionner visuellement le bouton de difficulté
        private void btn_Select()
        {
            RoundButton[] buttons = { btnFacile, btnMoyen, btnDifficile };
            foreach (RoundButton btn in buttons)
            {
                if (formMenuParametre.difficulte == Convert.ToInt32(btn.Tag))
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
