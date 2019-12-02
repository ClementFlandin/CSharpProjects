namespace _2019_04_22_DefiWinformMySQL
{
    partial class LaFerme
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
            this.NouvelleEspeceTB = new System.Windows.Forms.TextBox();
            this.NouvelleEspece = new System.Windows.Forms.Label();
            this.AjoutEspece = new System.Windows.Forms.Button();
            this.NouvelAnimal = new System.Windows.Forms.Label();
            this.NouvelAnimalTB = new System.Windows.Forms.TextBox();
            this.EspeceDeLAnimal = new System.Windows.Forms.Label();
            this.EspeceDeLAnimalCB = new System.Windows.Forms.ComboBox();
            this.AjoutAnimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NouvelleEspeceTB
            // 
            this.NouvelleEspeceTB.Location = new System.Drawing.Point(65, 91);
            this.NouvelleEspeceTB.Name = "NouvelleEspeceTB";
            this.NouvelleEspeceTB.Size = new System.Drawing.Size(161, 20);
            this.NouvelleEspeceTB.TabIndex = 0;
            // 
            // NouvelleEspece
            // 
            this.NouvelleEspece.AutoSize = true;
            this.NouvelleEspece.Location = new System.Drawing.Point(65, 72);
            this.NouvelleEspece.Name = "NouvelleEspece";
            this.NouvelleEspece.Size = new System.Drawing.Size(87, 13);
            this.NouvelleEspece.TabIndex = 1;
            this.NouvelleEspece.Text = "Nouvelle espèce";
            // 
            // AjoutEspece
            // 
            this.AjoutEspece.Location = new System.Drawing.Point(65, 167);
            this.AjoutEspece.Name = "AjoutEspece";
            this.AjoutEspece.Size = new System.Drawing.Size(161, 65);
            this.AjoutEspece.TabIndex = 2;
            this.AjoutEspece.Text = "AJOUTER ESPECE";
            this.AjoutEspece.UseVisualStyleBackColor = true;
            this.AjoutEspece.Click += new System.EventHandler(this.AjoutEspece_Click);
            // 
            // NouvelAnimal
            // 
            this.NouvelAnimal.AutoSize = true;
            this.NouvelAnimal.Location = new System.Drawing.Point(388, 72);
            this.NouvelAnimal.Name = "NouvelAnimal";
            this.NouvelAnimal.Size = new System.Drawing.Size(74, 13);
            this.NouvelAnimal.TabIndex = 4;
            this.NouvelAnimal.Text = "Nouvel animal";
            // 
            // NouvelAnimalTB
            // 
            this.NouvelAnimalTB.Location = new System.Drawing.Point(388, 91);
            this.NouvelAnimalTB.Name = "NouvelAnimalTB";
            this.NouvelAnimalTB.Size = new System.Drawing.Size(179, 20);
            this.NouvelAnimalTB.TabIndex = 3;
            // 
            // EspeceDeLAnimal
            // 
            this.EspeceDeLAnimal.AutoSize = true;
            this.EspeceDeLAnimal.Location = new System.Drawing.Point(388, 126);
            this.EspeceDeLAnimal.Name = "EspeceDeLAnimal";
            this.EspeceDeLAnimal.Size = new System.Drawing.Size(95, 13);
            this.EspeceDeLAnimal.TabIndex = 5;
            this.EspeceDeLAnimal.Text = "Espèce de l\'animal";
            // 
            // EspeceDeLAnimalCB
            // 
            this.EspeceDeLAnimalCB.FormattingEnabled = true;
            this.EspeceDeLAnimalCB.Location = new System.Drawing.Point(388, 143);
            this.EspeceDeLAnimalCB.Name = "EspeceDeLAnimalCB";
            this.EspeceDeLAnimalCB.Size = new System.Drawing.Size(179, 21);
            this.EspeceDeLAnimalCB.TabIndex = 6;
            // 
            // AjoutAnimal
            // 
            this.AjoutAnimal.Location = new System.Drawing.Point(388, 171);
            this.AjoutAnimal.Name = "AjoutAnimal";
            this.AjoutAnimal.Size = new System.Drawing.Size(179, 61);
            this.AjoutAnimal.TabIndex = 7;
            this.AjoutAnimal.Text = "AJOUTER ANIMAL";
            this.AjoutAnimal.UseVisualStyleBackColor = true;
            this.AjoutAnimal.Click += new System.EventHandler(this.AjoutAnimal_Click);
            // 
            // LaFerme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 361);
            this.Controls.Add(this.AjoutAnimal);
            this.Controls.Add(this.EspeceDeLAnimalCB);
            this.Controls.Add(this.EspeceDeLAnimal);
            this.Controls.Add(this.NouvelAnimal);
            this.Controls.Add(this.NouvelAnimalTB);
            this.Controls.Add(this.AjoutEspece);
            this.Controls.Add(this.NouvelleEspece);
            this.Controls.Add(this.NouvelleEspeceTB);
            this.Name = "LaFerme";
            this.ShowIcon = false;
            this.Text = "Bienvenue à la ferme!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LaFerme_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NouvelleEspeceTB;
        private System.Windows.Forms.Label NouvelleEspece;
        private System.Windows.Forms.Button AjoutEspece;
        private System.Windows.Forms.Label NouvelAnimal;
        private System.Windows.Forms.TextBox NouvelAnimalTB;
        private System.Windows.Forms.Label EspeceDeLAnimal;
        private System.Windows.Forms.ComboBox EspeceDeLAnimalCB;
        private System.Windows.Forms.Button AjoutAnimal;
    }
}

