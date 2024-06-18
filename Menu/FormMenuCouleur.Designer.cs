namespace Interface_PacMan
{
    partial class FormMenuCouleur
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
            btnJaune = new Bibliotheque_PacMan.RoundButton();
            btnBeige = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnViolet = new Bibliotheque_PacMan.RoundButton();
            btnVert = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnRouge = new Bibliotheque_PacMan.RoundButton();
            btnPerso = new Bibliotheque_PacMan.RoundButton();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
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
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
            tableLayoutPanel2.Controls.Add(btnRetour, 1, 1);
            tableLayoutPanel2.Controls.Add(btnJaune, 3, 1);
            tableLayoutPanel2.Controls.Add(btnBeige, 5, 1);
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
            // btnJaune
            // 
            btnJaune.BackColor = Color.FromArgb(255, 203, 1);
            btnJaune.BorderColor = Color.Transparent;
            btnJaune.BorderRadius = 31;
            btnJaune.BorderWidth = 0;
            btnJaune.Dock = DockStyle.Fill;
            btnJaune.FlatAppearance.BorderSize = 0;
            btnJaune.FlatStyle = FlatStyle.Flat;
            btnJaune.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnJaune.HexaColor = "#ffcb01";
            btnJaune.Location = new Point(383, 7);
            btnJaune.Margin = new Padding(0);
            btnJaune.Name = "btnJaune";
            btnJaune.Rounded = true;
            btnJaune.Size = new Size(177, 62);
            btnJaune.TabIndex = 1;
            btnJaune.Text = "Jaune";
            btnJaune.UseVisualStyleBackColor = false;
            btnJaune.Click += btnCouleur_Click;
            // 
            // btnBeige
            // 
            btnBeige.BackColor = Color.FromArgb(222, 150, 127);
            btnBeige.BorderColor = Color.Transparent;
            btnBeige.BorderRadius = 31;
            btnBeige.BorderWidth = 0;
            btnBeige.Dock = DockStyle.Fill;
            btnBeige.FlatAppearance.BorderSize = 0;
            btnBeige.FlatStyle = FlatStyle.Flat;
            btnBeige.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBeige.HexaColor = "#de967f";
            btnBeige.Location = new Point(619, 7);
            btnBeige.Margin = new Padding(0);
            btnBeige.Name = "btnBeige";
            btnBeige.Rounded = true;
            btnBeige.Size = new Size(177, 62);
            btnBeige.TabIndex = 2;
            btnBeige.Text = "Beige";
            btnBeige.UseVisualStyleBackColor = false;
            btnBeige.Click += btnCouleur_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
            tableLayoutPanel3.Controls.Add(btnViolet, 1, 1);
            tableLayoutPanel3.Controls.Add(btnVert, 3, 1);
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
            // btnViolet
            // 
            btnViolet.BackColor = Color.FromArgb(164, 114, 195);
            btnViolet.BorderColor = Color.Transparent;
            btnViolet.BorderRadius = 31;
            btnViolet.BorderWidth = 0;
            btnViolet.Dock = DockStyle.Fill;
            btnViolet.FlatAppearance.BorderSize = 0;
            btnViolet.FlatStyle = FlatStyle.Flat;
            btnViolet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnViolet.HexaColor = "#a472c3";
            btnViolet.Location = new Point(384, 7);
            btnViolet.Margin = new Padding(0);
            btnViolet.Name = "btnViolet";
            btnViolet.Rounded = true;
            btnViolet.Size = new Size(177, 62);
            btnViolet.TabIndex = 0;
            btnViolet.Text = "Violet";
            btnViolet.UseVisualStyleBackColor = false;
            btnViolet.Click += btnCouleur_Click;
            // 
            // btnVert
            // 
            btnVert.BackColor = Color.FromArgb(129, 216, 127);
            btnVert.BorderColor = Color.Transparent;
            btnVert.BorderRadius = 31;
            btnVert.BorderWidth = 0;
            btnVert.Dock = DockStyle.Fill;
            btnVert.FlatAppearance.BorderSize = 0;
            btnVert.FlatStyle = FlatStyle.Flat;
            btnVert.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVert.HexaColor = "#81d87f";
            btnVert.Location = new Point(620, 7);
            btnVert.Margin = new Padding(0);
            btnVert.Name = "btnVert";
            btnVert.Rounded = true;
            btnVert.Size = new Size(177, 62);
            btnVert.TabIndex = 1;
            btnVert.Text = "Vert";
            btnVert.UseVisualStyleBackColor = false;
            btnVert.Click += btnCouleur_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
            tableLayoutPanel4.Controls.Add(btnRouge, 1, 1);
            tableLayoutPanel4.Controls.Add(btnPerso, 3, 1);
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
            // btnRouge
            // 
            btnRouge.BackColor = Color.FromArgb(199, 59, 59);
            btnRouge.BorderColor = Color.Transparent;
            btnRouge.BorderRadius = 31;
            btnRouge.BorderWidth = 0;
            btnRouge.Dock = DockStyle.Fill;
            btnRouge.FlatAppearance.BorderSize = 0;
            btnRouge.FlatStyle = FlatStyle.Flat;
            btnRouge.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRouge.HexaColor = "#c73b3b";
            btnRouge.Location = new Point(384, 7);
            btnRouge.Margin = new Padding(0);
            btnRouge.Name = "btnRouge";
            btnRouge.Rounded = true;
            btnRouge.Size = new Size(177, 62);
            btnRouge.TabIndex = 0;
            btnRouge.Text = "Rouge";
            btnRouge.UseVisualStyleBackColor = false;
            btnRouge.Click += btnCouleur_Click;
            // 
            // btnPerso
            // 
            btnPerso.BackColor = Color.FromArgb(224, 224, 224);
            btnPerso.BorderColor = Color.Transparent;
            btnPerso.BorderRadius = 31;
            btnPerso.BorderWidth = 0;
            btnPerso.Dock = DockStyle.Fill;
            btnPerso.FlatAppearance.BorderSize = 0;
            btnPerso.FlatStyle = FlatStyle.Flat;
            btnPerso.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnPerso.HexaColor = "";
            btnPerso.Location = new Point(620, 7);
            btnPerso.Margin = new Padding(0);
            btnPerso.Name = "btnPerso";
            btnPerso.Padding = new Padding(0, 0, 0, 10);
            btnPerso.Rounded = true;
            btnPerso.Size = new Size(177, 62);
            btnPerso.TabIndex = 1;
            btnPerso.Text = "+";
            btnPerso.UseVisualStyleBackColor = false;
            btnPerso.Click += btnPerso_Click;
            // 
            // FormMenuCouleur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(960, 540);
            Name = "FormMenuCouleur";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Couleur";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMenuCouleur_FormClosing;
            Load += FormMenuCouleur_Load;
            SizeChanged += FormMenuCouleur_SizeChanged;
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
        private Bibliotheque_PacMan.RoundButton btnRetour;
        private Bibliotheque_PacMan.RoundButton btnJaune;
        private Bibliotheque_PacMan.RoundButton btnBeige;
        private Bibliotheque_PacMan.RoundButton btnViolet;
        private Bibliotheque_PacMan.RoundButton btnVert;
        private Bibliotheque_PacMan.RoundButton btnRouge;
        private Bibliotheque_PacMan.RoundButton btnPerso;
    }
}