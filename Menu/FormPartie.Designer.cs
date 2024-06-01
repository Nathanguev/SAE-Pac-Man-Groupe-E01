namespace Interface_PacMan
{
    partial class FormPartie
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
            tlpGrille = new TableLayoutPanel();
            tlpBordure = new TableLayoutPanel();
            panelLabyrinthe = new Panel();
            tlpScore = new TableLayoutPanel();
            lblScoreCount = new Label();
            lblScore = new Label();
            tlpFondEcran = new TableLayoutPanel();
            tlpAffichage = new TableLayoutPanel();
            tlpVies = new TableLayoutPanel();
            label1 = new Label();
            tlpGrille.SuspendLayout();
            tlpBordure.SuspendLayout();
            tlpScore.SuspendLayout();
            tlpFondEcran.SuspendLayout();
            tlpAffichage.SuspendLayout();
            tlpVies.SuspendLayout();
            SuspendLayout();
            // 
            // tlpGrille
            // 
            tlpGrille.AutoScroll = true;
            tlpGrille.ColumnCount = 3;
            tlpGrille.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tlpGrille.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tlpGrille.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tlpGrille.Controls.Add(tlpBordure, 1, 1);
            tlpGrille.Dock = DockStyle.Fill;
            tlpGrille.Location = new Point(10, 62);
            tlpGrille.Margin = new Padding(0);
            tlpGrille.Name = "tlpGrille";
            tlpGrille.RowCount = 3;
            tlpGrille.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpGrille.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpGrille.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpGrille.Size = new Size(1162, 502);
            tlpGrille.TabIndex = 0;
            // 
            // tlpBordure
            // 
            tlpBordure.BackColor = Color.FromArgb(0, 0, 192);
            tlpBordure.ColumnCount = 3;
            tlpBordure.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 2F));
            tlpBordure.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpBordure.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 2F));
            tlpBordure.Controls.Add(panelLabyrinthe, 1, 1);
            tlpBordure.Dock = DockStyle.Fill;
            tlpBordure.Location = new Point(58, 50);
            tlpBordure.Margin = new Padding(0);
            tlpBordure.Name = "tlpBordure";
            tlpBordure.RowCount = 3;
            tlpBordure.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tlpBordure.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBordure.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tlpBordure.Size = new Size(1045, 401);
            tlpBordure.TabIndex = 1;
            // 
            // panelLabyrinthe
            // 
            panelLabyrinthe.BackColor = Color.Black;
            panelLabyrinthe.Dock = DockStyle.Fill;
            panelLabyrinthe.Location = new Point(2, 2);
            panelLabyrinthe.Margin = new Padding(0);
            panelLabyrinthe.Name = "panelLabyrinthe";
            panelLabyrinthe.Size = new Size(1041, 397);
            panelLabyrinthe.TabIndex = 0;
            // 
            // tlpScore
            // 
            tlpScore.ColumnCount = 4;
            tlpScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpScore.Controls.Add(lblScoreCount, 2, 0);
            tlpScore.Controls.Add(lblScore, 1, 0);
            tlpScore.Dock = DockStyle.Fill;
            tlpScore.Location = new Point(870, 10);
            tlpScore.Margin = new Padding(0);
            tlpScore.Name = "tlpScore";
            tlpScore.RowCount = 1;
            tlpScore.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpScore.Size = new Size(292, 42);
            tlpScore.TabIndex = 0;
            // 
            // lblScoreCount
            // 
            lblScoreCount.AutoSize = true;
            lblScoreCount.BackColor = Color.Transparent;
            lblScoreCount.Dock = DockStyle.Fill;
            lblScoreCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblScoreCount.ForeColor = Color.White;
            lblScoreCount.Location = new Point(174, 0);
            lblScoreCount.Margin = new Padding(0);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new Size(58, 42);
            lblScoreCount.TabIndex = 1;
            lblScoreCount.Text = "0";
            lblScoreCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Dock = DockStyle.Fill;
            lblScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(87, 0);
            lblScore.Margin = new Padding(0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(87, 42);
            lblScore.TabIndex = 0;
            lblScore.Text = "SCORE :";
            lblScore.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tlpFondEcran
            // 
            tlpFondEcran.ColumnCount = 3;
            tlpFondEcran.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpFondEcran.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFondEcran.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tlpFondEcran.Controls.Add(tlpGrille, 1, 1);
            tlpFondEcran.Controls.Add(tlpAffichage, 1, 0);
            tlpFondEcran.Dock = DockStyle.Fill;
            tlpFondEcran.Location = new Point(0, 0);
            tlpFondEcran.Name = "tlpFondEcran";
            tlpFondEcran.RowCount = 3;
            tlpFondEcran.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpFondEcran.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpFondEcran.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpFondEcran.Size = new Size(1182, 628);
            tlpFondEcran.TabIndex = 1;
            // 
            // tlpAffichage
            // 
            tlpAffichage.ColumnCount = 4;
            tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpAffichage.Controls.Add(tlpScore, 3, 1);
            tlpAffichage.Controls.Add(tlpVies, 0, 1);
            tlpAffichage.Dock = DockStyle.Fill;
            tlpAffichage.Location = new Point(10, 0);
            tlpAffichage.Margin = new Padding(0);
            tlpAffichage.Name = "tlpAffichage";
            tlpAffichage.RowCount = 3;
            tlpAffichage.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpAffichage.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAffichage.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpAffichage.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpAffichage.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpAffichage.Size = new Size(1162, 62);
            tlpAffichage.TabIndex = 1;
            // 
            // tlpVies
            // 
            tlpVies.ColumnCount = 6;
            tlpVies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpVies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tlpVies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tlpVies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tlpVies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tlpVies.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F));
            tlpVies.Controls.Add(label1, 0, 0);
            tlpVies.Dock = DockStyle.Fill;
            tlpVies.Location = new Point(0, 10);
            tlpVies.Margin = new Padding(0);
            tlpVies.Name = "tlpVies";
            tlpVies.RowCount = 1;
            tlpVies.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpVies.Size = new Size(290, 42);
            tlpVies.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(87, 42);
            label1.TabIndex = 0;
            label1.Text = "VIES : ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormPartie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(tlpFondEcran);
            MinimumSize = new Size(960, 540);
            Name = "FormPartie";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Partie";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPartie_FormClosing;
            Load += FormPartie_Load;
            KeyPress += FormPartie_KeyPress;
            tlpGrille.ResumeLayout(false);
            tlpBordure.ResumeLayout(false);
            tlpScore.ResumeLayout(false);
            tlpScore.PerformLayout();
            tlpFondEcran.ResumeLayout(false);
            tlpAffichage.ResumeLayout(false);
            tlpVies.ResumeLayout(false);
            tlpVies.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpGrille;
        private Panel panelLabyrinthe;
        private TableLayoutPanel tlpBordure;
        private TableLayoutPanel tlpScore;
        private TableLayoutPanel tlpFondEcran;
        private TableLayoutPanel tlpAffichage;
        private Label lblScoreCount;
        private Label lblScore;
        private TableLayoutPanel tlpVies;
        private Label label1;
    }
}