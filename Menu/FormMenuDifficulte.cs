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
    public partial class FormMenuDifficulte : Form
    {
        private FormMenuParametre formMenuParametre;
        private RoundButton btnSelected;
        private bool isBtnRetourClicked = false;

        public FormMenuDifficulte(FormMenuParametre formMenuParametre)
        {
            InitializeComponent();
            this.formMenuParametre = formMenuParametre;
            btnSelected = new RoundButton();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true;
            this.Close();
        }

        private void FormMenuDifficulte_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked == true)
            {
                formMenuParametre.Show();
            }
            else
            {
                formMenuParametre.Close();
            }
        }

        private void FormMenuDifficulte_SizeChanged(object sender, EventArgs e)
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

        private void btnFacile_Click(object sender, EventArgs e)
        {
            formMenuParametre.difficulte = 1;
            btn_Select();
        }

        private void btnMoyen_Click(object sender, EventArgs e)
        {
            formMenuParametre.difficulte = 2;
            btn_Select();
        }

        private void btnDifficile_Click(object sender, EventArgs e)
        {
            formMenuParametre.difficulte = 3;
            btn_Select();
        }

        private void btn_Select()
        {
            RoundButton[] buttons = { btnFacile, btnMoyen, btnDifficile };
            foreach (RoundButton btn in buttons)
            {
                if (formMenuParametre.difficulte == Convert.ToInt32(btn.Tag))
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

        private void FormMenuDifficulte_Load(object sender, EventArgs e)
        {
            btn_Select();
        }
    }
}
