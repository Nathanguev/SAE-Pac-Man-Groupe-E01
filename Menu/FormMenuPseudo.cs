using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotheque_PacMan;

namespace Interface_PacMan
{
    public partial class FormMenuPseudo : Form
    {
        private FormMenuPrincipal formMenuPrincipal; // Référence vers le formulaire principal
        private bool isBtnRetourClicked = false; // Indique si le bouton "Retour" a été cliqué

        /* ----------------- Constructeur de la classe FormMenuPseudo ----------------- */

        // Constructeur prenant en paramètre la référence vers le formulaire principal
        public FormMenuPseudo(FormMenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
        }

        /* ----------------- Gestionnaire d'événement WinForms ----------------- */

        // Redimensionnement du formulaire
        private void FormMenuPseudo_SizeChanged(object sender, EventArgs e)
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

        // Clic sur le bouton "Retour"
        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true; // Indique que le bouton "Retour" a été cliqué
            this.Close(); // Ferme le formulaire actuel
        }

        // Clic sur le bouton "Suivant"
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            // Crée une instance de FormMenuParametre en passant les références vers le formulaire principal et celui-ci
            FormMenuParametre formMenuParametre = new FormMenuParametre(formMenuPrincipal, this);
            formMenuParametre.Show(); // Affiche le formulaire FormMenuParametre
            this.Hide(); // Cache le formulaire actuel
        }

        // Modification de texte dans la zone de texte du pseudo
        private void txtPseudo_TextChanged(object sender, EventArgs e)
        {
            // Active ou désactive le bouton "Suivant" en fonction de la longueur du texte dans la zone de texte
            btnSuivant.Enabled = (txtPseudo.Text.Length > 0);
        }

        // Fermeture du formulaire
        private void FormMenuPseudo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked == true)
                formMenuPrincipal.Show(); // Affiche le formulaire principal si le bouton "Retour" a été cliqué
            else
                formMenuPrincipal.Close(); // Ferme le formulaire principal si le bouton "Retour" n'a pas été cliqué
        }

        // Clic sur l'élément tlpPseudo (RoundTableLayoutPanel)
        private void tlpPseudo_Click(object sender, EventArgs e)
        {
            txtPseudo.Focus(); // Met le focus sur la zone de texte pour le pseudo
        }

        /* ----------------- Fonctions getter et setter ----------------- */

        // Retourne le texte de la zone de texte pour le pseudo
        public string pseudo
        {
            get { return txtPseudo.Text; }
        }
    }
}
