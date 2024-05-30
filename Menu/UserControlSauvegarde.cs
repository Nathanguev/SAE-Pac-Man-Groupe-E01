using BibliothequePacMan;
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
        public UserControlSauvegarde()
        {
            InitializeComponent();
        }

        private void UserControlSauvegarde_Click(object sender, EventArgs e)
        {
            Partie partie = new Partie();
            FormPartie formPartie = new FormPartie(partie);
            formPartie.ShowDialog();
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
