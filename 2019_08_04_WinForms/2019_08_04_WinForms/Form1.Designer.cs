namespace _2019_08_04_WinForms
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
            this.m_myTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_myTestButton
            // 
            this.m_myTestButton.Location = new System.Drawing.Point(27, 27);
            this.m_myTestButton.Name = "m_myTestButton";
            this.m_myTestButton.Size = new System.Drawing.Size(157, 35);
            this.m_myTestButton.TabIndex = 0;
            this.m_myTestButton.Text = "button1";
            this.m_myTestButton.UseVisualStyleBackColor = true;
            this.m_myTestButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_myTestButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_myTestButton;
    }
}

