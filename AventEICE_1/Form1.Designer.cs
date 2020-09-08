namespace AventEICE_1
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1_git_test = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_git_test
            // 
            this.label1_git_test.AutoSize = true;
            this.label1_git_test.Location = new System.Drawing.Point(62, 48);
            this.label1_git_test.Name = "label1_git_test";
            this.label1_git_test.Size = new System.Drawing.Size(68, 13);
            this.label1_git_test.TabIndex = 0;
            this.label1_git_test.Text = "Label de test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1_git_test);
            this.Name = "Form1";
            this.Text = "Les aventuriers de l\'EICE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_git_test;
    }
}

