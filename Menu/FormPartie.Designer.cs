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
            tlpAffichage = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblScoreCount = new Label();
            lblScore = new Label();
            tlpGrille.SuspendLayout();
            tlpBordure.SuspendLayout();
            tlpAffichage.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            tlpGrille.Controls.Add(tlpAffichage, 1, 0);
            tlpGrille.Dock = DockStyle.Fill;
            tlpGrille.Location = new Point(0, 0);
            tlpGrille.Name = "tlpGrille";
            tlpGrille.RowCount = 3;
            tlpGrille.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpGrille.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpGrille.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpGrille.Size = new Size(1182, 628);
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
            tlpBordure.Location = new Point(59, 62);
            tlpBordure.Margin = new Padding(0);
            tlpBordure.Name = "tlpBordure";
            tlpBordure.RowCount = 3;
            tlpBordure.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tlpBordure.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBordure.RowStyles.Add(new RowStyle(SizeType.Absolute, 2F));
            tlpBordure.Size = new Size(1063, 502);
            tlpBordure.TabIndex = 1;
            // 
            // panelLabyrinthe
            // 
            panelLabyrinthe.BackColor = Color.Black;
            panelLabyrinthe.Dock = DockStyle.Fill;
            panelLabyrinthe.Location = new Point(2, 2);
            panelLabyrinthe.Margin = new Padding(0);
            panelLabyrinthe.Name = "panelLabyrinthe";
            panelLabyrinthe.Size = new Size(1059, 498);
            panelLabyrinthe.TabIndex = 0;
            // 
            // tlpAffichage
            // 
            tlpAffichage.ColumnCount = 3;
            tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlpAffichage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpAffichage.Controls.Add(tableLayoutPanel3, 2, 0);
            tlpAffichage.Dock = DockStyle.Fill;
            tlpAffichage.Location = new Point(59, 0);
            tlpAffichage.Margin = new Padding(0);
            tlpAffichage.Name = "tlpAffichage";
            tlpAffichage.RowCount = 1;
            tlpAffichage.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpAffichage.Size = new Size(1063, 62);
            tlpAffichage.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.Controls.Add(lblScoreCount, 2, 1);
            tableLayoutPanel3.Controls.Add(lblScore, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(852, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.Size = new Size(208, 56);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // lblScoreCount
            // 
            lblScoreCount.AutoSize = true;
            lblScoreCount.BackColor = Color.FromArgb(224, 224, 224);
            lblScoreCount.Dock = DockStyle.Fill;
            lblScoreCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblScoreCount.Location = new Point(103, 8);
            lblScoreCount.Margin = new Padding(0);
            lblScoreCount.Name = "lblScoreCount";
            lblScoreCount.Size = new Size(93, 39);
            lblScoreCount.TabIndex = 3;
            lblScoreCount.Text = "0";
            lblScoreCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.FromArgb(224, 224, 224);
            lblScore.Dock = DockStyle.Fill;
            lblScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblScore.Location = new Point(10, 8);
            lblScore.Margin = new Padding(0);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(93, 39);
            lblScore.TabIndex = 0;
            lblScore.Text = "SCORE :";
            lblScore.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormPartie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(tlpGrille);
            MinimumSize = new Size(960, 540);
            Name = "FormPartie";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Partie";
            WindowState = FormWindowState.Maximized;
            Load += FormPartie_Load;
            KeyPress += FormPartie_KeyPress;
            tlpGrille.ResumeLayout(false);
            tlpBordure.ResumeLayout(false);
            tlpAffichage.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpGrille;
        private Panel panelLabyrinthe;
        private TableLayoutPanel tlpBordure;
        private TableLayoutPanel tlpAffichage;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblScoreCount;
        private Label lblScore;
    }
}