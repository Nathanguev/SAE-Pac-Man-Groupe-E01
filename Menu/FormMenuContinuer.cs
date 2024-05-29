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
    public partial class FormMenuContinuer : Form
    {
        private FormMenuPrincipal formMenuPrincipal;

        public FormMenuContinuer(FormMenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
        }

        private void FormMenuContinuer_Load(object sender, EventArgs e)
        {

        }

        private void FormMenuContinuer_FormClosing(object sender, FormClosingEventArgs e)
        {
            formMenuPrincipal.Show();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
