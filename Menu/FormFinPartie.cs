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
using Bibliotheque_PacMan;

namespace Interface_PacMan
{
    public partial class FormFinPartie : Form
    {
        private FormMenuPrincipal formMenuPrincipal; // Référence vers le formulaire principal
        private Partie partie; // Référence vers l'objet Partie
        private bool isVictory; // Indique si la partie a été gagnée
        private bool isBtnQuitterClicked = false; // Indique si le bouton "Quitter" a été cliqué
        private bool isBtnSuivantClicked = false; // Indique si le bouton "Niveau Suivant" a été cliqué

        /* ----------------- Constructeur de la classe FormFinPartie ----------------- */

        public FormFinPartie(FormMenuPrincipal formMenuPrincipal, Partie partie, bool isVictory)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.partie = partie;
            this.isVictory = isVictory;
        }

        /* ----------------- Gestionnaire d'événement WinForms ----------------- */

        // Chargement du formulaire
        private void FormVictory_Load(object sender, EventArgs e)
        {
            lblScore.Text = "SCORE : " + partie.Score; // Affiche le score de la partie
            if (isVictory)
            {
                // Affiche une image de victoire si la partie est gagnée
                pictureBoxMessage.Image = Properties.Resources.victory;
            }
            else
            {
                // Affiche une image de défaite si la partie est perdue
                pictureBoxMessage.Image = Properties.Resources.game_over;
                btnNiveauSuivant.Visible = false; // Cache le bouton "Niveau Suivant" en cas de défaite
            }
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

        // Clic sur le bouton "Niveau Suivant"
        private void btnNiveauSuivant_Click(object sender, EventArgs e)
        {
            isBtnSuivantClicked = true; // Indique que le bouton "Niveau Suivant" a été cliqué
            this.Close(); // Ferme le formulaire actuel
        }

        // Clic sur le bouton "Quitter"
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            isBtnQuitterClicked = true; // Indique que le bouton "Quitter" a été cliqué
            this.Close(); // Ferme le formulaire actuel
        }

        // Fermeture du formulaire
        private void FormVictory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnQuitterClicked == true)
            {
                // Affiche le formulaire principal si l'utilisateur a choisi de quitter
                formMenuPrincipal.Show();
            }
            else if (isBtnSuivantClicked == true)
            {
                // Crée et affiche un nouveau formulaire de partie si l'utilisateur a choisi de passer au niveau suivant
                FormPartie formPartie = new FormPartie(formMenuPrincipal, partie);
                formPartie.Show();
            }
            else
            {
                // Ferme le formulaire principal si aucune action n'est spécifiée
                formMenuPrincipal.Close();
            }
        }

        // Redimensionnement du formulaire
        private void FormVictory_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this);
        }
    }
}
