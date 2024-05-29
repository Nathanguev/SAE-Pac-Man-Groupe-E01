namespace Interface_PacMan
{
    partial class UserControlSauvegarde
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lblUserPseudo = new Label();
            lblDateCreation = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(lblUserPseudo, 1, 1);
            tableLayoutPanel1.Controls.Add(lblDateCreation, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(380, 180);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Click += UserControlSauvegarde_Click;
            tableLayoutPanel1.MouseEnter += UserControlSauvegarde_MouseEnter;
            tableLayoutPanel1.MouseLeave += UserControlSauvegarde_MouseLeave;
            // 
            // lblUserPseudo
            // 
            lblUserPseudo.AutoSize = true;
            lblUserPseudo.BackColor = Color.Transparent;
            lblUserPseudo.Dock = DockStyle.Fill;
            lblUserPseudo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUserPseudo.Location = new Point(41, 30);
            lblUserPseudo.Margin = new Padding(3);
            lblUserPseudo.Name = "lblUserPseudo";
            lblUserPseudo.Size = new Size(298, 57);
            lblUserPseudo.TabIndex = 0;
            lblUserPseudo.Text = "UserPseudo";
            lblUserPseudo.TextAlign = ContentAlignment.MiddleCenter;
            lblUserPseudo.Click += UserControlSauvegarde_Click;
            lblUserPseudo.MouseEnter += UserControlSauvegarde_MouseEnter;
            lblUserPseudo.MouseLeave += UserControlSauvegarde_MouseLeave;
            // 
            // lblDateCreation
            // 
            lblDateCreation.AutoSize = true;
            lblDateCreation.BackColor = Color.Transparent;
            lblDateCreation.Dock = DockStyle.Fill;
            lblDateCreation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDateCreation.Location = new Point(41, 93);
            lblDateCreation.Margin = new Padding(3);
            lblDateCreation.Name = "lblDateCreation";
            lblDateCreation.Size = new Size(298, 57);
            lblDateCreation.TabIndex = 1;
            lblDateCreation.Text = "DateCreation";
            lblDateCreation.TextAlign = ContentAlignment.MiddleCenter;
            lblDateCreation.Click += UserControlSauvegarde_Click;
            lblDateCreation.MouseEnter += UserControlSauvegarde_MouseEnter;
            lblDateCreation.MouseLeave += UserControlSauvegarde_MouseLeave;
            // 
            // UserControlSauvegarde
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "UserControlSauvegarde";
            Size = new Size(380, 180);
            SizeChanged += UserControlSauvegarde_SizeChanged;
            Click += UserControlSauvegarde_Click;
            MouseEnter += UserControlSauvegarde_MouseEnter;
            MouseLeave += UserControlSauvegarde_MouseLeave;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblUserPseudo;
        private Label lblDateCreation;
    }
}
