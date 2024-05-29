using Interface_PacMan;
using BibliothequePacMan;
using System.Media;
using Interface_PacMan.Properties;
using NAudio.Wave;
using System.Configuration;

namespace Menu
{
    public partial class FormMenuPrincipal : Form
    {
        private WaveOutEvent waveOut;
        private AudioFileReader audioFile;

        public FormMenuPrincipal()
        {
            InitializeComponent();
            FormManager.FormClosing += FormManager_FormClosing;

            var audioStream = Interface_PacMan.Properties.Resources.Italie;
            InitializeAudio();
        }

        private void OnConfigFileChanged(object sender, FileSystemEventArgs e)
        {
            waveOut.Stop();
        }

        private void InitializeAudio()
        {
            string tempFilePath = SaveResourceToTempFile(Interface_PacMan.Properties.Resources.Italie, "Italie.wav");

            waveOut = new WaveOutEvent();
            audioFile = new AudioFileReader(tempFilePath);

            waveOut.PlaybackStopped += OnPlaybackStopped;

            waveOut.Init(audioFile);
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            audioFile.Position = 0;
            waveOut.Play();
        }

        private string SaveResourceToTempFile(UnmanagedMemoryStream resource, string fileName)
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), fileName);

            using (FileStream fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
            {
                resource.CopyTo(fileStream);
            }

            return tempFilePath;
        }

        private void FormManager_FormClosing()
        {
            this.Invoke((Action)(() => this.Show()));
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            FormManager.FormClosing -= FormManager_FormClosing;
        }

        private void FormMenuPrincipal_SizeChanged(object sender, EventArgs e)
        {
            float fontHeight = btnContinuer.Size.Height / 5;

            if (fontHeight > 0)
            {
                btnContinuer.Font = new Font(btnContinuer.Font.FontFamily, fontHeight, FontStyle.Bold);
                btnNouvellePartie.Font = new Font(btnNouvellePartie.Font.FontFamily, fontHeight, FontStyle.Bold);
                btnOptions.Font = new Font(btnOptions.Font.FontFamily, fontHeight, FontStyle.Bold);
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

        private void btnContinuer_Click(object sender, EventArgs e)
        {
            FormMenuContinuer formMenuContinuer = new FormMenuContinuer(this);
            formMenuContinuer.Show();
            this.Hide();
        }

        private void btnNouvellePartie_Click(object sender, EventArgs e)
        {
            FormMenuPseudo formMenuPseudo = new FormMenuPseudo();
            formMenuPseudo.Show();
            this.Hide();
        }

        private async void btnOptions_Click(object sender, EventArgs e)
        {
            FormMenuOptions formMenuOptions = new FormMenuOptions(this);
            formMenuOptions.Show();
            this.Hide();
        }

        public void VolumeChanged(float volume)
        {
            waveOut.Volume = volume;
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                waveOut.Play();
                waveOut.Volume = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeMusique"]) / 100.0f;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la lecture de la musique : " + ex.Message);
            }
        }

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            waveOut.Dispose();
            audioFile.Dispose();
        }
    }
}
