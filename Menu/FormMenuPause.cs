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
    public partial class FormMenuPause : Form
    {
        private FormMenuPrincipal formMenuPrincipal;
        private FormPartie formPartie;
        private bool isBtnQuitterClicked = false;
        private bool isBtnContinuerClicked = false;

        public FormMenuPause(FormMenuPrincipal formMenuPrincipal, FormPartie formPartie)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.formPartie = formPartie;
        }

        private void FormMenuPause_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnContinuerClicked)
            {
                formPartie.Show();
            }
            else if (isBtnQuitterClicked)
            {
                formMenuPrincipal.Show();
            }
            else
            {
                formMenuPrincipal.Close();
            }
        }

        private void btnContinuer_Click(object sender, EventArgs e)
        {
            isBtnContinuerClicked = true;
            this.Close();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            isBtnQuitterClicked = true;
            this.Close();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            FormMenuOptions formMenuOptions = new FormMenuOptions(formMenuPrincipal, this);
            formMenuOptions.Show();
            this.Hide();
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

        private void FormMenuPause_SizeChanged(object sender, EventArgs e)
        {
            float fontHeight = btnContinuer.Size.Height / 5;

            if (fontHeight > 0)
            {
                btnContinuer.Font = new Font(btnContinuer.Font.FontFamily, fontHeight, FontStyle.Bold);
                btnOptions.Font = new Font(btnOptions.Font.FontFamily, fontHeight, FontStyle.Bold);
                btnQuitter.Font = new Font(btnQuitter.Font.FontFamily, fontHeight, FontStyle.Bold);
            }
        }
    }
}
