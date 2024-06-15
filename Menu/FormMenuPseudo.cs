using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_PacMan
{
    public partial class FormMenuPseudo : Form
    {
        private FormMenuPrincipal formMenuPrincipal;
        private bool isBtnRetourClicked = false;

        public FormMenuPseudo(FormMenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
        }

        private void FormMenuPseudo_SizeChanged(object sender, EventArgs e)
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

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            FormMenuParametre formMenuParametre = new FormMenuParametre(formMenuPrincipal, this);
            formMenuParametre.Show();
            this.Hide();
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
            if (isBtnRetourClicked == true)
            {
                formMenuPrincipal.Show();
            }
            else
            {
                formMenuPrincipal.Close();
            }
        }

        private void FormMenuPseudo_Load(object sender, EventArgs e)
        {

        }

        private void tlpPseudo_Click(object sender, EventArgs e)
        {
            txtPseudo.Focus();
        }

        private void txtPseudo_Validated(object sender, EventArgs e)
        {

        }

        public string pseudo
        {
            get
            {
                return txtPseudo.Text;
            }
        }
    }
}
