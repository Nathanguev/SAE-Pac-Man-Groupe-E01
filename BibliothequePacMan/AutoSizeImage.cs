using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque_PacMan
{
    public enum ImageSizeMode
    {
        Normal,
        Stretch,
        Center,
        Zoom
    }

    public class AutoSizeImage
    {
        private Image _image;
        private ImageSizeMode _sizeMode;

        public AutoSizeImage(Image image)
        {
            _image = image;
            _sizeMode = ImageSizeMode.Zoom;
        }

        public Image Image
        {
            get { return _image; }
            set { _image = value; }
        }

        public ImageSizeMode SizeMode
        {
            get { return _sizeMode; }
            set { _sizeMode = value; }
        }
    }
}
