using Bibliotheque_PacMan;
using BibliothequePacMan;
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
    public partial class FormMenuBonus : Form
    {
        private FormMenuParametre formMenuParametre; // Référence vers le formulaire FormMenuParametre
        private bool isBtnRetourClicked = false; // Indique si le bouton "Retour" a été cliqué

        /* ----------------- Constructeur de la classe FormMenuBonus ----------------- */

        // Constructeur prenant en paramètre la référence vers le formulaire FormMenuParametre
        public FormMenuBonus(FormMenuParametre formMenuParametre)
        {
            InitializeComponent();
            this.formMenuParametre = formMenuParametre;
        }

        /* ----------------- Gestionnaire d'événement WinForms ----------------- */

        // Chargement du formulaire
        private void FormMenuBonus_Load(object sender, EventArgs e)
        {
            Verif_Bonus(); // Vérifie et met à jour l'état des boutons de bonus
        }

        // Clic sur le bouton "Retour"
        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true; // Indique que le bouton "Retour" a été cliqué
            this.Close(); // Ferme le formulaire actuel
        }

        // Fermeture du formulaire
        private void FormMenuBonus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked == true)
                formMenuParametre.Show(); // Affiche le formulaire FormMenuParametre si le bouton "Retour" a été cliqué
            else
                formMenuParametre.Close(); // Ferme le formulaire FormMenuParametre si le bouton "Retour" n'a pas été cliqué
        }

        // Redimensionnement du formulaire
        private void FormMenuBonus_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this, 6.0f);
        }

        // Survole de souris sur un bouton
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Utils.btn_MouseEnter(sender, e);
        }

        // Sortie de souris d'un bouton
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Tag == "retour")
                btn.BackColor = Color.FromArgb(224, 224, 224); // Couleur de fond grise claire pour le bouton "Retour"
            else
                btn.BackColor = Color.White; // Couleur de fond blanche pour les autres boutons
        }

        // Clic sur un des boutons de bonus
        private void btn_BonusClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "ON")
            {
                btn.Text = "OFF"; // Désactive le bonus correspondant
                formMenuParametre.bonus[Convert.ToInt32(btn.Tag)] = false;
            }
            else
            {
                btn.Text = "ON"; // Active le bonus correspondant
                formMenuParametre.bonus[Convert.ToInt32(btn.Tag)] = true;
            }
            Verif_Bonus(); // Vérifie et met à jour l'état des boutons de bonus
        }

        /* ----------------- Fonction supplémentaire ----------------- */

        // Vérifie et met à jour l'état des boutons de bonus
        private void Verif_Bonus()
        {
            RoundButton[] buttons = { btnVie, btnVitesse, btnTemps, btnScore }; // Tableau des boutons de bonus
            foreach (RoundButton btn in buttons)
            {
                if (formMenuParametre.bonus[Convert.ToInt32(btn.Tag)])
                {
                    btn.Text = "ON"; // Affiche "ON" si le bonus est activé
                    btn.BorderWidth = 15; // Largeur de bordure augmentée pour indiquer la sélection
                    btn.BorderColor = Color.DeepSkyBlue; // Couleur de bordure modifiée pour indiquer la sélection
                }
                else
                {
                    btn.Text = "OFF"; // Affiche "OFF" si le bonus est désactivé
                    btn.BorderWidth = 0; // Aucune bordure pour les autres boutons
                    btn.BorderColor = Color.Transparent; // Bordure transparente pour les autres boutons
                }
            }
        }
    }
}
