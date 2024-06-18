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
            lblUserPseudo = new Label();
            lblDateCreation = new Label();
            roundTableLayoutPanel1 = new Bibliotheque_PacMan.RoundTableLayoutPanel();
            roundTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // roundTableLayoutPanel1
            // 
            roundTableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            roundTableLayoutPanel1.BorderColor = Color.Transparent;
            roundTableLayoutPanel1.BorderRadius = 90;
            roundTableLayoutPanel1.BorderWidth = 0;
            roundTableLayoutPanel1.ColumnCount = 3;
            roundTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            roundTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            roundTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            roundTableLayoutPanel1.Controls.Add(lblDateCreation, 1, 2);
            roundTableLayoutPanel1.Controls.Add(lblUserPseudo, 1, 1);
            roundTableLayoutPanel1.Dock = DockStyle.Fill;
            roundTableLayoutPanel1.Location = new Point(0, 0);
            roundTableLayoutPanel1.Margin = new Padding(0);
            roundTableLayoutPanel1.Name = "roundTableLayoutPanel1";
            roundTableLayoutPanel1.RowCount = 4;
            roundTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            roundTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            roundTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            roundTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            roundTableLayoutPanel1.Size = new Size(380, 180);
            roundTableLayoutPanel1.TabIndex = 1;
            roundTableLayoutPanel1.MouseEnter += UserControlSauvegarde_MouseEnter;
            roundTableLayoutPanel1.MouseLeave += UserControlSauvegarde_MouseLeave;
            // 
            // UserControlSauvegarde
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(roundTableLayoutPanel1);
            Name = "UserControlSauvegarde";
            Size = new Size(380, 180);
            SizeChanged += UserControlSauvegarde_SizeChanged;
            Click += UserControlSauvegarde_Click;
            MouseEnter += UserControlSauvegarde_MouseEnter;
            MouseLeave += UserControlSauvegarde_MouseLeave;
            roundTableLayoutPanel1.ResumeLayout(false);
            roundTableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblUserPseudo;
        private Label lblDateCreation;
        private Bibliotheque_PacMan.RoundTableLayoutPanel roundTableLayoutPanel1;
    }
}
