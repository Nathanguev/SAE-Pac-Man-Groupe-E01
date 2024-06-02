﻿namespace Interface_PacMan
{
    partial class FormMenuVolume
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
            lblVolumeEffets = new Label();
            trackBarEffets = new TrackBar();
            btnRetour = new Bibliotheque_PacMan.RoundButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblVolumeGlobal = new Label();
            trackBarGlobal = new TrackBar();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblVolumeMusique = new Label();
            trackBarMusique = new TrackBar();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarEffets).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarGlobal).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarMusique).BeginInit();
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
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel2.Controls.Add(lblVolumeEffets, 3, 1);
            tableLayoutPanel2.Controls.Add(trackBarEffets, 5, 1);
            tableLayoutPanel2.Controls.Add(btnRetour, 1, 1);
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
            // lblVolumeEffets
            // 
            lblVolumeEffets.AutoSize = true;
            lblVolumeEffets.BackColor = Color.FromArgb(224, 224, 224);
            lblVolumeEffets.Dock = DockStyle.Fill;
            lblVolumeEffets.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVolumeEffets.Location = new Point(268, 7);
            lblVolumeEffets.Name = "lblVolumeEffets";
            lblVolumeEffets.Size = new Size(289, 62);
            lblVolumeEffets.TabIndex = 1;
            lblVolumeEffets.Text = "Volume Effets";
            lblVolumeEffets.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBarEffets
            // 
            trackBarEffets.Cursor = Cursors.Hand;
            trackBarEffets.Dock = DockStyle.Fill;
            trackBarEffets.LargeChange = 10;
            trackBarEffets.Location = new Point(619, 7);
            trackBarEffets.Margin = new Padding(0);
            trackBarEffets.Maximum = 100;
            trackBarEffets.Name = "trackBarEffets";
            trackBarEffets.Size = new Size(295, 62);
            trackBarEffets.SmallChange = 5;
            trackBarEffets.TabIndex = 2;
            trackBarEffets.Tag = "VolumeEffets";
            trackBarEffets.TickFrequency = 10;
            trackBarEffets.Value = 80;
            trackBarEffets.Validated += trackBar_Validated;
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel3.Controls.Add(lblVolumeGlobal, 1, 1);
            tableLayoutPanel3.Controls.Add(trackBarGlobal, 3, 1);
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
            // lblVolumeGlobal
            // 
            lblVolumeGlobal.AutoSize = true;
            lblVolumeGlobal.BackColor = Color.FromArgb(224, 224, 224);
            lblVolumeGlobal.Dock = DockStyle.Fill;
            lblVolumeGlobal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVolumeGlobal.Location = new Point(268, 7);
            lblVolumeGlobal.Name = "lblVolumeGlobal";
            lblVolumeGlobal.Size = new Size(289, 62);
            lblVolumeGlobal.TabIndex = 0;
            lblVolumeGlobal.Text = "Volume Global";
            lblVolumeGlobal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBarGlobal
            // 
            trackBarGlobal.Cursor = Cursors.Hand;
            trackBarGlobal.Dock = DockStyle.Fill;
            trackBarGlobal.LargeChange = 10;
            trackBarGlobal.Location = new Point(619, 7);
            trackBarGlobal.Margin = new Padding(0);
            trackBarGlobal.Maximum = 100;
            trackBarGlobal.Name = "trackBarGlobal";
            trackBarGlobal.Size = new Size(295, 62);
            trackBarGlobal.SmallChange = 5;
            trackBarGlobal.TabIndex = 1;
            trackBarGlobal.Tag = "VolumeGlobal";
            trackBarGlobal.TickFrequency = 10;
            trackBarGlobal.Value = 80;
            trackBarGlobal.Validated += trackBar_Validated;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel4.Controls.Add(lblVolumeMusique, 1, 1);
            tableLayoutPanel4.Controls.Add(trackBarMusique, 3, 1);
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
            // lblVolumeMusique
            // 
            lblVolumeMusique.AutoSize = true;
            lblVolumeMusique.BackColor = Color.FromArgb(224, 224, 224);
            lblVolumeMusique.Dock = DockStyle.Fill;
            lblVolumeMusique.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVolumeMusique.Location = new Point(268, 7);
            lblVolumeMusique.Name = "lblVolumeMusique";
            lblVolumeMusique.Size = new Size(289, 62);
            lblVolumeMusique.TabIndex = 0;
            lblVolumeMusique.Text = "Volume Musique";
            lblVolumeMusique.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBarMusique
            // 
            trackBarMusique.Cursor = Cursors.Hand;
            trackBarMusique.Dock = DockStyle.Fill;
            trackBarMusique.LargeChange = 10;
            trackBarMusique.Location = new Point(619, 7);
            trackBarMusique.Margin = new Padding(0);
            trackBarMusique.Maximum = 100;
            trackBarMusique.Name = "trackBarMusique";
            trackBarMusique.Size = new Size(295, 62);
            trackBarMusique.SmallChange = 5;
            trackBarMusique.TabIndex = 1;
            trackBarMusique.Tag = "VolumeMusique";
            trackBarMusique.TickFrequency = 10;
            trackBarMusique.Value = 80;
            trackBarMusique.ValueChanged += trackBarMusique_ValueChanged;
            trackBarMusique.Validated += trackBar_Validated;
            // 
            // FormMenuVolume
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 43);
            ClientSize = new Size(1182, 628);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(960, 540);
            Name = "FormMenuVolume";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Volume";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMenuVolume_FormClosing;
            Load += FormMenuVolume_Load;
            SizeChanged += FormMenuVolume_SizeChanged;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarEffets).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarGlobal).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarMusique).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblVolumeEffets;
        private Label lblVolumeGlobal;
        private Label lblVolumeMusique;
        private TrackBar trackBarGlobal;
        private TrackBar trackBarMusique;
        private TrackBar trackBarEffets;
        private Bibliotheque_PacMan.RoundButton btnRetour;
    }
}