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
    public partial class FormMenuPseudo : Form
    {
        public FormMenuPseudo()
        {
            InitializeComponent();
            this.FormClosing += FormMenuPseudo_FormClosing;
        }

        private void FormMenuPseudo_SizeChanged(object sender, EventArgs e)
        {
            float fontHeight = btnSuivant.Size.Height / 5;

            if (fontHeight > 0)
            {
                btnSuivant.Font = new Font(btnSuivant.Font.FontFamily, fontHeight, FontStyle.Bold);
                txtPseudo.Font = new Font(txtPseudo.Font.FontFamily, fontHeight, FontStyle.Bold);
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
            this.Close();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            FormMenuParametre formMenuParametre = new FormMenuParametre();
            formMenuParametre.Show();
        }

        private void txtPseudo_TextChanged(object sender, EventArgs e)
        {
            if (txtPseudo.Text.Length == 0)
            {
                btnSuivant.Enabled = false;
            }
            else
            {
                btnSuivant.Enabled = true;
            }
        }

        private void FormMenuPseudo_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.OnFormClosing();
        }
    }
}
