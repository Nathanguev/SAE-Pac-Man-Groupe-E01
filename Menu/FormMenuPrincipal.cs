using Interface_PacMan;

namespace Menu
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FormMenuPrincipal_SizeChanged(object sender, EventArgs e)
        {
            float fontHeight = btnContinuer.Size.Height / 5;

            btnContinuer.Font = new Font(btnContinuer.Font.FontFamily, fontHeight, FontStyle.Bold);
            btnNouvellePartie.Font = new Font(btnNouvellePartie.Font.FontFamily, fontHeight, FontStyle.Bold);
            btnOptions.Font = new Font(btnOptions.Font.FontFamily, fontHeight, FontStyle.Bold);
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
        }

        private async void btnOptions_Click(object sender, EventArgs e)
        {
            FormMenuOptions menuOptions = new FormMenuOptions();
            menuOptions.Show();

            // await Task.Delay(1000);
            // this.Close();
        }
    }
}
