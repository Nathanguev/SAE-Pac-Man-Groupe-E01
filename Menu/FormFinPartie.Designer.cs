namespace Interface_PacMan
{
    partial class FormFinPartie
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
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBoxMessage = new PictureBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            lblScore = new Label();
            btnNiveauSuivant = new Bibliotheque_PacMan.RoundButton();
            btnQuitter = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMessage).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
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
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel5.Controls.Add(btnQuitter, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 470);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel5.Size = new Size(1182, 78);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel4.Controls.Add(btnNiveauSuivant, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 392);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Size = new Size(1182, 78);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Controls.Add(pictureBoxMessage, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1182, 314);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBoxMessage
            // 
            pictureBoxMessage.Dock = DockStyle.Fill;
            pictureBoxMessage.Location = new Point(118, 62);
            pictureBoxMessage.Margin = new Padding(0);
            pictureBoxMessage.Name = "pictureBoxMessage";
            pictureBoxMessage.Size = new Size(945, 188);
            pictureBoxMessage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMessage.TabIndex = 0;
            pictureBoxMessage.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 314);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Size = new Size(1182, 78);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel6.Controls.Add(lblScore, 1, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(443, 7);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.Size = new Size(295, 62);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.White;
            lblScore.Dock = DockStyle.Fill;
            lblScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblScore.Location = new Point(17, 9);
            lblScore.Margin = new Padding(3);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(259, 43);
            lblScore.TabIndex = 0;
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNiveauSuivant
            // 
            btnNiveauSuivant.BackColor = Color.FromArgb(224, 224, 224);
            btnNiveauSuivant.BorderColor = Color.Transparent;
            btnNiveauSuivant.BorderRadius = 31;
            btnNiveauSuivant.BorderWidth = 0;
            btnNiveauSuivant.Dock = DockStyle.Fill;
            btnNiveauSuivant.FlatAppearance.BorderSize = 0;
            btnNiveauSuivant.FlatStyle = FlatStyle.Flat;
            btnNiveauSuivant.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNiveauSuivant.Location = new Point(443, 7);
            btnNiveauSuivant.Margin = new Padding(0);
            btnNiveauSuivant.Name = "btnNiveauSuivant";
            btnNiveauSuivant.Rounded = true;
            btnNiveauSuivant.Size = new Size(295, 62);
            btnNiveauSuivant.TabIndex = 0;
            btnNiveauSuivant.Text = "NIVEAU SUIVANT";
            btnNiveauSuivant.UseVisualStyleBackColor = false;
            btnNiveauSuivant.Click += btnNiveauSuivant_Click;
            btnNiveauSuivant.MouseEnter += btn_MouseEnter;
            btnNiveauSuivant.MouseLeave += btn_MouseLeave;
            // 
            // btnQuitter
            // 
            btnQuitter.BackColor = Color.FromArgb(224, 224, 224);
            btnQuitter.BorderColor = Color.Transparent;
            btnQuitter.BorderRadius = 31;
            btnQuitter.BorderWidth = 0;
            btnQuitter.Dock = DockStyle.Fill;
            btnQuitter.FlatAppearance.BorderSize = 0;
            btnQuitter.FlatStyle = FlatStyle.Flat;
            btnQuitter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQuitter.Location = new Point(443, 7);
            btnQuitter.Margin = new Padding(0);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Rounded = true;
            btnQuitter.Size = new Size(295, 62);
            btnQuitter.TabIndex = 0;
            btnQuitter.Text = "QUITTER";
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            btnQuitter.MouseEnter += btn_MouseEnter;
            btnQuitter.MouseLeave += btn_MouseLeave;
            // 
            // FormFinPartie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(960, 540);
            Name = "FormFinPartie";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Victory Screen";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormVictory_FormClosing;
            Load += FormVictory_Load;
            SizeChanged += FormVictory_SizeChanged;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMessage).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lblScore;
        private PictureBox pictureBoxMessage;
        private Bibliotheque_PacMan.RoundButton btnQuitter;
        private Bibliotheque_PacMan.RoundButton btnNiveauSuivant;
    }
}