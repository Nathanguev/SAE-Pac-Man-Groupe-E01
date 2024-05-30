using Bibliotheque_PacMan;
using BibliothequePacMan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_PacMan
{
    public partial class FormPartie : Form
    {
        /* ---------------- Variables globales ---------------- */

        private Partie partie;
        private Labyrinthe labyrinthe;
        private TableLayoutPanel tlpLabyrinthe;
        private PictureBox pacMan;

        /* ---------------- Constructeur FormPartie ---------------- */

        public FormPartie(Partie partie)
        {
            InitializeComponent();
            this.partie = partie;

            labyrinthe = new Labyrinthe(partie.hauteur, partie.largeur);
            labyrinthe.setSeed(partie.seed);
            labyrinthe.algoParcoursProfondeur();
        }

        /* ---------------- Au lancement du formulaire ---------------- */

        private void FormPartie_Load(object sender, EventArgs e)
        {
            tlpLabyrinthe = new TableLayoutPanel();
            Init_TableLayoutPanel(tlpLabyrinthe);
            panelLabyrinthe.Controls.Add(tlpLabyrinthe);

            affichageLabyrinthe();
            Init_PacMan(panelLabyrinthe);
        }

        /* ---------------- Fonctions d'initialisation ---------------- */

        private void Init_PacMan(Panel panel)
        {
            pacMan = new PictureBox();
            pacMan.Size = new Size(46, 46);
            pacMan.Image = Properties.Resources.pacMan;
            pacMan.SizeMode = PictureBoxSizeMode.Zoom;
            pacMan.Location = new Point(52, 52);
            pacMan.BackColor = Color.Transparent;

            panel.Controls.Add(pacMan);
            pacMan.BringToFront();
        }

        private void Init_TableLayoutPanel(TableLayoutPanel tlp)
        {
            tlp.RowCount = partie.hauteur;
            tlp.ColumnCount = partie.largeur;
            tlp.Margin = new Padding(0);
            tlp.Location = new Point(0, 0);
            tlp.AutoSize = true;

            tlp.ColumnStyles.Clear();
            tlp.RowStyles.Clear();
            for (int i = 0; i < tlp.RowCount; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            }
            for (int i = 0; i < tlp.ColumnCount; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            }
        }

        /* ---------------- Déplacement de PacMan ---------------- */

        private async void FormPartie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.ToUpper(e.KeyChar) == partie.toucheHaut)
            {
                if (pacMan.Location.Y > 2)
                {
                    pacMan.Location = new Point(pacMan.Location.X, pacMan.Location.Y - 50);
                }
            }
            else if (char.ToUpper(e.KeyChar) == partie.toucheBas)
            {
                if (pacMan.Location.Y < partie.hauteur * 50 - 52)
                {
                    pacMan.Location = new Point(pacMan.Location.X, pacMan.Location.Y + 50);
                }
            }
            else if (char.ToUpper(e.KeyChar) == partie.toucheGauche)
            {
                if (pacMan.Location.X > 2)
                {
                    pacMan.Location = new Point(pacMan.Location.X - 50, pacMan.Location.Y);
                }
            }
            else if (char.ToUpper(e.KeyChar) == partie.toucheDroite)
            {
                if (pacMan.Location.X < partie.largeur * 50 - 52)
                {
                    pacMan.Location = new Point(pacMan.Location.X + 50, pacMan.Location.Y);
                }
            }
        }

        /* ---------------- Binaire ---------------- */

        public string binaireConvert(UneCellule currentCellule, int index, int mode)
        {
            switch (mode)
            {
                case 1:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1111";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1110";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1101";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1100";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1011";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1010";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1001";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1000";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0111";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0110";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0101";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0100";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0011";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0010";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0001";
                    }
                    else
                    {
                        return "0000"; // haut, bas, gauche, droite
                    }

                case 2:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0111";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0110";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0101";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0100";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0011";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0010";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0001";
                    }
                    else
                    {
                        return "0000"; // haut, bas, gauche, droite
                    }

                case 3:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1011";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1010";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1001";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1000";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0011";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0010";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0001";
                    }
                    else
                    {
                        return "0000"; // haut, bas, gauche, droite
                    }

                case 4:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1101";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1100";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1001";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "1000";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0101";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0100";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + 1]))
                    {
                        return "0001";
                    }
                    else
                    {
                        return "0000"; // haut, bas, gauche, droite
                    }

                case 5:
                    if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "1110";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "1100";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "1010";
                    }
                    else if (currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "1000";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "0110";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "0100";
                    }
                    else if (!currentCellule.isLien(labyrinthe.getCellules()[index - partie.largeur]) && !currentCellule.isLien(labyrinthe.getCellules()[index + partie.largeur]) && currentCellule.isLien(labyrinthe.getCellules()[index - 1]))
                    {
                        return "0010";
                    }
                    else
                    {
                        return "0000"; // haut, bas, gauche, droite
                    }

                default:
                    return "0000";
            }
        }
        
        /* ---------------- Affichage ---------------- */

        private void affichageLabyrinthe()
        {
            int index = 0;
            UneCellule currentCellule;

            for (int i = 0; i < partie.hauteur; i++)
            {
                for (int j = 0; j < partie.largeur; j++)
                {
                    CaseLabyrinthe caseLabyrinthe = new CaseLabyrinthe(tlpLabyrinthe);
                    currentCellule = labyrinthe.getCellules()[index];

                    if (currentCellule.getVoisins().Count == 4)
                    {
                        if (binaireConvert(currentCellule, index, 1) == "1110")
                        {
                            caseLabyrinthe.Image = Properties.Resources.droite;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "1101")
                        {
                            caseLabyrinthe.Image = Properties.Resources.gauche;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "1011")
                        {
                            caseLabyrinthe.Image = Properties.Resources.bas;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "0111")
                        {
                            caseLabyrinthe.Image = Properties.Resources.haut;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "1100")
                        {
                            caseLabyrinthe.Image = Properties.Resources.gauche_droite;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "1001")
                        {
                            caseLabyrinthe.Image = Properties.Resources.angle_bas_gauche;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "0011")
                        {
                            caseLabyrinthe.Image = Properties.Resources.haut_bas;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "0110")
                        {
                            caseLabyrinthe.Image = Properties.Resources.angle_haut_droite;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "1010")
                        {
                            caseLabyrinthe.Image = Properties.Resources.angle_bas_droite;
                        }
                        else if (binaireConvert(currentCellule, index, 1) == "0101")
                        {
                            caseLabyrinthe.Image = Properties.Resources.angle_haut_gauche;
                        }
                        else
                        {
                            
                        }
                    }
                    else if (currentCellule.getVoisins().Count == 3)
                    {
                        if (i == 0)
                        {
                            if (binaireConvert(currentCellule, index, 2) == "0111")
                            {
                                caseLabyrinthe.Image = Properties.Resources.haut;
                            }
                            else if (binaireConvert(currentCellule, index, 2) == "0011")
                            {
                                caseLabyrinthe.Image = Properties.Resources.haut_bas;
                            }
                            else if (binaireConvert(currentCellule, index, 2) == "0110")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_droite;
                            }
                            else if (binaireConvert(currentCellule, index, 2) == "0101")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_gauche;
                            }
                            else
                            {

                            }
                        }
                        else if (i == partie.hauteur - 1)
                        {
                            if (binaireConvert(currentCellule, index, 3) == "1011")
                            {
                                caseLabyrinthe.Image = Properties.Resources.bas;
                            }
                            else if (binaireConvert(currentCellule, index, 3) == "1001")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_gauche;
                            }
                            else if (binaireConvert(currentCellule, index, 3) == "0011")
                            {
                                caseLabyrinthe.Image = Properties.Resources.haut_bas;
                            }
                            else if (binaireConvert(currentCellule, index, 3) == "1010")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_droite;
                            }
                            else
                            {

                            }
                        }
                        else if (j == 0)
                        {
                            if (binaireConvert(currentCellule, index, 4) == "1101")
                            {
                                caseLabyrinthe.Image = Properties.Resources.gauche;
                            }
                            else if (binaireConvert(currentCellule, index, 4) == "1100")
                            {
                                caseLabyrinthe.Image = Properties.Resources.gauche_droite;
                            }
                            else if (binaireConvert(currentCellule, index, 4) == "1001")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_gauche;
                            }
                            else if (binaireConvert(currentCellule, index, 4) == "0101")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_gauche;
                            }
                            else
                            {

                            }
                        }
                        else
                        {
                            if (binaireConvert(currentCellule, index, 5) == "1110")
                            {
                                caseLabyrinthe.Image = Properties.Resources.droite;
                            }
                            else if (binaireConvert(currentCellule, index, 5) == "1100")
                            {
                                caseLabyrinthe.Image = Properties.Resources.gauche_droite;
                            }
                            else if (binaireConvert(currentCellule, index, 5) == "0110")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_droite;
                            }
                            else if (binaireConvert(currentCellule, index, 5) == "1010")
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_droite;
                            }
                            else
                            {

                            }
                        }
                    }
                    else
                    {
                        if (i == 0)
                        {
                            if (j == 0)
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_gauche;
                            }
                            else
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_haut_droite;
                            }
                        }
                        else
                        {
                            if (j == 0)
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_gauche;
                            }
                            else
                            {
                                caseLabyrinthe.Image = Properties.Resources.angle_bas_droite;
                            }
                        }
                    }
                    index++;
                }
            }
        }
    }
}
