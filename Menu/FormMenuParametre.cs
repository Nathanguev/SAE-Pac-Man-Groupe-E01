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
        private int _difficulte;
        private string _couleur;

        private bool _bonusVitesse;
        private bool _bonusScore;
        private bool _bonusVie;
        private bool _bonusTrainee;
        private bool _bonusFantome;

        public FormMenuParametre(FormMenuPrincipal formMenuPrincipal, FormMenuPseudo formMenuPseudo)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.formMenuPseudo = formMenuPseudo;

            _pseudo = formMenuPseudo.pseudo;
            _difficulte = 2;
            _couleur = "#ffcb01";

            _bonusVitesse = true;
            _bonusScore = true;
            _bonusVie = true;
            _bonusTrainee = true;
            _bonusFantome = true;
        }

        private void FormMenuParametre_SizeChanged(object sender, EventArgs e)
        {
            float fontHeight = btnCouleur.Size.Height / 5;

            if (fontHeight > 0)
            {
                btnCouleur.Font = new Font(btnCouleur.Font.FontFamily, fontHeight, FontStyle.Bold);
                btnDifficulte.Font = new Font(btnDifficulte.Font.FontFamily, fontHeight, FontStyle.Bold);
                btnBonus.Font = new Font(btnBonus.Font.FontFamily, fontHeight, FontStyle.Bold);
                btnJouer.Font = new Font(btnJouer.Font.FontFamily, fontHeight, FontStyle.Bold);
            }
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
            Partie partie = new Partie(_pseudo, _difficulte, _couleur, _bonusVitesse, _bonusScore, _bonusVie, _bonusTrainee, _bonusFantome);
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

        public bool bonusVitesse
        {
            get { return _bonusVitesse; }
            set { _bonusVitesse = value; }
        }

        public bool bonusScore
        {
            get { return _bonusScore; }
            set { _bonusScore = value; }
        }

        public bool bonusVie
        {
            get { return _bonusVie; }
            set { _bonusVie = value; }
        }

        public bool bonusTrainee
        {
            get { return _bonusTrainee; }
            set { _bonusTrainee = value; }
        }

        public bool bonusFantome
        {
            get { return _bonusFantome; }
            set { _bonusFantome = value; }
        }
    }
}
