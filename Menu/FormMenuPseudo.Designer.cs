namespace Interface_PacMan
{
    partial class FormMenuPseudo
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
            tlpPseudo = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            txtPseudo = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnSuivant = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            roundTableLayoutPanel1.SuspendLayout();
            tlpPseudo.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
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
            tableLayoutPanel2.Controls.Add(roundTableLayoutPanel1, 3, 1);
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
            btnRetour.BorderColor = Color.YellowGreen;
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
            // roundTableLayoutPanel1
            // 
            roundTableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            roundTableLayoutPanel1.BorderColor = Color.Transparent;
            roundTableLayoutPanel1.BorderRadius = 31;
            roundTableLayoutPanel1.BorderWidth = 0;
            roundTableLayoutPanel1.ColumnCount = 3;
            roundTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            roundTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            roundTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            roundTableLayoutPanel1.Controls.Add(tlpPseudo, 1, 1);
            roundTableLayoutPanel1.Dock = DockStyle.Fill;
            roundTableLayoutPanel1.Location = new Point(442, 7);
            roundTableLayoutPanel1.Margin = new Padding(0);
            roundTableLayoutPanel1.Name = "roundTableLayoutPanel1";
            roundTableLayoutPanel1.RowCount = 3;
            roundTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            roundTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            roundTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            roundTableLayoutPanel1.Size = new Size(295, 62);
            roundTableLayoutPanel1.TabIndex = 1;
            // 
            // tlpPseudo
            // 
            tlpPseudo.BackColor = Color.White;
            tlpPseudo.BorderColor = Color.Transparent;
            tlpPseudo.BorderRadius = 21;
            tlpPseudo.BorderWidth = 0;
            tlpPseudo.ColumnCount = 1;
            tlpPseudo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPseudo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpPseudo.Controls.Add(txtPseudo, 0, 0);
            tlpPseudo.Dock = DockStyle.Fill;
            tlpPseudo.Location = new Point(14, 9);
            tlpPseudo.Margin = new Padding(0);
            tlpPseudo.Name = "tlpPseudo";
            tlpPseudo.RowCount = 1;
            tlpPseudo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPseudo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpPseudo.Size = new Size(265, 43);
            tlpPseudo.TabIndex = 0;
            tlpPseudo.Click += tlpPseudo_Click;
            // 
            // txtPseudo
            // 
            txtPseudo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPseudo.BorderStyle = BorderStyle.None;
            txtPseudo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtPseudo.Location = new Point(0, 10);
            txtPseudo.Margin = new Padding(0);
            txtPseudo.MaxLength = 15;
            txtPseudo.Name = "txtPseudo";
            txtPseudo.PlaceholderText = "PSEUDO";
            txtPseudo.Size = new Size(265, 23);
            txtPseudo.TabIndex = 0;
            txtPseudo.TextAlign = HorizontalAlignment.Center;
            txtPseudo.TextChanged += txtPseudo_TextChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel4.Controls.Add(btnSuivant, 1, 1);
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
            // btnSuivant
            // 
            btnSuivant.BackColor = Color.FromArgb(224, 224, 224);
            btnSuivant.BorderColor = Color.Transparent;
            btnSuivant.BorderRadius = 31;
            btnSuivant.BorderWidth = 0;
            btnSuivant.Dock = DockStyle.Fill;
            btnSuivant.Enabled = false;
            btnSuivant.FlatAppearance.BorderSize = 0;
            btnSuivant.FlatStyle = FlatStyle.Flat;
            btnSuivant.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSuivant.HexaColor = "";
            btnSuivant.Location = new Point(443, 7);
            btnSuivant.Margin = new Padding(0);
            btnSuivant.Name = "btnSuivant";
            btnSuivant.Rounded = true;
            btnSuivant.Size = new Size(295, 62);
            btnSuivant.TabIndex = 0;
            btnSuivant.Text = "SUIVANT";
            btnSuivant.UseVisualStyleBackColor = false;
            btnSuivant.Click += btnSuivant_Click;
            btnSuivant.MouseEnter += btn_MouseEnter;
            btnSuivant.MouseLeave += btn_MouseLeave;
            // 
            // FormMenuPseudo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(960, 540);
            Name = "FormMenuPseudo";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Pseudo";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMenuPseudo_FormClosing;
            SizeChanged += FormMenuPseudo_SizeChanged;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            roundTableLayoutPanel1.ResumeLayout(false);
            tlpPseudo.ResumeLayout(false);
            tlpPseudo.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Bibliotheque_PacMan.RoundButton btnRetour;
        private Bibliotheque_PacMan.RoundButton btnSuivant;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel1;
        private Bibliotheque_PacMan.RoundTableLayoutPanel tlpPseudo;
        private TextBox txtPseudo;
    }
}