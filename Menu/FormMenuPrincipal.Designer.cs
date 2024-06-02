namespace Menu
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnContinuer = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnNouvellePartie = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnOptions = new Bibliotheque_PacMan.RoundButton();
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
            pictureBox1.Image = Interface_PacMan.Properties.Resources.Logo;
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
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel2.Controls.Add(btnContinuer, 1, 1);
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
            // btnContinuer
            // 
            btnContinuer.BackColor = Color.FromArgb(224, 224, 224);
            btnContinuer.BorderColor = Color.Transparent;
            btnContinuer.BorderRadius = 31;
            btnContinuer.BorderWidth = 0;
            btnContinuer.Dock = DockStyle.Fill;
            btnContinuer.FlatAppearance.BorderSize = 0;
            btnContinuer.FlatStyle = FlatStyle.Flat;
            btnContinuer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnContinuer.Location = new Point(443, 7);
            btnContinuer.Margin = new Padding(0);
            btnContinuer.Name = "btnContinuer";
            btnContinuer.Rounded = true;
            btnContinuer.Size = new Size(295, 62);
            btnContinuer.TabIndex = 0;
            btnContinuer.Text = "CONTINUER";
            btnContinuer.UseVisualStyleBackColor = false;
            btnContinuer.Click += btnContinuer_Click;
            btnContinuer.MouseEnter += btn_MouseEnter;
            btnContinuer.MouseLeave += btn_MouseLeave;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel3.Controls.Add(btnNouvellePartie, 1, 1);
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
            // btnNouvellePartie
            // 
            btnNouvellePartie.BackColor = Color.FromArgb(224, 224, 224);
            btnNouvellePartie.BorderColor = Color.Transparent;
            btnNouvellePartie.BorderRadius = 31;
            btnNouvellePartie.BorderWidth = 0;
            btnNouvellePartie.Dock = DockStyle.Fill;
            btnNouvellePartie.FlatAppearance.BorderSize = 0;
            btnNouvellePartie.FlatStyle = FlatStyle.Flat;
            btnNouvellePartie.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNouvellePartie.Location = new Point(443, 7);
            btnNouvellePartie.Margin = new Padding(0);
            btnNouvellePartie.Name = "btnNouvellePartie";
            btnNouvellePartie.Rounded = true;
            btnNouvellePartie.Size = new Size(295, 62);
            btnNouvellePartie.TabIndex = 0;
            btnNouvellePartie.Text = "NOUVELLE PARTIE";
            btnNouvellePartie.UseVisualStyleBackColor = false;
            btnNouvellePartie.Click += btnNouvellePartie_Click;
            btnNouvellePartie.MouseEnter += btn_MouseEnter;
            btnNouvellePartie.MouseLeave += btn_MouseLeave;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel4.Controls.Add(btnOptions, 1, 1);
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
            // btnOptions
            // 
            btnOptions.BackColor = Color.FromArgb(224, 224, 224);
            btnOptions.BorderColor = Color.Transparent;
            btnOptions.BorderRadius = 31;
            btnOptions.BorderWidth = 0;
            btnOptions.Dock = DockStyle.Fill;
            btnOptions.FlatAppearance.BorderSize = 0;
            btnOptions.FlatStyle = FlatStyle.Flat;
            btnOptions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOptions.Location = new Point(443, 7);
            btnOptions.Margin = new Padding(0);
            btnOptions.Name = "btnOptions";
            btnOptions.Rounded = true;
            btnOptions.Size = new Size(295, 62);
            btnOptions.TabIndex = 0;
            btnOptions.Text = "OPTIONS";
            btnOptions.UseVisualStyleBackColor = false;
            btnOptions.Click += btnOptions_Click;
            btnOptions.MouseEnter += btn_MouseEnter;
            btnOptions.MouseLeave += btn_MouseLeave;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(960, 540);
            Name = "FormMenuPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMenuPrincipal_FormClosing;
            Load += FormMenuPrincipal_Load;
            SizeChanged += FormMenuPrincipal_SizeChanged;
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
        private Bibliotheque_PacMan.RoundButton btnContinuer;
        private Bibliotheque_PacMan.RoundButton btnNouvellePartie;
        private Bibliotheque_PacMan.RoundButton btnOptions;
    }
}
