namespace Interface_PacMan
{
    partial class FormMenuPause
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
            btnContinuer = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnOptions = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnQuitter = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 31.25F));
            tableLayoutPanel1.Size = new Size(1182, 628);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btnContinuer, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(443, 196);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(295, 78);
            tableLayoutPanel2.TabIndex = 0;
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
            btnContinuer.Location = new Point(0, 7);
            btnContinuer.Margin = new Padding(0);
            btnContinuer.Name = "btnContinuer";
            btnContinuer.Rounded = true;
            btnContinuer.Size = new Size(295, 62);
            btnContinuer.TabIndex = 1;
            btnContinuer.Text = "CONTINUER";
            btnContinuer.UseVisualStyleBackColor = false;
            btnContinuer.Click += btnContinuer_Click;
            btnContinuer.MouseEnter += btn_MouseEnter;
            btnContinuer.MouseLeave += btn_MouseLeave;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(btnOptions, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(443, 274);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Size = new Size(295, 78);
            tableLayoutPanel3.TabIndex = 1;
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
            btnOptions.Location = new Point(0, 7);
            btnOptions.Margin = new Padding(0);
            btnOptions.Name = "btnOptions";
            btnOptions.Rounded = true;
            btnOptions.Size = new Size(295, 62);
            btnOptions.TabIndex = 2;
            btnOptions.Text = "OPTIONS";
            btnOptions.UseVisualStyleBackColor = false;
            btnOptions.Click += btnOptions_Click;
            btnOptions.MouseEnter += btn_MouseEnter;
            btnOptions.MouseLeave += btn_MouseLeave;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(btnQuitter, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(443, 352);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel4.Size = new Size(295, 78);
            tableLayoutPanel4.TabIndex = 2;
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
            btnQuitter.Location = new Point(0, 7);
            btnQuitter.Margin = new Padding(0);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Rounded = true;
            btnQuitter.Size = new Size(295, 62);
            btnQuitter.TabIndex = 3;
            btnQuitter.Text = "QUITTER";
            btnQuitter.UseVisualStyleBackColor = false;
            btnQuitter.Click += btnQuitter_Click;
            btnQuitter.MouseEnter += btn_MouseEnter;
            btnQuitter.MouseLeave += btn_MouseLeave;
            // 
            // FormMenuPause
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(960, 540);
            Name = "FormMenuPause";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Pause";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMenuPause_FormClosing;
            SizeChanged += FormMenuPause_SizeChanged;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Bibliotheque_PacMan.RoundButton btnContinuer;
        private Bibliotheque_PacMan.RoundButton btnOptions;
        private Bibliotheque_PacMan.RoundButton btnQuitter;
    }
}