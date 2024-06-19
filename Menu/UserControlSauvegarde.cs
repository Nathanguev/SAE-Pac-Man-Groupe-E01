using Bibliotheque_PacMan;
using BibliothequePacMan;
using Menu;
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
    public partial class UserControlSauvegarde : UserControl
    {
        private FormMenuPrincipal formMenuPrincipal; // Référence vers le formulaire principal
        private FormMenuContinuer formMenuContinuer; // Référence vers le formulaire de menu continuer

        /* ----------------- Constructeur de la classe UserControlSauvegarde ----------------- */

        public UserControlSauvegarde(FormMenuPrincipal formMenuPrincipal, FormMenuContinuer formMenuContinuer)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.formMenuContinuer = formMenuContinuer;
        }

        /* ----------------- Gestionnaire d'événement WinForms ----------------- */

        // Clic sur le contrôle
        private void UserControlSauvegarde_Click(object sender, EventArgs e)
        {
            Partie partie = new Partie(); // Crée une nouvelle partie
            FormPartie formPartie = new FormPartie(formMenuPrincipal, partie); // Crée un nouveau formulaire de partie
            formMenuContinuer.Hide(); // Cache le formulaire de menu continuer
            formPartie.Show(); // Affiche le formulaire de partie
        }

        // Survol de la souris sur le contrôle
        private void UserControlSauvegarde_MouseEnter(object sender, EventArgs e)
        {
            roundTableLayoutPanel1.BackColor = Color.LightBlue;
        }

        // Sortie de souris du contrôle
        private void UserControlSauvegarde_MouseLeave(object sender, EventArgs e)
        {
            roundTableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
        }

        // Redimensionnement du contrôle
        private void UserControlSauvegarde_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this, 10.0f);
        }

        /* ----------------- Fonctions getter et setter ----------------- */

        public string Pseudo
        {
            get { return lblUserPseudo.Text; }
            set { lblUserPseudo.Text = value; }
        }

        public string DateCreation
        {
            get { return lblDateCreation.Text; }
            set { lblDateCreation.Text = value; }
        }
    }
}
