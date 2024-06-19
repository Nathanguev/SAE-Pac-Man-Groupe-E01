using Bibliotheque_PacMan;
using BibliothequePacMan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_PacMan
{
    public static class Utils
    {
        /* ----------------- Méthode de changement de couleur au survol ----------------- */

        // Cette fonction change la couleur de fond d'un composant Button ou RoundButton
        // (car RoundButton hérite de Button) au survol de ce composant par la souris.
        public static void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightBlue;
        }

        public static void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(224, 224, 224);
        }

        /* ----------------- Méthode de redimensionnement du texte ----------------- */

        // Cette fonction redimensionne le texte d'un composant en fonction de sa hauteur
        // pour les éléments suivants : Label, RoundLabel, Button, RoundButton.
        public static void Txt_AutoSize(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Label || control is RoundLabel || control is Button || control is RoundButton)
                {
                    float fontHeight = control.Height / 5.0f;
                    if (fontHeight >= 1)
                    {
                        control.Font = new Font(control.Font.FontFamily, fontHeight, FontStyle.Bold);
                    }
                }
                else if (control is TextBox)
                {
                    float fontHeight = control.Parent.Height / 4.0f;
                    {
                        control.Font = new Font(control.Font.FontFamily, fontHeight, FontStyle.Bold);
                    }
                }

                if (control.HasChildren)
                    Txt_AutoSize(control);
            }
        }

        public static void Txt_AutoSize(Control parent, float height)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Label || control is TextBox)
                {
                    float fontHeight = parent.Height / height;
                    {
                        control.Font = new Font(control.Font.FontFamily, fontHeight, FontStyle.Bold);
                    }
                }

                if (control.HasChildren)
                    Txt_AutoSize(control);
            }
        }

        /* ----------------- Méthode de convertion binaire ----------------- */

        // Cette fonction permet de vérifier toutes les conditions possibles
        // pour la position des murs du labyrinthe et retourne un octet binaire.

        // Les positions sont : haut, bas, gauche, droite

        // 0 : il y a un mur
        // 1 : il n'y a pas de mur (il y a une porte)

        public static string BinaireConvert(UneCellule currentCellule, int index, int mode, Labyrinthe labyrinthe, Partie partie)
        {
            switch (mode)
            {
                case 1:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1111";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1110";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1101";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1100";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1011";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1010";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1001";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1000";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0111";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0110";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0101";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0100";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0011";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0010";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0001";
                    else
                        return "0000"; // Case vide

                case 2:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0111";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0110";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0101";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0100";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0011";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0010";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0001";
                    else
                        return "0000"; // Case vide

                case 3:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1011";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1010";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1001";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1000";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0011";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0010";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0001";
                    else
                        return "0000"; // Case vide

                case 4:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1101";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1100";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1001";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "1000";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0101";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0100";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                        return "0001";
                    else
                        return "0000"; // Case vide

                case 5:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                        return "1110";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                        return "1100";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                        return "1010";
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                        return "1000";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                        return "0110";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                        return "0100";
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.Largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.Largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                        return "0010";
                    else
                        return "0000"; // Case vide

                default:
                    return "0000"; // Case vide
            }
        }
    }
}
