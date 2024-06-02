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
    public partial class FormFinPartie : Form
    {
        private FormMenuPrincipal formMenuPrincipal;
        private Partie partie;
        private bool isVictory;
        private bool isBtnQuitterClicked = false;
        private bool isBtnSuivantClicked = false;

        public FormFinPartie(FormMenuPrincipal formMenuPrincipal, Partie partie, bool isVictory)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.partie = partie;
            this.isVictory = isVictory;
        }

        private void FormVictory_Load(object sender, EventArgs e)
        {
            lblScore.Text = "SCORE : " + partie.score;
            if (isVictory)
            {
                pictureBoxMessage.Image = Properties.Resources.victory;
            }
            else
            {
                pictureBoxMessage.Image = Properties.Resources.game_over;
                btnNiveauSuivant.Visible = false;
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

        private void btnNiveauSuivant_Click(object sender, EventArgs e)
        {
            isBtnSuivantClicked = true;
            this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            isBtnQuitterClicked = true;
            this.Close();
        }

        private void FormVictory_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnQuitterClicked == true)
            {
                formMenuPrincipal.Show();
            }
            else if (isBtnSuivantClicked == true)
            {
                FormPartie formPartie = new FormPartie(formMenuPrincipal, partie);
                formPartie.Show();
            }
            else
            {
                formMenuPrincipal.Close();
            }
        }

        private void FormVictory_SizeChanged(object sender, EventArgs e)
        {
            float fontHeight = lblScore.Size.Height / 5;

            if (fontHeight > 0)
            {
                lblScore.Font = new Font(lblScore.Font.FontFamily, fontHeight, FontStyle.Bold);
                btnNiveauSuivant.Font = new Font(btnNiveauSuivant.Font.FontFamily, fontHeight, FontStyle.Bold);
                btnQuitter.Font = new Font(btnQuitter.Font.FontFamily, fontHeight, FontStyle.Bold);
            }
        }
    }
}
