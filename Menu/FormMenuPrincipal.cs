using Interface_PacMan;
using BibliothequePacMan;
using System.Media;
using Interface_PacMan.Properties;
using NAudio.Wave;
using System.Configuration;
using Bibliotheque_PacMan;

namespace Menu
{
    public partial class FormMenuPrincipal : Form
    {
        private WaveOutEvent waveOut; // Objet WaveOutEvent de NAudio pour la lecture audio
        private AudioFileReader audioFile; // Objet AudioFileReader de NAudio pour la gestion des fichiers audio
        private string currentAudioFilePath; // Chemin du fichier audio actuel

        /* ----------------- Constructeur de la classe FormMenuPrincipal ----------------- */

        // Initialise le formulaire et charge l'audio initial (à partir de la ressource embarquée)
        public FormMenuPrincipal()
        {
            InitializeComponent();
            InitializeAudio(Interface_PacMan.Properties.Resources.Italie, "Italie.wav");
        }

        /* ----------------- Fonctions pour la gestion de la musique ----------------- */

        // Gestionnaire d'événement pour les changements de fichier de configuration
        private void OnConfigFileChanged(object sender, FileSystemEventArgs e)
        {
            waveOut.Stop();
        }

        // Initialise la lecture audio avec la ressource et le nom de fichier donnés
        private void InitializeAudio(UnmanagedMemoryStream resource, string fileName)
        {
            string tempFilePath = SaveResourceToTempFile(resource, fileName);
            currentAudioFilePath = tempFilePath;

            waveOut = new WaveOutEvent();
            audioFile = new AudioFileReader(tempFilePath);

            waveOut.PlaybackStopped += OnPlaybackStopped;

            waveOut.Init(audioFile);
        }

        // Démarre la lecture
        public void Play()
        {
            waveOut.Play();
        }

        // Arrête la lecture
        public void Stop()
        {
            waveOut.Stop();
        }

        // Gestionnaire d'événement pour l'arrêt de la lecture
        private void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (audioFile != null && audioFile.Length > 0)
            {
                audioFile.Position = 0;
                waveOut.Play();                
            }
        }

        // Change de piste audio vers une nouvelle ressource et un nouveau nom de fichier
        public void ChangeTrack(UnmanagedMemoryStream newResource, string newFileName)
        {
            waveOut.Stop();

            audioFile.Dispose();

            string newTempFilePath = SaveResourceToTempFile(newResource, newFileName);
            currentAudioFilePath = newTempFilePath;

            audioFile = new AudioFileReader(newTempFilePath);
            waveOut.Init(audioFile);

            waveOut.Play();
        }

        // Sauvegarde la ressource dans un fichier temporaire et retourne le chemin du fichier
        private string SaveResourceToTempFile(UnmanagedMemoryStream resource, string fileName)
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), fileName);

            using (FileStream fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write))
            {
                resource.CopyTo(fileStream);
            }

            return tempFilePath;
        }

        // Arrête l'audio lors de la fermeture du formulaire
        private void StopAudio()
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
        }

        /* ----------------- Gestionnaire d'événement WinForms ----------------- */

        // Redimensionnement du formulaire
        private void FormMenuPrincipal_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this);
        }

        // Survole de souris sur un bouton
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Utils.btn_MouseEnter(sender, e);
        }

        // Sortie de souris d'un bouton
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Utils.btn_MouseLeave(sender, e);
        }

        // Clic sur le bouton "Continuer"
        private void btnContinuer_Click(object sender, EventArgs e)
        {
            FormMenuContinuer formMenuContinuer = new FormMenuContinuer(this);
            formMenuContinuer.Show();
            this.Hide();
        }

        // Clic sur le bouton "Nouvelle Partie"
        private void btnNouvellePartie_Click(object sender, EventArgs e)
        {
            FormMenuPseudo formMenuPseudo = new FormMenuPseudo(this);
            formMenuPseudo.Show();
            this.Hide();
        }

        // Clic sur le bouton "Options"
        private void btnOptions_Click(object sender, EventArgs e)
        {
            FormMenuOptions formMenuOptions = new FormMenuOptions(this);
            formMenuOptions.Show();
            this.Hide();
        }

        // Chargement du formulaire
        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                waveOut.Play();
                Volume = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeMusique"]) / 100.0f;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la lecture de la musique : " + ex.Message);
            }
        }

        // Fermeture du formulaire
        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAudio();
        }

        /* ----------------- Fonctions getter et setter ----------------- */

        // Méthode publique pour changer le volume audio
        public float Volume
        {
            get { return waveOut.Volume; }
            set { waveOut.Volume = value; }
        }
    }
}
