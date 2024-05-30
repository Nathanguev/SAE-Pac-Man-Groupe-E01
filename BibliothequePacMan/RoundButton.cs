using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque_PacMan
{
    public class RoundButton : Button
    {
        private PictureBox pictureBox;

        public RoundButton()
        {
            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.Transparent;
            this.Controls.Add(pictureBox);

            this.Resize += new EventHandler(RoundButton_Resize);
            UpdatePictureBoxPosition();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(graphicsPath);
            base.OnPaint(pevent);
        }

        public Image PictureBoxImage
        {
            get { return pictureBox.Image; }
            set { pictureBox.Image = value; }
        }

        private void RoundButton_Resize(object sender, EventArgs e)
        {
            UpdatePictureBoxPosition();
        }

        private void UpdatePictureBoxPosition()
        {
            int imageSize = Math.Min(this.ClientSize.Width, this.ClientSize.Height);
            pictureBox.Size = new Size(imageSize, imageSize);
            pictureBox.Location = new Point((this.ClientSize.Width - pictureBox.Width), (this.ClientSize.Height - pictureBox.Height));
        }
    }
}
