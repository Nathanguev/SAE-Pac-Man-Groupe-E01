using Menu;

namespace Interface_PacMan
{
    public partial class FormMenuOptions : Form
    {
        private FormMenuPrincipal formMenuPrincipal;
        private FormMenuPause formMenuPause;
        private bool isBtnRetourClicked = false;

        public FormMenuOptions(FormMenuPrincipal formMenuPrincipal)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            formMenuPause = null;
        }

        public FormMenuOptions(FormMenuPrincipal formMenuPrincipal, FormMenuPause formMenuPause)
        {
            InitializeComponent();
            this.formMenuPrincipal = formMenuPrincipal;
            this.formMenuPause = formMenuPause;
        }

        public void FormMenuOptions_SizeChanged(object sender, EventArgs e)
        {
            Utils.Txt_AutoSize(this);
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

        private void btnRetour_Click(object sender, EventArgs e)
        {
            isBtnRetourClicked = true;
            this.Close();
        }

        private void btnTouches_Click(object sender, EventArgs e)
        {
            FormMenuTouches formMenuTouches = new FormMenuTouches(formMenuPrincipal, this);
            formMenuTouches.Show();
            this.Hide();
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            FormMenuVolume menuVolume = new FormMenuVolume(formMenuPrincipal, this);
            menuVolume.Show();
            this.Hide();
        }

        private void FormMenuOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isBtnRetourClicked == true)
            {
                if (formMenuPause != null)
                {
                    formMenuPause.Show();
                }
                else
                {
                    formMenuPrincipal.Show();
                }
            }
            else
            {
                formMenuPrincipal.Close();
            }
        }

        private void FormMenuOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
