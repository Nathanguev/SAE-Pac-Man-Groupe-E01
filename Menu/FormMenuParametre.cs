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
        private FormMenuPseudo formMenuPseudo;

        public FormMenuParametre(FormMenuPseudo formMenuPseudo)
        {
            InitializeComponent();
            this.formMenuPseudo = formMenuPseudo;
        }

        private void FormMenuParametre_SizeChanged(object sender, EventArgs e)
        {
            float fontHeight = btnCouleur.Size.Height / 5;

            if (fontHeight > 0)
            {
                btnCouleur.Font = new Font(btnCouleur.Font.FontFamily, fontHeight, FontStyle.Bold);
                btnDifficulte.Font = new Font(btnDifficulte.Font.FontFamily, fontHeight, FontStyle.Bold);
                btnBonus.Font = new Font(btnBonus.Font.FontFamily, fontHeight, FontStyle.Bold);
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
            formMenuPseudo.Show();
        }

        private void FormMenuParametre_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMenuPseudo.Show();
        }
    }
}
