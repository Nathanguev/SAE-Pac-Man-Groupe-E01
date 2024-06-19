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
    public partial class FormMenuParametre : Form
    {
        private FormMenuPrincipal formMenuPrincipal; // Référence vers le formulaire principal
        private FormMenuPseudo formMenuPseudo; // Référence vers le formulaire FormMenuPseudo
        private bool isBtnRetourClicked = false; // Indique si le bouton "Retour" a été cliqué

        private string _pseudo; // Variable pour stocker le pseudo
        private int _difficulte = 2; // Variable pour stocker la difficulté (par défaut à 2)
        private string _couleur = "#ffcb01"; // Variable pour stocker la couleur (par défaut à jaune)

        private bool[] _bonus = { true, true, true, true }; // Tableau pour stocker l'état des bonus

        /* ----------------- Constructeur de la classe FormMenuParametre ----------------- */

        // Constructeur prenant en paramètre les références vers le formulaire principal et FormMenuPseudo
        public FormMenuParametre(FormMenuPrincipal formMenuPrincipal, FormMenuPseudo formMenuPseudo)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.formMenuPseudo = formMenuPseudo;

            // Initialise le pseudo en utilisant la propriété pseudo du formulaire FormMenuPseudo
            _pseudo = formMenuPseudo.pseudo;
        }

        /* ----------------- Gestionnaire d'événement WinForms ----------------- */

        // Redimensionnement du formulaire
        private void FormMenuParametre_SizeChanged(object sender, EventArgs e)
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

        // Fermeture du formulaire
        private void FormMenuParametre_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked == true)
                formMenuPseudo.Show(); // Affiche le formulaire FormMenuPseudo si le bouton "Retour" a été cliqué
            else
                formMenuPrincipal.Close(); // Ferme le formulaire principal si le bouton "Retour" n'a pas été cliqué
        }

        // Clic sur le bouton "Jouer"
        private void btnJouer_Click(object sender, EventArgs e)
        {
            // Crée une instance de Partie avec les paramètres actuels
            Partie partie = new Partie(_pseudo, _difficulte, _couleur, _bonus);

            // Crée une instance de FormPartie en passant le formulaire principal et la partie créée
            FormPartie formPartie = new FormPartie(formMenuPrincipal, partie);
            formPartie.Show(); // Affiche le formulaire FormPartie
            this.Hide(); // Cache le formulaire actuel
        }

        // Clic sur le bouton "Difficulté"
        private void btnDifficulte_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire FormMenuDifficulte en passant la référence vers le formulaire actuel
            FormMenuDifficulte formMenuDifficulte = new FormMenuDifficulte(this);
            formMenuDifficulte.Show();
            this.Hide(); // Cache le formulaire actuel
        }

        // Clic sur le bouton "Couleur"
        private void btnCouleur_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire FormMenuCouleur en passant la référence vers le formulaire actuel
            FormMenuCouleur formMenuCouleur = new FormMenuCouleur(this);
            formMenuCouleur.Show();
            this.Hide(); // Cache le formulaire actuel
        }

        // Clic sur le bouton "Bonus"
        private void btnBonus_Click(object sender, EventArgs e)
        {
            // Affiche le formulaire FormMenuBonus en passant la référence vers le formulaire actuel
            FormMenuBonus formMenuBonus = new FormMenuBonus(this);
            formMenuBonus.Show();
            this.Hide(); // Cache le formulaire actuel
        }

        /* ----------------- Fonctions getter et setter ----------------- */

        public int difficulte
        {
            get { return _difficulte; }
            set { _difficulte = value; }
        }

        public string couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }

        public bool[] bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }
    }
}
