using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Menu;
using Bibliotheque_PacMan;

namespace Interface_PacMan
{
    public partial class FormMenuTouches : Form
    {
        private FormMenuPrincipal formMenuPrincipal; // Référence vers le formulaire principal
        private FormMenuOptions formMenuOptions; // Référence vers le formulaire des options
        private List<TextBox> textBoxes; // Liste des zones de texte pour les touches
        private bool isBtnRetourClicked = false; // Indique si le bouton "Retour" a été cliqué

        /* ----------------- Constructeurs de la classe FormMenuTouches ----------------- */

        // Constructeur prenant en paramètre les références vers le formulaire principal et celui des options
        public FormMenuTouches(FormMenuPrincipal formMenuPrincipal, FormMenuOptions formMenuOptions)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.formMenuOptions = formMenuOptions;
        }

        /* ----------------- Gestionnaire d'événement WinForms ----------------- */

        // Chargement du formulaire
        private void FormMenuTouches_Load(object sender, EventArgs e)
        {
            // Initialise la liste des zones de texte pour les touches
            textBoxes = [txtHaut, txtBas, txtGauche, txtDroite];

            // Charge les valeurs des touches à partir des paramètres de configuration
            txtHaut.Text = ConfigurationManager.AppSettings["ToucheHaut"];
            txtBas.Text = ConfigurationManager.AppSettings["ToucheBas"];
            txtGauche.Text = ConfigurationManager.AppSettings["ToucheGauche"];
            txtDroite.Text = ConfigurationManager.AppSettings["ToucheDroite"];
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

        // Redimensionnement du formulaire
        private void FormMenuTouches_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this);
        }

        // Clic sur le bouton "Retour"
        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true; // Indique que le bouton "Retour" a été cliqué
            this.Close(); // Ferme le formulaire actuel
        }

        // Clic sur un élément dans le RoundTableLayoutPanel
        private void tlp_Click(object sender, EventArgs e)
        {
            RoundTableLayoutPanel tlp = (RoundTableLayoutPanel)sender;
            foreach (Control child in tlp.Controls)
            {
                // Met le focus sur le contrôle enfant qui a le même Tag que le Tag du RoundTableLayoutPanel
                if (child.Tag != null && child.Tag.Equals(tlp.Tag))
                {
                    child.Focus();
                    break;
                }
            }
        }

        // Événement de modification de texte dans une TextBox
        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = textBox.Text.ToUpper(); // Convertit le texte en majuscules

            foreach (TextBox txt in textBoxes)
            {
                // Vérifie si la touche est déjà assignée à une autre TextBox
                if (textBox.Text == txt.Text && textBox != txt && textBox.Text.Length != 0)
                {
                    DialogResult result = MessageBox.Show("Cette touche est déjà assignée", "Voulez vous continuer ?", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                        txt.Text = ""; // Efface le texte de l'autre TextBox
                    else if (result == DialogResult.No)
                        textBox.Text = ""; // Efface le texte de la TextBox actuelle
                }
            }
        }

        // Validation du texte dans une TextBox
        private void txt_Validated(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string key = textBox.Tag.ToString(); // Clé correspondant à la valeur dans les paramètres de configuration
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = textBox.Text; // Met à jour la valeur dans les paramètres de configuration
            config.Save(ConfigurationSaveMode.Modified); // Enregistre les modifications
            ConfigurationManager.RefreshSection("appSettings"); // Rafraîchit la section des paramètres de configuration
        }

        // Fermeture du formulaire
        private void FormMenuTouches_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked == true)
                formMenuOptions.Show(); // Affiche le formulaire des options si le bouton "Retour" a été cliqué
            else
                formMenuPrincipal.Close(); // Ferme le formulaire principal si le bouton "Retour" n'a pas été cliqué
        }
    }
}
