using Interface_PacMan;
using BibliothequePacMan;

namespace Menu
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
            FormManager.FormClosing += FormManager_FormClosing;
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
            MessageBox.Show("Continuer");
        }

        private void btnNouvellePartie_Click(object sender, EventArgs e)
        {
            FormMenuPseudo menuPseudo = new FormMenuPseudo();
            menuPseudo.Show();
            this.Hide();
        }

        private async void btnOptions_Click(object sender, EventArgs e)
        {
            FormMenuOptions menuOptions = new FormMenuOptions();
            menuOptions.Show();
            this.Hide();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
