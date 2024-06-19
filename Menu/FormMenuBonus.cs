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
        private FormMenuParametre formMenuParametre;
        private bool isBtnRetourClicked = false;

        public FormMenuBonus(FormMenuParametre formMenuParametre)
        {
            InitializeComponent();
            this.formMenuParametre = formMenuParametre;
        }

        private void FormMenuBonus_Load(object sender, EventArgs e)
        {
            Verif_Bonus();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true;
            this.Close();
        }

        private void FormMenuBonus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked == true)
            {
                formMenuParametre.Show();
            }
            else
            {
                formMenuParametre.Close();
            }
        }

        private void FormMenuBonus_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this, 6.0f);
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightBlue;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Tag == "retour")
                btn.BackColor = Color.FromArgb(224, 224, 224);
            else
                btn.BackColor = Color.White;
        }

        private void Verif_Bonus()
        {
            RoundButton[] buttons = { btnVie, btnVitesse, btnTemps, btnScore };
            foreach (RoundButton btn in buttons)
            {
                if (formMenuParametre.bonus[Convert.ToInt32(btn.Tag)])
                {
                    btn.Text = "ON";
                    btn.BorderWidth = 15;
                    btn.BorderColor = Color.DeepSkyBlue;
                }
                else
                {
                    btn.Text = "OFF";
                    btn.BorderWidth = 0;
                    btn.BorderColor = Color.Transparent;
                }
            }
        }

        private void btn_BonusClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "ON")
            {
                btn.Text = "OFF";
                formMenuParametre.bonus[Convert.ToInt32(btn.Tag)] = false;
            }
            else
            {
                btn.Text = "ON";
                formMenuParametre.bonus[Convert.ToInt32(btn.Tag)] = true;
            }
            Verif_Bonus();
        }
    }
}
