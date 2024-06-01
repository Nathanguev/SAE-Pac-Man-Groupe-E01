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
        private bool isBtnRetourClicked = false;

        public FormMenuContinuer(FormMenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;

            UserControlSauvegarde sauvegarde = new UserControlSauvegarde(formMenuPrincipal, this);
            tableLayoutPanel2.Controls.Add(sauvegarde, 3, 1);
            sauvegarde.Dock = DockStyle.Fill;
            sauvegarde.Margin = new Padding(0);
        }

        private void FormMenuContinuer_Load(object sender, EventArgs e)
        {

        }

        private void FormMenuContinuer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked)
            {
                formMenuPrincipal.Show();
            }
            else
            {
                formMenuPrincipal.Close();
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true;
            this.Close();
        }
    }
}
