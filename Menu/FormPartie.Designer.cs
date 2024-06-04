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
            lblVies = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblPseudo = new Label();
            lblPseudoChange = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblTimerChange = new Label();
            lblTimer = new Label();
            tlpGrille.SuspendLayout();
            tlpBordure.SuspendLayout();
            tlpScore.SuspendLayout();
            tlpFondEcran.SuspendLayout();
            tlpAffichage.SuspendLayout();
            tlpVies.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            tlpScore.Location = new Point(580, 10);
            tlpScore.Margin = new Padding(0);
            tlpScore.Name = "tlpScore";
            tlpScore.RowCount = 1;
            tlpScore.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpScore.Size = new Size(290, 42);
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
            tlpAffichage.Controls.Add(tlpScore, 2, 1);
            tlpAffichage.Controls.Add(tableLayoutPanel1, 0, 1);
            tlpAffichage.Controls.Add(tableLayoutPanel2, 1, 1);
            tlpAffichage.Controls.Add(tlpVies, 3, 1);
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
            tlpVies.Controls.Add(lblVies, 0, 0);
            tlpVies.Dock = DockStyle.Fill;
            tlpVies.Location = new Point(870, 10);
            tlpVies.Margin = new Padding(0);
            tlpVies.Name = "tlpVies";
            tlpVies.RowCount = 1;
            tlpVies.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpVies.Size = new Size(292, 42);
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lblPseudo, 0, 0);
            tableLayoutPanel1.Controls.Add(lblPseudoChange, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 10);
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
            tableLayoutPanel2.Location = new Point(290, 10);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(290, 42);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // lblTimerChange
            // 
            lblTimerChange.AutoSize = true;
            lblTimerChange.Dock = DockStyle.Fill;
            lblTimerChange.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTimerChange.ForeColor = Color.White;
            lblTimerChange.Location = new Point(145, 0);
            lblTimerChange.Margin = new Padding(0);
            lblTimerChange.Name = "lblTimerChange";
            lblTimerChange.Size = new Size(145, 42);
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
            lblTimer.Size = new Size(145, 42);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "TIMER :";
            lblTimer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormPartie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(tlpFondEcran);
            MinimizeBox = false;
            MinimumSize = new Size(960, 540);
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
            tlpVies.ResumeLayout(false);
            tlpVies.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
    }
}