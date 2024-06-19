using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Menu;
using Bibliotheque_PacMan;

namespace Interface_PacMan
{
    public partial class FormMenuTouches : Form
    {
        private FormMenuPrincipal formMenuPrincipal;
        private FormMenuOptions formMenuOptions;
        private List<TextBox> textBoxes;
        private bool isBtnRetourClicked = false;

        public FormMenuTouches(FormMenuPrincipal formMenuPrincipal, FormMenuOptions formMenuOptions)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.formMenuOptions = formMenuOptions;
        }

        private void FormMenuTouches_Load(object sender, EventArgs e)
        {
            textBoxes = [txtHaut, txtBas, txtGauche, txtDroite];

            txtHaut.Text = ConfigurationManager.AppSettings["ToucheHaut"];
            txtBas.Text = ConfigurationManager.AppSettings["ToucheBas"];
            txtGauche.Text = ConfigurationManager.AppSettings["ToucheGauche"];
            txtDroite.Text = ConfigurationManager.AppSettings["ToucheDroite"];
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

        private void FormMenuTouches_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true;
            this.Close();
        }

        private void tlp_Click(object sender, EventArgs e)
        {
            RoundTableLayoutPanel tlp = (RoundTableLayoutPanel)sender;
            foreach (Control child in tlp.Controls)
            {
                if (child.Tag != null && child.Tag.Equals(tlp.Tag))
                {
                    child.Focus();
                    break;
                }
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = textBox.Text.ToUpper();

            foreach (TextBox txt in textBoxes)
            {
                if (textBox.Text == txt.Text && textBox != txt && textBox.Text.Length != 0)
                {
                    DialogResult result = MessageBox.Show("Cette touche est déjà assignée", "Voulez vous continuer ?", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        txt.Text = "";
                    }
                    else if (result == DialogResult.No)
                    {
                        textBox.Text = "";
                    }
                }
            }
        }

        private void txt_Validated(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string key = textBox.Tag.ToString();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = textBox.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void FormMenuTouches_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked == true)
            {
                formMenuOptions.Show();
            }
            else
            {
                formMenuPrincipal.Close();
            }
        }
    }
}
