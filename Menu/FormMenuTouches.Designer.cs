namespace Interface_PacMan
{
    partial class FormMenuTouches
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
            roundTableLayoutPanel1 = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            roundTableLayoutPanel2 = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            txtHaut = new TextBox();
            lblHaut = new Label();
            roundTableLayoutPanel5 = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            roundTableLayoutPanel6 = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            txtGauche = new TextBox();
            lblGauche = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            roundTableLayoutPanel3 = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            roundTableLayoutPanel4 = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            txtBas = new TextBox();
            lblBas = new Label();
            roundTableLayoutPanel7 = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            roundTableLayoutPanel8 = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            txtDroite = new TextBox();
            lblDroite = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            roundTableLayoutPanel1.SuspendLayout();
            roundTableLayoutPanel2.SuspendLayout();
            roundTableLayoutPanel5.SuspendLayout();
            roundTableLayoutPanel6.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            roundTableLayoutPanel3.SuspendLayout();
            roundTableLayoutPanel4.SuspendLayout();
            roundTableLayoutPanel7.SuspendLayout();
            roundTableLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
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
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel2.Controls.Add(btnRetour, 1, 1);
            tableLayoutPanel2.Controls.Add(roundTableLayoutPanel1, 3, 1);
            tableLayoutPanel2.Controls.Add(roundTableLayoutPanel5, 5, 1);
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
            btnRetour.BorderColor = Color.Transparent;
            btnRetour.BorderRadius = 29;
            btnRetour.BorderWidth = 0;
            btnRetour.Dock = DockStyle.Fill;
            btnRetour.FlatAppearance.BorderSize = 0;
            btnRetour.FlatStyle = FlatStyle.Flat;
            btnRetour.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
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
            // roundTableLayoutPanel1
            // 
            roundTableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            roundTableLayoutPanel1.BorderColor = Color.Transparent;
            roundTableLayoutPanel1.BorderRadius = 31;
            roundTableLayoutPanel1.BorderWidth = 0;
            roundTableLayoutPanel1.ColumnCount = 4;
            roundTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            roundTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            roundTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            roundTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            roundTableLayoutPanel1.Controls.Add(roundTableLayoutPanel2, 2, 1);
            roundTableLayoutPanel1.Controls.Add(lblHaut, 1, 1);
            roundTableLayoutPanel1.Dock = DockStyle.Fill;
            roundTableLayoutPanel1.Location = new Point(265, 7);
            roundTableLayoutPanel1.Margin = new Padding(0);
            roundTableLayoutPanel1.Name = "roundTableLayoutPanel1";
            roundTableLayoutPanel1.RowCount = 3;
            roundTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            roundTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            roundTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            roundTableLayoutPanel1.Size = new Size(295, 62);
            roundTableLayoutPanel1.TabIndex = 1;
            // 
            // roundTableLayoutPanel2
            // 
            roundTableLayoutPanel2.BackColor = Color.White;
            roundTableLayoutPanel2.BorderColor = Color.Transparent;
            roundTableLayoutPanel2.BorderRadius = 21;
            roundTableLayoutPanel2.BorderWidth = 0;
            roundTableLayoutPanel2.ColumnCount = 1;
            roundTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            roundTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roundTableLayoutPanel2.Controls.Add(txtHaut, 0, 0);
            roundTableLayoutPanel2.Dock = DockStyle.Fill;
            roundTableLayoutPanel2.Location = new Point(176, 9);
            roundTableLayoutPanel2.Margin = new Padding(0);
            roundTableLayoutPanel2.Name = "roundTableLayoutPanel2";
            roundTableLayoutPanel2.RowCount = 1;
            roundTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            roundTableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            roundTableLayoutPanel2.Size = new Size(103, 43);
            roundTableLayoutPanel2.TabIndex = 0;
            roundTableLayoutPanel2.Tag = "ToucheHaut";
            roundTableLayoutPanel2.Click += tlp_Click;
            // 
            // txtHaut
            // 
            txtHaut.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHaut.BorderStyle = BorderStyle.None;
            txtHaut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtHaut.Location = new Point(0, 10);
            txtHaut.Margin = new Padding(0);
            txtHaut.MaxLength = 1;
            txtHaut.Name = "txtHaut";
            txtHaut.Size = new Size(103, 23);
            txtHaut.TabIndex = 0;
            txtHaut.Tag = "ToucheHaut";
            txtHaut.TextAlign = HorizontalAlignment.Center;
            txtHaut.TextChanged += txt_TextChanged;
            txtHaut.Validated += txt_Validated;
            // 
            // lblHaut
            // 
            lblHaut.AutoSize = true;
            lblHaut.Dock = DockStyle.Fill;
            lblHaut.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHaut.Location = new Point(14, 9);
            lblHaut.Margin = new Padding(0);
            lblHaut.Name = "lblHaut";
            lblHaut.Size = new Size(162, 43);
            lblHaut.TabIndex = 1;
            lblHaut.Text = "Haut";
            lblHaut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundTableLayoutPanel5
            // 
            roundTableLayoutPanel5.BackColor = Color.FromArgb(224, 224, 224);
            roundTableLayoutPanel5.BorderColor = Color.Transparent;
            roundTableLayoutPanel5.BorderRadius = 31;
            roundTableLayoutPanel5.BorderWidth = 0;
            roundTableLayoutPanel5.ColumnCount = 4;
            roundTableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            roundTableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            roundTableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            roundTableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            roundTableLayoutPanel5.Controls.Add(roundTableLayoutPanel6, 2, 1);
            roundTableLayoutPanel5.Controls.Add(lblGauche, 1, 1);
            roundTableLayoutPanel5.Dock = DockStyle.Fill;
            roundTableLayoutPanel5.Location = new Point(619, 7);
            roundTableLayoutPanel5.Margin = new Padding(0);
            roundTableLayoutPanel5.Name = "roundTableLayoutPanel5";
            roundTableLayoutPanel5.RowCount = 3;
            roundTableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            roundTableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            roundTableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            roundTableLayoutPanel5.Size = new Size(295, 62);
            roundTableLayoutPanel5.TabIndex = 2;
            // 
            // roundTableLayoutPanel6
            // 
            roundTableLayoutPanel6.BackColor = Color.White;
            roundTableLayoutPanel6.BorderColor = Color.Transparent;
            roundTableLayoutPanel6.BorderRadius = 21;
            roundTableLayoutPanel6.BorderWidth = 0;
            roundTableLayoutPanel6.ColumnCount = 1;
            roundTableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            roundTableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roundTableLayoutPanel6.Controls.Add(txtGauche, 0, 0);
            roundTableLayoutPanel6.Dock = DockStyle.Fill;
            roundTableLayoutPanel6.Location = new Point(176, 9);
            roundTableLayoutPanel6.Margin = new Padding(0);
            roundTableLayoutPanel6.Name = "roundTableLayoutPanel6";
            roundTableLayoutPanel6.RowCount = 1;
            roundTableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            roundTableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            roundTableLayoutPanel6.Size = new Size(103, 43);
            roundTableLayoutPanel6.TabIndex = 0;
            roundTableLayoutPanel6.Tag = "ToucheGauche";
            roundTableLayoutPanel6.Click += tlp_Click;
            // 
            // txtGauche
            // 
            txtGauche.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtGauche.BorderStyle = BorderStyle.None;
            txtGauche.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtGauche.Location = new Point(0, 10);
            txtGauche.Margin = new Padding(0);
            txtGauche.MaxLength = 1;
            txtGauche.Name = "txtGauche";
            txtGauche.Size = new Size(103, 23);
            txtGauche.TabIndex = 0;
            txtGauche.Tag = "ToucheGauche";
            txtGauche.TextAlign = HorizontalAlignment.Center;
            txtGauche.TextChanged += txt_TextChanged;
            txtGauche.Validated += txt_Validated;
            // 
            // lblGauche
            // 
            lblGauche.AutoSize = true;
            lblGauche.Dock = DockStyle.Fill;
            lblGauche.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGauche.Location = new Point(14, 9);
            lblGauche.Margin = new Padding(0);
            lblGauche.Name = "lblGauche";
            lblGauche.Size = new Size(162, 43);
            lblGauche.TabIndex = 1;
            lblGauche.Text = "Gauche";
            lblGauche.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel3.Controls.Add(roundTableLayoutPanel3, 1, 1);
            tableLayoutPanel3.Controls.Add(roundTableLayoutPanel7, 3, 1);
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
            // roundTableLayoutPanel3
            // 
            roundTableLayoutPanel3.BackColor = Color.FromArgb(224, 224, 224);
            roundTableLayoutPanel3.BorderColor = Color.Transparent;
            roundTableLayoutPanel3.BorderRadius = 31;
            roundTableLayoutPanel3.BorderWidth = 0;
            roundTableLayoutPanel3.ColumnCount = 4;
            roundTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            roundTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            roundTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            roundTableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            roundTableLayoutPanel3.Controls.Add(roundTableLayoutPanel4, 2, 1);
            roundTableLayoutPanel3.Controls.Add(lblBas, 1, 1);
            roundTableLayoutPanel3.Dock = DockStyle.Fill;
            roundTableLayoutPanel3.Location = new Point(265, 7);
            roundTableLayoutPanel3.Margin = new Padding(0);
            roundTableLayoutPanel3.Name = "roundTableLayoutPanel3";
            roundTableLayoutPanel3.RowCount = 3;
            roundTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            roundTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            roundTableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            roundTableLayoutPanel3.Size = new Size(295, 62);
            roundTableLayoutPanel3.TabIndex = 2;
            // 
            // roundTableLayoutPanel4
            // 
            roundTableLayoutPanel4.BackColor = Color.White;
            roundTableLayoutPanel4.BorderColor = Color.Transparent;
            roundTableLayoutPanel4.BorderRadius = 21;
            roundTableLayoutPanel4.BorderWidth = 0;
            roundTableLayoutPanel4.ColumnCount = 1;
            roundTableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            roundTableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roundTableLayoutPanel4.Controls.Add(txtBas, 0, 0);
            roundTableLayoutPanel4.Dock = DockStyle.Fill;
            roundTableLayoutPanel4.Location = new Point(176, 9);
            roundTableLayoutPanel4.Margin = new Padding(0);
            roundTableLayoutPanel4.Name = "roundTableLayoutPanel4";
            roundTableLayoutPanel4.RowCount = 1;
            roundTableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            roundTableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            roundTableLayoutPanel4.Size = new Size(103, 43);
            roundTableLayoutPanel4.TabIndex = 0;
            roundTableLayoutPanel4.Tag = "ToucheBas";
            roundTableLayoutPanel4.Click += tlp_Click;
            // 
            // txtBas
            // 
            txtBas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtBas.BorderStyle = BorderStyle.None;
            txtBas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtBas.Location = new Point(0, 10);
            txtBas.Margin = new Padding(0);
            txtBas.MaxLength = 1;
            txtBas.Name = "txtBas";
            txtBas.Size = new Size(103, 23);
            txtBas.TabIndex = 0;
            txtBas.Tag = "ToucheBas";
            txtBas.TextAlign = HorizontalAlignment.Center;
            txtBas.TextChanged += txt_TextChanged;
            txtBas.Validated += txt_Validated;
            // 
            // lblBas
            // 
            lblBas.AutoSize = true;
            lblBas.Dock = DockStyle.Fill;
            lblBas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBas.Location = new Point(14, 9);
            lblBas.Margin = new Padding(0);
            lblBas.Name = "lblBas";
            lblBas.Size = new Size(162, 43);
            lblBas.TabIndex = 1;
            lblBas.Text = "Bas";
            lblBas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // roundTableLayoutPanel7
            // 
            roundTableLayoutPanel7.BackColor = Color.FromArgb(224, 224, 224);
            roundTableLayoutPanel7.BorderColor = Color.Transparent;
            roundTableLayoutPanel7.BorderRadius = 31;
            roundTableLayoutPanel7.BorderWidth = 0;
            roundTableLayoutPanel7.ColumnCount = 4;
            roundTableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            roundTableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            roundTableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            roundTableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            roundTableLayoutPanel7.Controls.Add(roundTableLayoutPanel8, 2, 1);
            roundTableLayoutPanel7.Controls.Add(lblDroite, 1, 1);
            roundTableLayoutPanel7.Dock = DockStyle.Fill;
            roundTableLayoutPanel7.Location = new Point(619, 7);
            roundTableLayoutPanel7.Margin = new Padding(0);
            roundTableLayoutPanel7.Name = "roundTableLayoutPanel7";
            roundTableLayoutPanel7.RowCount = 3;
            roundTableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            roundTableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            roundTableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            roundTableLayoutPanel7.Size = new Size(295, 62);
            roundTableLayoutPanel7.TabIndex = 3;
            // 
            // roundTableLayoutPanel8
            // 
            roundTableLayoutPanel8.BackColor = Color.White;
            roundTableLayoutPanel8.BorderColor = Color.Transparent;
            roundTableLayoutPanel8.BorderRadius = 21;
            roundTableLayoutPanel8.BorderWidth = 0;
            roundTableLayoutPanel8.ColumnCount = 1;
            roundTableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            roundTableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            roundTableLayoutPanel8.Controls.Add(txtDroite, 0, 0);
            roundTableLayoutPanel8.Dock = DockStyle.Fill;
            roundTableLayoutPanel8.Location = new Point(176, 9);
            roundTableLayoutPanel8.Margin = new Padding(0);
            roundTableLayoutPanel8.Name = "roundTableLayoutPanel8";
            roundTableLayoutPanel8.RowCount = 1;
            roundTableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            roundTableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            roundTableLayoutPanel8.Size = new Size(103, 43);
            roundTableLayoutPanel8.TabIndex = 0;
            roundTableLayoutPanel8.Tag = "ToucheDroite";
            roundTableLayoutPanel8.Click += tlp_Click;
            // 
            // txtDroite
            // 
            txtDroite.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDroite.BorderStyle = BorderStyle.None;
            txtDroite.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtDroite.Location = new Point(0, 10);
            txtDroite.Margin = new Padding(0);
            txtDroite.MaxLength = 1;
            txtDroite.Name = "txtDroite";
            txtDroite.Size = new Size(103, 23);
            txtDroite.TabIndex = 0;
            txtDroite.Tag = "ToucheDroite";
            txtDroite.TextAlign = HorizontalAlignment.Center;
            txtDroite.TextChanged += txt_TextChanged;
            txtDroite.Validated += txt_Validated;
            // 
            // lblDroite
            // 
            lblDroite.AutoSize = true;
            lblDroite.Dock = DockStyle.Fill;
            lblDroite.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDroite.Location = new Point(14, 9);
            lblDroite.Margin = new Padding(0);
            lblDroite.Name = "lblDroite";
            lblDroite.Size = new Size(162, 43);
            lblDroite.TabIndex = 1;
            lblDroite.Text = "Droite";
            lblDroite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMenuTouches
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(960, 540);
            Name = "FormMenuTouches";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Touches";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMenuTouches_FormClosing;
            Load += FormMenuTouches_Load;
            SizeChanged += FormMenuTouches_SizeChanged;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            roundTableLayoutPanel1.ResumeLayout(false);
            roundTableLayoutPanel1.PerformLayout();
            roundTableLayoutPanel2.ResumeLayout(false);
            roundTableLayoutPanel2.PerformLayout();
            roundTableLayoutPanel5.ResumeLayout(false);
            roundTableLayoutPanel5.PerformLayout();
            roundTableLayoutPanel6.ResumeLayout(false);
            roundTableLayoutPanel6.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            roundTableLayoutPanel3.ResumeLayout(false);
            roundTableLayoutPanel3.PerformLayout();
            roundTableLayoutPanel4.ResumeLayout(false);
            roundTableLayoutPanel4.PerformLayout();
            roundTableLayoutPanel7.ResumeLayout(false);
            roundTableLayoutPanel7.PerformLayout();
            roundTableLayoutPanel8.ResumeLayout(false);
            roundTableLayoutPanel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Bibliotheque_PacMan.RoundButton btnRetour;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel1;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel2;
        private TextBox txtHaut;
        private Label lblHaut;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel5;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel6;
        private TextBox txtGauche;
        private Label lblGauche;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel3;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel4;
        private TextBox txtBas;
        private Label lblBas;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel7;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel8;
        private TextBox txtDroite;
        private Label lblDroite;
    }
}