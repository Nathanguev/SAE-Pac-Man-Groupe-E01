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
using Bibliotheque_PacMan;

namespace Interface_PacMan
{
    public partial class FormMenuPause : Form
    {
        private FormMenuPrincipal formMenuPrincipal; // Référence vers le formulaire principal
        private FormPartie formPartie; // Référence vers le formulaire de la partie en cours
        private bool isBtnQuitterClicked = false; // Indique si le bouton "Quitter" a été cliqué
        private bool isBtnContinuerClicked = false; // Indique si le bouton "Continuer" a été cliqué

        /* ----------------- Constructeur de la classe FormMenuPause ----------------- */

        public FormMenuPause(FormMenuPrincipal formMenuPrincipal, FormPartie formPartie)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.formPartie = formPartie;
        }

        /* ----------------- Gestionnaire d'événement WinForms ----------------- */

        // Fermeture du formulaire
        private void FormMenuPause_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si l'utilisateur a choisi de continuer, affiche le formulaire de la partie en cours
            if (isBtnContinuerClicked)
                formPartie.Show();
            // Si l'utilisateur a choisi de quitter, affiche le formulaire principal
            else if (isBtnQuitterClicked)
                formMenuPrincipal.Show();
            // Sinon, ferme le formulaire principal
            else
                formMenuPrincipal.Close();
        }

        // Clic sur le bouton "Continuer"
        private void btnContinuer_Click(object sender, EventArgs e)
        {
            isBtnContinuerClicked = true; // Indique que le bouton "Continuer" a été cliqué
            this.Close(); // Ferme le formulaire actuel
        }

        // Clic sur le bouton "Quitter"
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            isBtnQuitterClicked = true; // Indique que le bouton "Quitter" a été cliqué
            this.Close(); // Ferme le formulaire actuel
        }

        // Clic sur le bouton "Options"
        private void btnOptions_Click(object sender, EventArgs e)
        {
            // Crée une nouvelle instance de FormMenuOptions
            FormMenuOptions formMenuOptions = new FormMenuOptions(formMenuPrincipal, this);
            formMenuOptions.Show(); // Affiche le formulaire des options
            this.Hide(); // Cache le formulaire actuel
        }

        // Survol de la souris sur un bouton
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Utils.btn_MouseEnter(sender, e);
        }

        // Sortie de souris d'un bouton
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Utils.btn_MouseLeave(sender, e);
        }

        // Redimensionnement du formulaire
        private void FormMenuPause_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this);
        }
    }
}
