using Bibliotheque_PacMan;
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
    public partial class FormMenuContinuer : Form
    {
        private FormMenuPrincipal formMenuPrincipal; // Référence vers le formulaire principal
        private bool isBtnRetourClicked = false; // Indique si le bouton "Retour" a été cliqué

        /* ----------------- Constructeur de la classe FormMenuContinuer ----------------- */

        // Constructeur prenant en paramètre la référence vers le formulaire principal
        public FormMenuContinuer(FormMenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
        }

        /* ----------------- Gestionnaire d'événement WinForms ----------------- */

        // Chargement du formulaire
        private void FormMenuContinuer_Load(object sender, EventArgs e)
        {
            // Crée une instance de UserControlSauvegarde avec les références vers le formulaire principal et celui-ci
            UserControlSauvegarde sauvegarde = new UserControlSauvegarde(formMenuPrincipal, this);

            // Ajoute le UserControl au TableLayoutPanel à la position spécifiée et ajuste ses propriétés d'affichage
            tableLayoutPanel2.Controls.Add(sauvegarde, 3, 1);
            sauvegarde.Dock = DockStyle.Fill;
            sauvegarde.Margin = new Padding(0);

            // Initialise les données de pseudo et de date de création dans le UserControl
            sauvegarde.Pseudo = "Nathan";
            sauvegarde.DateCreation = "17/06/2024";
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
        private void FormMenuContinuer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked)
                formMenuPrincipal.Show(); // Affiche le formulaire principal si le bouton "Retour" a été cliqué
            else
                formMenuPrincipal.Close(); // Ferme le formulaire principal si le bouton "Retour" n'a pas été cliqué
        }

        // Clic sur le bouton "Retour"
        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true; // Indique que le bouton "Retour" a été cliqué
            this.Close(); // Ferme le formulaire actuel
        }
    }
}
