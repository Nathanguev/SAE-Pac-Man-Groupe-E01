using Menu;
using System.Configuration;
using Bibliotheque_PacMan;

namespace Interface_PacMan
{
    public partial class FormMenuVolume : Form
    {
        private FormMenuPrincipal formMenuPrincipal; // Référence vers le formulaire principal
        private FormMenuOptions formMenuOptions; // Référence vers le formulaire des options
        private bool isBtnRetourClicked = false; // Indique si le bouton "Retour" a été cliqué

        /* ----------------- Constructeurs de la classe FormMenuVolume ----------------- */

        // Constructeur prenant en paramètre les références vers le formulaire principal et celui des options
        public FormMenuVolume(FormMenuPrincipal formMenuPrincipal, FormMenuOptions formMenuOptions)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.formMenuOptions = formMenuOptions;
        }

        /* ----------------- Gestionnaire d'événement WinForms ----------------- */

        // Redimensionnement du formulaire
        private void FormMenuVolume_SizeChanged(object sender, EventArgs e)
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

        // Clic sur le bouton "Retour"
        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true; // Indique que le bouton "Retour" a été cliqué
            this.Close(); // Ferme le formulaire actuel
        }

        // Chargement du formulaire
        private void FormMenuVolume_Load(object sender, EventArgs e)
        {
            // Charge les valeurs des volumes à partir des paramètres de configuration
            trackBarEffets.Value = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeEffets"]);
            trackBarGlobal.Value = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeGlobal"]);
            trackBarMusique.Value = Convert.ToInt32(ConfigurationManager.AppSettings["VolumeMusique"]);
        }

        // Validation des valeurs des trackbars (lorsqu'elles perdent le focus)
        private void trackBar_Validated(object sender, EventArgs e)
        {
            TrackBar trackBar = (TrackBar)sender;
            string key = trackBar.Tag.ToString(); // Clé correspondant à la valeur dans les paramètres de configuration
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = trackBar.Value.ToString(); // Met à jour la valeur dans les paramètres de configuration
            config.Save(ConfigurationSaveMode.Modified); // Enregistre les modifications
            ConfigurationManager.RefreshSection("appSettings"); // Rafraîchit la section des paramètres de configuration
        }

        // Événement de fermeture du formulaire
        private void FormMenuVolume_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked == true)
                formMenuOptions.Show(); // Affiche le formulaire des options si le bouton "Retour" a été cliqué
            else
                formMenuPrincipal.Close(); // Ferme le formulaire principal si le bouton "Retour" n'a pas été cliqué
        }

        // Changement de la valeur de la trackbar de musique
        private void trackBarMusique_ValueChanged(object sender, EventArgs e)
        {
            // Appelle la méthode de changement de volume dans le formulaire principal
            formMenuPrincipal.Volume = trackBarMusique.Value / 100.0f;
        }
    }
}
