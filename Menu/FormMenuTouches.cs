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

namespace Interface_PacMan
{
    public partial class FormMenuTouches : Form
    {
        public FormMenuTouches()
        {
            InitializeComponent();
            this.FormClosing += FormMenuTouches_FormClosing;
        }

        private void FormMenuTouches_Load(object sender, EventArgs e)
        {
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
            float fontHeight = lblHaut.Size.Height / 5;

            if (fontHeight > 0)
            {
                lblHaut.Font = new Font(lblHaut.Font.FontFamily, fontHeight, FontStyle.Bold);
                txtHaut.Font = new Font(txtHaut.Font.FontFamily, fontHeight, FontStyle.Bold);
                lblBas.Font = new Font(lblBas.Font.FontFamily, fontHeight, FontStyle.Bold);
                txtBas.Font = new Font(txtBas.Font.FontFamily, fontHeight, FontStyle.Bold);
                lblGauche.Font = new Font(lblGauche.Font.FontFamily, fontHeight, FontStyle.Bold);
                txtGauche.Font = new Font(txtGauche.Font.FontFamily, fontHeight, FontStyle.Bold);
                lblDroite.Font = new Font(lblDroite.Font.FontFamily, fontHeight, FontStyle.Bold);
                txtDroite.Font = new Font(txtDroite.Font.FontFamily, fontHeight, FontStyle.Bold);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = textBox.Text.ToUpper();
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
            FormManager.OnFormOptionsClosing();
        }
    }
}
