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
    public partial class UserControlSauvegarde : UserControl
    {
        private FormMenuPrincipal formMenuPrincipal;
        private FormMenuContinuer formMenuContinuer;

        public UserControlSauvegarde(FormMenuPrincipal formMenuPrincipal, FormMenuContinuer formMenuContinuer)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.formMenuContinuer = formMenuContinuer;
        }

        private void UserControlSauvegarde_Click(object sender, EventArgs e)
        {
            Partie partie = new Partie();
            FormPartie formPartie = new FormPartie(formMenuPrincipal, partie);
            formMenuContinuer.Hide();
            formPartie.Show();
        }

        private void UserControlSauvegarde_MouseEnter(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.LightBlue;
        }

        private void UserControlSauvegarde_MouseLeave(object sender, EventArgs e)
        {
            tableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void UserControlSauvegarde_SizeChanged(object sender, EventArgs e)
        {
            float fontHeight = lblUserPseudo.Size.Height / 3;

            if (fontHeight > 0)
            {
                lblUserPseudo.Font = new Font(lblUserPseudo.Font.FontFamily, fontHeight, FontStyle.Bold);
                lblDateCreation.Font = new Font(lblDateCreation.Font.FontFamily, fontHeight, FontStyle.Bold);
            }
        }
    }
}
