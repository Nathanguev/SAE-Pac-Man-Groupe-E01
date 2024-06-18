namespace Interface_PacMan
{
    partial class FormMenuBonus
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
            tableLayoutPanel2 = new TableLayoutPanel();
            btnRetour = new Bibliotheque_PacMan.RoundButton();
            roundTableLayoutPanel1 = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            lblHaut = new Label();
            btnVie = new Bibliotheque_PacMan.RoundButton();
            roundTableLayoutPanel5 = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            lblGauche = new Label();
            btnVitesse = new Bibliotheque_PacMan.RoundButton();
            pictureBox1 = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            roundTableLayoutPanel3 = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            lblBas = new Label();
            btnTemps = new Bibliotheque_PacMan.RoundButton();
            roundTableLayoutPanel7 = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            lblDroite = new Label();
            btnScore = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            roundTableLayoutPanel1.SuspendLayout();
            roundTableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            roundTableLayoutPanel3.SuspendLayout();
            roundTableLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
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
            tableLayoutPanel2.TabIndex = 2;
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
            btnRetour.HexaColor = "";
            btnRetour.Image = Properties.Resources.fleche1;
            btnRetour.Location = new Point(118, 7);
            btnRetour.Margin = new Padding(0);
            btnRetour.Name = "btnRetour";
            btnRetour.Rounded = true;
            btnRetour.Size = new Size(59, 62);
            btnRetour.TabIndex = 0;
            btnRetour.Tag = "retour";
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
            roundTableLayoutPanel1.Controls.Add(lblHaut, 1, 1);
            roundTableLayoutPanel1.Controls.Add(btnVie, 2, 1);
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
            lblHaut.Text = "Bonus Vie +";
            lblHaut.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVie
            // 
            btnVie.BackColor = Color.White;
            btnVie.BorderColor = Color.Transparent;
            btnVie.BorderRadius = 20;
            btnVie.BorderWidth = 0;
            btnVie.Dock = DockStyle.Fill;
            btnVie.FlatAppearance.BorderSize = 0;
            btnVie.FlatStyle = FlatStyle.Flat;
            btnVie.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVie.HexaColor = "";
            btnVie.Location = new Point(177, 10);
            btnVie.Margin = new Padding(1);
            btnVie.Name = "btnVie";
            btnVie.Rounded = true;
            btnVie.Size = new Size(101, 41);
            btnVie.TabIndex = 2;
            btnVie.Tag = "0";
            btnVie.Text = "ON";
            btnVie.UseVisualStyleBackColor = false;
            btnVie.Click += btn_BonusClick;
            btnVie.MouseEnter += btn_MouseEnter;
            btnVie.MouseLeave += btn_MouseLeave;
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
            roundTableLayoutPanel5.Controls.Add(lblGauche, 1, 1);
            roundTableLayoutPanel5.Controls.Add(btnVitesse, 2, 1);
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
            lblGauche.Text = "Bonus Vitesse";
            lblGauche.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVitesse
            // 
            btnVitesse.BackColor = Color.White;
            btnVitesse.BorderColor = Color.Transparent;
            btnVitesse.BorderRadius = 20;
            btnVitesse.BorderWidth = 0;
            btnVitesse.Dock = DockStyle.Fill;
            btnVitesse.FlatAppearance.BorderSize = 0;
            btnVitesse.FlatStyle = FlatStyle.Flat;
            btnVitesse.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVitesse.HexaColor = "";
            btnVitesse.Location = new Point(177, 10);
            btnVitesse.Margin = new Padding(1);
            btnVitesse.Name = "btnVitesse";
            btnVitesse.Rounded = true;
            btnVitesse.Size = new Size(101, 41);
            btnVitesse.TabIndex = 2;
            btnVitesse.Tag = "1";
            btnVitesse.Text = "ON";
            btnVitesse.UseVisualStyleBackColor = false;
            btnVitesse.Click += btn_BonusClick;
            btnVitesse.MouseEnter += btn_MouseEnter;
            btnVitesse.MouseLeave += btn_MouseLeave;
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
            tableLayoutPanel3.TabIndex = 3;
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
            roundTableLayoutPanel3.Controls.Add(lblBas, 1, 1);
            roundTableLayoutPanel3.Controls.Add(btnTemps, 2, 1);
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
            lblBas.Text = "Bonus Temps +";
            lblBas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnTemps
            // 
            btnTemps.BackColor = Color.White;
            btnTemps.BorderColor = Color.Transparent;
            btnTemps.BorderRadius = 20;
            btnTemps.BorderWidth = 0;
            btnTemps.Dock = DockStyle.Fill;
            btnTemps.FlatAppearance.BorderSize = 0;
            btnTemps.FlatStyle = FlatStyle.Flat;
            btnTemps.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTemps.HexaColor = "";
            btnTemps.Location = new Point(177, 10);
            btnTemps.Margin = new Padding(1);
            btnTemps.Name = "btnTemps";
            btnTemps.Rounded = true;
            btnTemps.Size = new Size(101, 41);
            btnTemps.TabIndex = 2;
            btnTemps.Tag = "2";
            btnTemps.Text = "ON";
            btnTemps.UseVisualStyleBackColor = false;
            btnTemps.Click += btn_BonusClick;
            btnTemps.MouseEnter += btn_MouseEnter;
            btnTemps.MouseLeave += btn_MouseLeave;
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
            roundTableLayoutPanel7.Controls.Add(lblDroite, 1, 1);
            roundTableLayoutPanel7.Controls.Add(btnScore, 2, 1);
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
            lblDroite.Text = "Bonus Score";
            lblDroite.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnScore
            // 
            btnScore.BackColor = Color.White;
            btnScore.BorderColor = Color.Transparent;
            btnScore.BorderRadius = 20;
            btnScore.BorderWidth = 0;
            btnScore.Dock = DockStyle.Fill;
            btnScore.FlatAppearance.BorderSize = 0;
            btnScore.FlatStyle = FlatStyle.Flat;
            btnScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnScore.HexaColor = "";
            btnScore.Location = new Point(177, 10);
            btnScore.Margin = new Padding(1);
            btnScore.Name = "btnScore";
            btnScore.Rounded = true;
            btnScore.Size = new Size(101, 41);
            btnScore.TabIndex = 2;
            btnScore.Tag = "3";
            btnScore.Text = "ON";
            btnScore.UseVisualStyleBackColor = false;
            btnScore.Click += btn_BonusClick;
            btnScore.MouseEnter += btn_MouseEnter;
            btnScore.MouseLeave += btn_MouseLeave;
            // 
            // FormMenuBonus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(960, 540);
            Name = "FormMenuBonus";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Bonus";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMenuBonus_FormClosing;
            Load += FormMenuBonus_Load;
            SizeChanged += FormMenuBonus_SizeChanged;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            roundTableLayoutPanel1.ResumeLayout(false);
            roundTableLayoutPanel1.PerformLayout();
            roundTableLayoutPanel5.ResumeLayout(false);
            roundTableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            roundTableLayoutPanel3.ResumeLayout(false);
            roundTableLayoutPanel3.PerformLayout();
            roundTableLayoutPanel7.ResumeLayout(false);
            roundTableLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Bibliotheque_PacMan.RoundButton btnRetour;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel1;
        private Label lblHaut;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel5;
        private Label lblGauche;
        private TableLayoutPanel tableLayoutPanel3;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel3;
        private Label lblBas;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel7;
        private Label lblDroite;
        private Bibliotheque_PacMan.RoundButton btnVie;
        private Bibliotheque_PacMan.RoundButton btnVitesse;
        private Bibliotheque_PacMan.RoundButton btnTemps;
        private Bibliotheque_PacMan.RoundButton btnScore;
    }
}