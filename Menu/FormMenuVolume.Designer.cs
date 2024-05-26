namespace Interface_PacMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuVolume));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnRetour = new Button();
            lblVolumeEffets = new Label();
            trackBar3 = new TrackBar();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblVolumeGlobal = new Label();
            trackBar2 = new TrackBar();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblVolumeMusique = new Label();
            trackBar1 = new TrackBar();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
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
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
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
            tableLayoutPanel2.ColumnCount = 7;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7.5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5F));
            tableLayoutPanel2.Controls.Add(btnRetour, 1, 1);
            tableLayoutPanel2.Controls.Add(lblVolumeEffets, 3, 1);
            tableLayoutPanel2.Controls.Add(trackBar3, 5, 1);
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
            // btnRetour
            // 
            btnRetour.BackColor = Color.FromArgb(224, 224, 224);
            btnRetour.Dock = DockStyle.Fill;
            btnRetour.Location = new Point(120, 10);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(52, 51);
            btnRetour.TabIndex = 0;
            btnRetour.UseVisualStyleBackColor = false;
            btnRetour.Click += button1_Click;
            // 
            // lblVolumeEffets
            // 
            lblVolumeEffets.AutoSize = true;
            lblVolumeEffets.BackColor = Color.FromArgb(224, 224, 224);
            lblVolumeEffets.Dock = DockStyle.Fill;
            lblVolumeEffets.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVolumeEffets.Location = new Point(266, 7);
            lblVolumeEffets.Name = "lblVolumeEffets";
            lblVolumeEffets.Size = new Size(288, 57);
            lblVolumeEffets.TabIndex = 1;
            lblVolumeEffets.Text = "Volume Effets";
            lblVolumeEffets.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar3
            // 
            trackBar3.Cursor = Cursors.Hand;
            trackBar3.Dock = DockStyle.Fill;
            trackBar3.LargeChange = 10;
            trackBar3.Location = new Point(618, 10);
            trackBar3.Maximum = 100;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(288, 51);
            trackBar3.SmallChange = 5;
            trackBar3.TabIndex = 2;
            trackBar3.TickFrequency = 10;
            trackBar3.Value = 80;
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
            tableLayoutPanel3.Controls.Add(trackBar2, 3, 1);
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
            // lblVolumeGlobal
            // 
            lblVolumeGlobal.AutoSize = true;
            lblVolumeGlobal.BackColor = Color.FromArgb(224, 224, 224);
            lblVolumeGlobal.Dock = DockStyle.Fill;
            lblVolumeGlobal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVolumeGlobal.Location = new Point(267, 7);
            lblVolumeGlobal.Name = "lblVolumeGlobal";
            lblVolumeGlobal.Size = new Size(288, 57);
            lblVolumeGlobal.TabIndex = 0;
            lblVolumeGlobal.Text = "Volume Global";
            lblVolumeGlobal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar2
            // 
            trackBar2.Cursor = Cursors.Hand;
            trackBar2.Dock = DockStyle.Fill;
            trackBar2.LargeChange = 10;
            trackBar2.Location = new Point(619, 10);
            trackBar2.Maximum = 100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(288, 51);
            trackBar2.SmallChange = 5;
            trackBar2.TabIndex = 2;
            trackBar2.TickFrequency = 10;
            trackBar2.Value = 80;
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
            tableLayoutPanel4.Controls.Add(trackBar1, 3, 1);
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
            // lblVolumeMusique
            // 
            lblVolumeMusique.AutoSize = true;
            lblVolumeMusique.BackColor = Color.FromArgb(224, 224, 224);
            lblVolumeMusique.Dock = DockStyle.Fill;
            lblVolumeMusique.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVolumeMusique.Location = new Point(267, 7);
            lblVolumeMusique.Name = "lblVolumeMusique";
            lblVolumeMusique.Size = new Size(288, 57);
            lblVolumeMusique.TabIndex = 0;
            lblVolumeMusique.Text = "Volume Musique";
            lblVolumeMusique.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            trackBar1.Cursor = Cursors.Hand;
            trackBar1.Dock = DockStyle.Fill;
            trackBar1.LargeChange = 10;
            trackBar1.Location = new Point(619, 10);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(288, 51);
            trackBar1.SmallChange = 5;
            trackBar1.TabIndex = 2;
            trackBar1.TickFrequency = 10;
            trackBar1.Value = 80;
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
            SizeChanged += FormMenuVolume_SizeChanged;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnRetour;
        private Label lblVolumeEffets;
        private Label lblVolumeGlobal;
        private Label lblVolumeMusique;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private TrackBar trackBar3;
    }
}