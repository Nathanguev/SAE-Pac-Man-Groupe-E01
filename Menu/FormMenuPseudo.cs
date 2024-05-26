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
        }

        private void FormMenuPseudo_SizeChanged(object sender, EventArgs e)
        {
            float fontHeight = btnSuivant.Size.Height / 5;

            btnSuivant.Font = new Font(btnSuivant.Font.FontFamily, fontHeight, FontStyle.Bold);
            txtPseudo.Font = new Font(txtPseudo.Font.FontFamily, fontHeight, FontStyle.Bold);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Suivant");
        }
    }
}
