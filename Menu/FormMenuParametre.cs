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
        private FormMenuPrincipal formMenuPrincipal;
        private FormMenuPseudo formMenuPseudo;
        private bool isBtnRetourClicked = false;

        private string _pseudo;
        private int _difficulte = 2;
        private string _couleur = "#ffcb01";

        private bool[] _bonus = { true, true, true, true };

        public FormMenuParametre(FormMenuPrincipal formMenuPrincipal, FormMenuPseudo formMenuPseudo)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.formMenuPseudo = formMenuPseudo;

            _pseudo = formMenuPseudo.pseudo;
        }

        private void FormMenuParametre_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this);
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightBlue;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true;
            this.Close();
        }

        private void FormMenuParametre_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked == true)
            {
                formMenuPseudo.Show();
            }
            else
            {
                formMenuPrincipal.Close();
            }
        }

        private void FormMenuParametre_Load(object sender, EventArgs e)
        {

        }

        private void btnJouer_Click(object sender, EventArgs e)
        {
            Partie partie = new Partie(_pseudo, _difficulte, _couleur, _bonus);
            FormPartie formPartie = new FormPartie(formMenuPrincipal, partie);
            formPartie.Show();
            this.Hide();
        }

        private void btnDifficulte_Click(object sender, EventArgs e)
        {
            FormMenuDifficulte formMenuDifficulte = new FormMenuDifficulte(this);
            formMenuDifficulte.Show();
            this.Hide();
        }

        private void btnCouleur_Click(object sender, EventArgs e)
        {
            FormMenuCouleur formMenuCouleur = new FormMenuCouleur(this);
            formMenuCouleur.Show();
            this.Hide();
        }

        private void btnBonus_Click(object sender, EventArgs e)
        {
            FormMenuBonus formMenuBonus = new FormMenuBonus(this);
            formMenuBonus.Show();
            this.Hide();
        }

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
