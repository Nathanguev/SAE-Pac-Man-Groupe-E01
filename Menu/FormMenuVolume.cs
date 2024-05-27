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
    public partial class FormMenuVolume : Form
    {
        public FormMenuVolume()
        {
            InitializeComponent();
        }

        private void FormMenuVolume_SizeChanged(object sender, EventArgs e)
        {
            float fontHeight = lblVolumeEffets.Size.Height / 5;

            if (fontHeight > 0)
            {
                lblVolumeEffets.Font = new Font(lblVolumeEffets.Font.FontFamily, fontHeight, FontStyle.Bold);
                lblVolumeGlobal.Font = new Font(lblVolumeGlobal.Font.FontFamily, fontHeight, FontStyle.Bold);
                lblVolumeMusique.Font = new Font(lblVolumeMusique.Font.FontFamily, fontHeight, FontStyle.Bold);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
