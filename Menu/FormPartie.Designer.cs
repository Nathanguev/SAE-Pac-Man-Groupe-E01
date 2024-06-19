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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblPseudo = new Label();
            lblPseudoChange = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblTimerChange = new Label();
            lblTimer = new Label();
            tlpVies = new TableLayoutPanel();
            lblVies = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblTempsBonus = new Label();
            picBonus = new PictureBox();
            tableLayoutPanel9 = new TableLayoutPanel();
            lblPause = new Label();
            lblToucheEsc = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            lblTempsBonus2 = new Label();
            picBonus2 = new PictureBox();
            tlpGrille.SuspendLayout();
            tlpBordure.SuspendLayout();
            tlpScore.SuspendLayout();
            tlpFondEcran.SuspendLayout();
            tlpAffichage.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tlpVies.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBonus).BeginInit();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBonus2).BeginInit();
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
            tlpScore.ColumnCount = 2;
            tlpScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpScore.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpScore.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpScore.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpScore.Controls.Add(lblScoreCount, 1, 0);
            tlpScore.Controls.Add(lblScore, 0, 0);
            tlpScore.Dock = DockStyle.Fill;
            tlpScore.Location = new Point(580, 10);
            tlpScore.Margin = new Padding(0);
            tlpScore.Name = "tlpScore";
            tlpScore.RowCount = 1;
            tlpScore.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpScore.Size = new Size(232, 42);
            tlpScore.TabIndex = 0;
            // 
            // lblScoreCount
            // 
            lblScoreCount.AutoSize = true;
            lblScoreCount.BackColor = Color.Transparent;
            lblScoreCount.Dock = DockStyle.Fill;
            lblScoreCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblScoreCount.ForeColor = Color.White;
            lblScoreCount.Location = new Point(116, 0);
            lblScoreCount.Margin = new Padding(0);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new Size(116, 42);
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
            lblScore.Location = new Point(0, 0);
            lblScore.Margin = new Padding(0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(116, 42);
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
            tlpFondEcran.Controls.Add(tableLayoutPanel3, 1, 2);
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
            tlpAffichage.ColumnCount = 6;
            tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tlpAffichage.Controls.Add(tlpScore, 3, 1);
            tlpAffichage.Controls.Add(tableLayoutPanel1, 1, 1);
            tlpAffichage.Controls.Add(tableLayoutPanel2, 2, 1);
            tlpAffichage.Controls.Add(tlpVies, 4, 1);
            tlpAffichage.Dock = DockStyle.Fill;
            tlpAffichage.Location = new Point(10, 0);
            tlpAffichage.Margin = new Padding(0);
            tlpAffichage.Name = "tlpAffichage";
            tlpAffichage.RowCount = 3;
            tlpAffichage.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpAffichage.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAffichage.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpAffichage.Size = new Size(1162, 62);
            tlpAffichage.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblPseudo, 0, 0);
            tableLayoutPanel1.Controls.Add(lblPseudoChange, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(58, 10);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(290, 42);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblPseudo
            // 
            lblPseudo.AutoSize = true;
            lblPseudo.Dock = DockStyle.Fill;
            lblPseudo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPseudo.ForeColor = Color.White;
            lblPseudo.Location = new Point(0, 0);
            lblPseudo.Margin = new Padding(0);
            lblPseudo.Name = "lblPseudo";
            lblPseudo.Size = new Size(145, 42);
            lblPseudo.TabIndex = 0;
            lblPseudo.Text = "PSEUDO :";
            lblPseudo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPseudoChange
            // 
            lblPseudoChange.AutoSize = true;
            lblPseudoChange.Dock = DockStyle.Fill;
            lblPseudoChange.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPseudoChange.ForeColor = Color.White;
            lblPseudoChange.Location = new Point(145, 0);
            lblPseudoChange.Margin = new Padding(0);
            lblPseudoChange.Name = "lblPseudoChange";
            lblPseudoChange.Size = new Size(145, 42);
            lblPseudoChange.TabIndex = 1;
            lblPseudoChange.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblTimerChange, 1, 0);
            tableLayoutPanel2.Controls.Add(lblTimer, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(348, 10);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(232, 42);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // lblTimerChange
            // 
            lblTimerChange.AutoSize = true;
            lblTimerChange.Dock = DockStyle.Fill;
            lblTimerChange.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimerChange.ForeColor = Color.White;
            lblTimerChange.Location = new Point(116, 0);
            lblTimerChange.Margin = new Padding(0);
            lblTimerChange.Name = "lblTimerChange";
            lblTimerChange.Size = new Size(116, 42);
            lblTimerChange.TabIndex = 1;
            lblTimerChange.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Dock = DockStyle.Fill;
            lblTimer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimer.ForeColor = Color.White;
            lblTimer.Location = new Point(0, 0);
            lblTimer.Margin = new Padding(0);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(116, 42);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "TIMER :";
            lblTimer.TextAlign = ContentAlignment.MiddleRight;
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
            tlpVies.Controls.Add(lblVies, 0, 0);
            tlpVies.Dock = DockStyle.Fill;
            tlpVies.Location = new Point(812, 10);
            tlpVies.Margin = new Padding(0);
            tlpVies.Name = "tlpVies";
            tlpVies.RowCount = 1;
            tlpVies.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpVies.Size = new Size(290, 42);
            tlpVies.TabIndex = 1;
            // 
            // lblVies
            // 
            lblVies.AutoSize = true;
            lblVies.BackColor = Color.Transparent;
            lblVies.Dock = DockStyle.Fill;
            lblVies.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVies.ForeColor = Color.White;
            lblVies.Location = new Point(0, 0);
            lblVies.Margin = new Padding(0, 0, 0, 5);
            lblVies.Name = "lblVies";
            lblVies.Size = new Size(87, 37);
            lblVies.TabIndex = 0;
            lblVies.Text = "VIES : ";
            lblVies.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 8;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 6, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel9, 1, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 5, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(10, 564);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1162, 64);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(lblTempsBonus, 2, 1);
            tableLayoutPanel4.Controls.Add(picBonus, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(928, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Size = new Size(174, 64);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // lblTempsBonus
            // 
            lblTempsBonus.AutoSize = true;
            lblTempsBonus.Dock = DockStyle.Fill;
            lblTempsBonus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTempsBonus.ForeColor = Color.White;
            lblTempsBonus.Location = new Point(86, 6);
            lblTempsBonus.Margin = new Padding(0);
            lblTempsBonus.Name = "lblTempsBonus";
            lblTempsBonus.Size = new Size(52, 51);
            lblTempsBonus.TabIndex = 0;
            lblTempsBonus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picBonus
            // 
            picBonus.Dock = DockStyle.Fill;
            picBonus.Image = Properties.Resources.bonus_vitesse;
            picBonus.Location = new Point(34, 6);
            picBonus.Margin = new Padding(0);
            picBonus.Name = "picBonus";
            picBonus.Size = new Size(52, 51);
            picBonus.SizeMode = PictureBoxSizeMode.Zoom;
            picBonus.TabIndex = 1;
            picBonus.TabStop = false;
            picBonus.Visible = false;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(lblPause, 0, 0);
            tableLayoutPanel9.Controls.Add(lblToucheEsc, 1, 0);
            tableLayoutPanel9.Location = new Point(58, 0);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(174, 64);
            tableLayoutPanel9.TabIndex = 4;
            // 
            // lblPause
            // 
            lblPause.AutoSize = true;
            lblPause.Dock = DockStyle.Fill;
            lblPause.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPause.ForeColor = Color.White;
            lblPause.Location = new Point(0, 0);
            lblPause.Margin = new Padding(0);
            lblPause.Name = "lblPause";
            lblPause.Size = new Size(87, 64);
            lblPause.TabIndex = 5;
            lblPause.Text = "Pause";
            lblPause.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblToucheEsc
            // 
            lblToucheEsc.AutoSize = true;
            lblToucheEsc.Dock = DockStyle.Fill;
            lblToucheEsc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblToucheEsc.ForeColor = Color.White;
            lblToucheEsc.Location = new Point(87, 0);
            lblToucheEsc.Margin = new Padding(0);
            lblToucheEsc.Name = "lblToucheEsc";
            lblToucheEsc.Size = new Size(87, 64);
            lblToucheEsc.TabIndex = 0;
            lblToucheEsc.Text = ": Esc";
            lblToucheEsc.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Controls.Add(lblTempsBonus2, 2, 1);
            tableLayoutPanel5.Controls.Add(picBonus2, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(754, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.Size = new Size(174, 64);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // lblTempsBonus2
            // 
            lblTempsBonus2.AutoSize = true;
            lblTempsBonus2.Dock = DockStyle.Fill;
            lblTempsBonus2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTempsBonus2.ForeColor = Color.White;
            lblTempsBonus2.Location = new Point(86, 6);
            lblTempsBonus2.Margin = new Padding(0);
            lblTempsBonus2.Name = "lblTempsBonus2";
            lblTempsBonus2.Size = new Size(52, 51);
            lblTempsBonus2.TabIndex = 0;
            lblTempsBonus2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picBonus2
            // 
            picBonus2.Dock = DockStyle.Fill;
            picBonus2.Image = Properties.Resources.bonus_score;
            picBonus2.Location = new Point(34, 6);
            picBonus2.Margin = new Padding(0);
            picBonus2.Name = "picBonus2";
            picBonus2.Size = new Size(52, 51);
            picBonus2.SizeMode = PictureBoxSizeMode.Zoom;
            picBonus2.TabIndex = 1;
            picBonus2.TabStop = false;
            picBonus2.Visible = false;
            // 
            // FormPartie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(tlpFondEcran);
            MinimizeBox = false;
            MinimumSize = new Size(1200, 675);
            Name = "FormPartie";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Partie";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPartie_FormClosing;
            Load += FormPartie_Load;
            SizeChanged += FormPartie_SizeChanged;
            KeyDown += FormPartie_KeyDown;
            KeyPress += FormPartie_KeyPress;
            tlpGrille.ResumeLayout(false);
            tlpBordure.ResumeLayout(false);
            tlpScore.ResumeLayout(false);
            tlpScore.PerformLayout();
            tlpFondEcran.ResumeLayout(false);
            tlpAffichage.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tlpVies.ResumeLayout(false);
            tlpVies.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBonus).EndInit();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBonus2).EndInit();
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
        private Label lblVies;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblPseudo;
        private Label lblPseudoChange;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblTimerChange;
        private Label lblTimer;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblTempsBonus;
        private PictureBox picBonus;
        private TableLayoutPanel tableLayoutPanel9;
        private Label lblToucheEsc;
        private Label lblPause;
        private TableLayoutPanel tableLayoutPanel5;
        private Label lblTempsBonus2;
        private PictureBox picBonus2;
    }
}