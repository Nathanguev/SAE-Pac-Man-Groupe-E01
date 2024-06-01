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
            btnCouleur = new Button();
            btnRetour = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnDifficulte = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnBonus = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
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
            pictureBox1.Location = new Point(3, 30);
            pictureBox1.Margin = new Padding(3, 30, 3, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1176, 254);
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
            tableLayoutPanel2.Controls.Add(btnCouleur, 3, 1);
            tableLayoutPanel2.Controls.Add(btnRetour, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 317);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(1176, 72);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnCouleur
            // 
            btnCouleur.BackColor = Color.FromArgb(224, 224, 224);
            btnCouleur.Dock = DockStyle.Fill;
            btnCouleur.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCouleur.Location = new Point(442, 10);
            btnCouleur.Name = "btnCouleur";
            btnCouleur.Size = new Size(288, 51);
            btnCouleur.TabIndex = 0;
            btnCouleur.Text = "Couleur Pac-Man";
            btnCouleur.UseVisualStyleBackColor = false;
            btnCouleur.MouseEnter += btn_MouseEnter;
            btnCouleur.MouseLeave += btn_MouseLeave;
            // 
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(224, 224, 224);
            btnRetour.Dock = DockStyle.Fill;
            btnRetour.Location = new Point(120, 10);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(52, 51);
            btnRetour.TabIndex = 1;
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += btnRetour_Click;
            btnRetour.MouseEnter += btn_MouseEnter;
            btnRetour.MouseLeave += btn_MouseLeave;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel3.Controls.Add(btnDifficulte, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 395);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Size = new Size(1176, 72);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // btnDifficulte
            // 
            btnDifficulte.BackColor = Color.FromArgb(224, 224, 224);
            btnDifficulte.Dock = DockStyle.Fill;
            btnDifficulte.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDifficulte.Location = new Point(444, 10);
            btnDifficulte.Name = "btnDifficulte";
            btnDifficulte.Size = new Size(288, 51);
            btnDifficulte.TabIndex = 0;
            btnDifficulte.Text = "Difficulté";
            btnDifficulte.UseVisualStyleBackColor = false;
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
            tableLayoutPanel4.Location = new Point(3, 473);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Size = new Size(1176, 72);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // btnBonus
            // 
            btnBonus.BackColor = Color.FromArgb(224, 224, 224);
            btnBonus.Dock = DockStyle.Fill;
            btnBonus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBonus.Location = new Point(444, 10);
            btnBonus.Name = "btnBonus";
            btnBonus.Size = new Size(288, 51);
            btnBonus.TabIndex = 0;
            btnBonus.Text = "Bonus";
            btnBonus.UseVisualStyleBackColor = false;
            btnBonus.MouseEnter += btn_MouseEnter;
            btnBonus.MouseLeave += btn_MouseLeave;
            // 
            // FormMenuParametre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(tableLayoutPanel1);
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnCouleur;
        private Button btnRetour;
        private Button btnDifficulte;
        private Button btnBonus;
    }
}