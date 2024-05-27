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
    public partial class FormMenuOptions : Form
    {
        public FormMenuOptions()
        {
            InitializeComponent();
        }

        public void FormMenuOptions_SizeChanged(object sender, EventArgs e)
        {
            float fontHeight = btnTouches.Size.Height / 5;

            if (fontHeight > 0)
            {
                btnTouches.Font = new Font(btnTouches.Font.FontFamily, fontHeight, FontStyle.Bold);
                btnVolume.Font = new Font(btnVolume.Font.FontFamily, fontHeight, FontStyle.Bold);
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
        }

        private void btnTouches_Click(object sender, EventArgs e)
        {
            FormMenuTouches menuTouches = new FormMenuTouches();
            menuTouches.Show();
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            FormMenuVolume menuVolume = new FormMenuVolume();
            menuVolume.Show();
        }
    }
}
