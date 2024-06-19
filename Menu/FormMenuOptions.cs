using Menu;
using Bibliotheque_PacMan;

namespace Interface_PacMan
{
    public partial class FormMenuOptions : Form
    {
        private FormMenuPrincipal formMenuPrincipal; // Référence vers le formulaire principal
        private FormMenuPause formMenuPause; // Référence vers le formulaire de pause
        private bool isBtnRetourClicked = false; // Indique si le bouton "Retour" a été cliqué

        /* ----------------- Constructeurs de la classe FormMenuOptions ----------------- */

        public FormMenuOptions(FormMenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            formMenuPause = null; // Initialise le formulaire de pause à null
        }

        public FormMenuOptions(FormMenuPrincipal formMenuPrincipal, FormMenuPause formMenuPause)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.formMenuPause = formMenuPause; // Initialise le formulaire de pause avec la référence donnée
        }

        /* ----------------- Gestionnaire d'événement WinForms ----------------- */

        // Redimensionnement du formulaire
        public void FormMenuOptions_SizeChanged(object sender, EventArgs e)
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

        // Clic sur le bouton "Touches"
        private void btnTouches_Click(object sender, EventArgs e)
        {
            FormMenuTouches formMenuTouches = new FormMenuTouches(formMenuPrincipal, this);
            formMenuTouches.Show(); // Affiche le formulaire des touches
            this.Hide(); // Cache le formulaire actuel
        }

        // Clic sur le bouton "Volume"
        private void btnVolume_Click(object sender, EventArgs e)
        {
            FormMenuVolume menuVolume = new FormMenuVolume(formMenuPrincipal, this);
            menuVolume.Show(); // Affiche le formulaire de réglage du volume
            this.Hide(); // Cache le formulaire actuel
        }

        // Événement de fermeture du formulaire
        private void FormMenuOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked == true)
            {
                if (formMenuPause != null)
                    formMenuPause.Show(); // Affiche le formulaire de pause s'il existe
                else
                    formMenuPrincipal.Show(); // Sinon, affiche le formulaire principal
            }
            else
            {
                // Ferme le formulaire principal si le bouton "Retour" n'a pas été cliqué
                formMenuPrincipal.Close();
            }
        }
    }
}
