namespace Interface_PacMan
{
    partial class FormMenuParametre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnRetour = new Bibliotheque_PacMan.RoundButton();
            btnCouleur = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnDifficulte = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnBonus = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnJouer = new Bibliotheque_PacMan.RoundButton();
            panelFondEcran = new Panel();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panelFondEcran.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(1182, 628);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(30, 30);
            pictureBox1.Margin = new Padding(30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1122, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel2.Controls.Add(btnRetour, 1, 1);
            tableLayoutPanel2.Controls.Add(btnCouleur, 3, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 314);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(1182, 78);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(224, 224, 224);
            btnRetour.BorderColor = Color.Gold;
            btnRetour.BorderRadius = 29;
            btnRetour.BorderWidth = 0;
            btnRetour.Dock = DockStyle.Fill;
            btnRetour.FlatAppearance.BorderSize = 0;
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRetour.HexaColor = "";
            btnRetour.Image = Properties.Resources.fleche1;
            btnRetour.Location = new Point(118, 7);
            btnRetour.Margin = new Padding(0);
            btnRetour.Name = "btnRetour";
            btnRetour.Rounded = true;
            btnRetour.Size = new Size(59, 62);
            btnRetour.TabIndex = 0;
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            btnRetour.MouseEnter += btn_MouseEnter;
            btnRetour.MouseLeave += btn_MouseLeave;
            // 
            // btnCouleur
            // 
            btnCouleur.BackColor = Color.FromArgb(224, 224, 224);
            btnCouleur.BorderColor = Color.Transparent;
            btnCouleur.BorderRadius = 31;
            btnCouleur.BorderWidth = 0;
            btnCouleur.Dock = DockStyle.Fill;
            btnCouleur.FlatAppearance.BorderSize = 0;
            btnCouleur.FlatStyle = FlatStyle.Flat;
            btnCouleur.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCouleur.HexaColor = "";
            btnCouleur.Location = new Point(442, 7);
            btnCouleur.Margin = new Padding(0);
            btnCouleur.Name = "btnCouleur";
            btnCouleur.Rounded = true;
            btnCouleur.Size = new Size(295, 62);
            btnCouleur.TabIndex = 1;
            btnCouleur.Text = "Couleur Pac-Man";
            btnCouleur.UseVisualStyleBackColor = false;
            btnCouleur.Click += btnCouleur_Click;
            btnCouleur.MouseEnter += btn_MouseEnter;
            btnCouleur.MouseLeave += btn_MouseLeave;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel3.Controls.Add(btnDifficulte, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 392);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Size = new Size(1182, 78);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // btnDifficulte
            // 
            btnDifficulte.BackColor = Color.FromArgb(224, 224, 224);
            btnDifficulte.BorderColor = Color.Transparent;
            btnDifficulte.BorderRadius = 31;
            btnDifficulte.BorderWidth = 0;
            btnDifficulte.Dock = DockStyle.Fill;
            btnDifficulte.FlatAppearance.BorderSize = 0;
            btnDifficulte.FlatStyle = FlatStyle.Flat;
            btnDifficulte.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDifficulte.HexaColor = "";
            btnDifficulte.Location = new Point(443, 7);
            btnDifficulte.Margin = new Padding(0);
            btnDifficulte.Name = "btnDifficulte";
            btnDifficulte.Rounded = true;
            btnDifficulte.Size = new Size(295, 62);
            btnDifficulte.TabIndex = 0;
            btnDifficulte.Text = "Difficulté";
            btnDifficulte.UseVisualStyleBackColor = false;
            btnDifficulte.Click += btnDifficulte_Click;
            btnDifficulte.MouseEnter += btn_MouseEnter;
            btnDifficulte.MouseLeave += btn_MouseLeave;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel4.Controls.Add(btnBonus, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 470);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Size = new Size(1182, 78);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // btnBonus
            // 
            btnBonus.BackColor = Color.FromArgb(224, 224, 224);
            btnBonus.BorderColor = Color.Transparent;
            btnBonus.BorderRadius = 31;
            btnBonus.BorderWidth = 0;
            btnBonus.Dock = DockStyle.Fill;
            btnBonus.FlatAppearance.BorderSize = 0;
            btnBonus.FlatStyle = FlatStyle.Flat;
            btnBonus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBonus.HexaColor = "";
            btnBonus.Location = new Point(443, 7);
            btnBonus.Margin = new Padding(0);
            btnBonus.Name = "btnBonus";
            btnBonus.Rounded = true;
            btnBonus.Size = new Size(295, 62);
            btnBonus.TabIndex = 0;
            btnBonus.Text = "Bonus";
            btnBonus.UseVisualStyleBackColor = false;
            btnBonus.Click += btnBonus_Click;
            btnBonus.MouseEnter += btn_MouseEnter;
            btnBonus.MouseLeave += btn_MouseLeave;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel5.Controls.Add(btnJouer, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 548);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.Size = new Size(1182, 80);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // btnJouer
            // 
            btnJouer.BackColor = Color.FromArgb(224, 224, 224);
            btnJouer.BorderColor = Color.Transparent;
            btnJouer.BorderRadius = 32;
            btnJouer.BorderWidth = 0;
            btnJouer.Dock = DockStyle.Fill;
            btnJouer.FlatAppearance.BorderSize = 0;
            btnJouer.FlatStyle = FlatStyle.Flat;
            btnJouer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnJouer.HexaColor = "";
            btnJouer.Location = new Point(443, 8);
            btnJouer.Margin = new Padding(0);
            btnJouer.Name = "btnJouer";
            btnJouer.Rounded = true;
            btnJouer.Size = new Size(295, 64);
            btnJouer.TabIndex = 0;
            btnJouer.Text = "JOUER";
            btnJouer.UseVisualStyleBackColor = false;
            btnJouer.Click += btnJouer_Click;
            btnJouer.MouseEnter += btn_MouseEnter;
            btnJouer.MouseLeave += btn_MouseLeave;
            // 
            // panelFondEcran
            // 
            panelFondEcran.Controls.Add(tableLayoutPanel1);
            panelFondEcran.Dock = DockStyle.Fill;
            panelFondEcran.Location = new Point(0, 0);
            panelFondEcran.Margin = new Padding(0);
            panelFondEcran.Name = "panelFondEcran";
            panelFondEcran.Size = new Size(1182, 628);
            panelFondEcran.TabIndex = 1;
            // 
            // FormMenuParametre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(panelFondEcran);
            MinimumSize = new Size(960, 540);
            Name = "FormMenuParametre";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Paramètre";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMenuParametre_FormClosing;
            SizeChanged += FormMenuParametre_SizeChanged;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panelFondEcran.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panelFondEcran;
        private TableLayoutPanel tableLayoutPanel5;
        private Bibliotheque_PacMan.RoundButton btnRetour;
        private Bibliotheque_PacMan.RoundButton btnCouleur;
        private Bibliotheque_PacMan.RoundButton btnDifficulte;
        private Bibliotheque_PacMan.RoundButton btnBonus;
        private Bibliotheque_PacMan.RoundButton btnJouer;
    }
}