namespace Interface_PacMan
{
    partial class UserControlButton : System.Windows.Forms.UserControl
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
            roundButton1 = new Bibliotheque_PacMan.RoundButton();
            SuspendLayout();
            // 
            // roundButton1
            // 
            roundButton1.BackColor = Color.FromArgb(224, 224, 224);
            roundButton1.Dock = DockStyle.Fill;
            roundButton1.Location = new Point(0, 0);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(200, 200);
            roundButton1.TabIndex = 0;
            roundButton1.UseVisualStyleBackColor = false;
            roundButton1.Click += roundButton1_Click;
            roundButton1.MouseEnter += roundButton1_MouseEnter;
            roundButton1.MouseLeave += roundButton1_MouseLeave;
            // 
            // UserControlButton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(roundButton1);
            Name = "UserControlButton";
            Size = new Size(200, 200);
            ResumeLayout(false);
        }

        #endregion

        private Bibliotheque_PacMan.RoundButton roundButton1;
    }
}
