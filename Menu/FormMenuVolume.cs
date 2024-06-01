using Menu;
using System.Configuration;

namespace Interface_PacMan
{
    public partial class FormMenuVolume : Form
    {
        private FormMenuPrincipal formMenuPrincipal;
        private FormMenuOptions formMenuOptions;
        private bool isBtnRetourClicked = false;

        public FormMenuVolume(FormMenuPrincipal formMenuPrincipal, FormMenuOptions formMenuOptions)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.formMenuOptions = formMenuOptions;
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

        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true;
            this.Close();
        }

        private void FormMenuVolume_Load(object sender, EventArgs e)
        {
            trackBarEffets.Value = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeEffets"]);
            trackBarGlobal.Value = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeGlobal"]);
            trackBarMusique.Value = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeMusique"]);
        }

        private void trackBar_Validated(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            string key = trackBar.Tag.ToString();
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = trackBar.Value.ToString();
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void FormMenuVolume_FormClosing(object sender, FormClosingEventArgs e)
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

        private void trackBarMusique_ValueChanged(object sender, EventArgs e)
        {
            formMenuPrincipal.VolumeChanged(trackBarMusique.Value / 100.0f);
        }
    }
}
