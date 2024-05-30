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
    public partial class UserControlButton : UserControl
    {
        private Form form;

        public UserControlButton(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            form.Close();
        }

        private void roundButton1_MouseEnter(object sender, EventArgs e)
        {
            roundButton1.BackColor = Color.LightBlue;
        }

        private void roundButton1_MouseLeave(object sender, EventArgs e)
        {
            roundButton1.BackColor = Color.FromArgb(224, 224, 224);
        }
    }
}
