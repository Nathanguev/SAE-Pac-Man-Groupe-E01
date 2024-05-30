using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque_PacMan
{
    public class CaseLabyrinthe : PictureBox
    {
        public CaseLabyrinthe(TableLayoutPanel tlp)
        {
            this.Margin = new Padding(0);
            this.Dock = DockStyle.Fill;
            this.SizeMode = PictureBoxSizeMode.Zoom;

            tlp.Controls.Add(this);
        }
    }
}
