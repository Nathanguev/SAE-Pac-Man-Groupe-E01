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
    public partial class FormMenuCouleur : Form
    {
        private FormMenuParametre formMenuParametre;
        private Button btnSelected;
        private bool isBtnRetourClicked = false;

        public FormMenuCouleur(FormMenuParametre formMenuParametre)
        {
            InitializeComponent();
            this.formMenuParametre = formMenuParametre;
        }

        private void FormMenuCouleur_Load(object sender, EventArgs e)
        {
            btn_Select();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true;
            this.Close();
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

        private void FormMenuCouleur_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked)
            {
                formMenuParametre.Show();
            }
            else
            {
                formMenuParametre.Close();
            }
        }

        private void btn_Select()
        {
            RoundButton[] buttons = { btnJaune, btnViolet, btnRouge, btnBeige, btnVert, btnPerso };
            foreach (RoundButton btn in buttons)
            {
                if (formMenuParametre.couleur == btn.HexaColor)
                {
                    btnSelected = btn;
                    btn.BorderWidth = 15;
                    btn.BorderColor = Color.DeepSkyBlue;
                }
                else
                {
                    btn.BorderWidth = 0;
                    btn.BorderColor = Color.Transparent;
                }
            }
        }

        private void btnCouleur_Click(object sender, EventArgs e)
        {
            RoundButton btn = (RoundButton)sender;
            formMenuParametre.couleur = btn.HexaColor;
            btn_Select();
        }

        private void FormMenuCouleur_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this);
        }

        private void btnPerso_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    btnPerso.BackColor = selectedColor;
                    btnPerso.HexaColor = $"#{btnPerso.BackColor.A:X2}{btnPerso.BackColor.R:X2}{btnPerso.BackColor.G:X2}{btnPerso.BackColor.B:X2}";
                    formMenuParametre.couleur = btnPerso.HexaColor;
                    btn_Select();
                }
            }
        }
    }
}
