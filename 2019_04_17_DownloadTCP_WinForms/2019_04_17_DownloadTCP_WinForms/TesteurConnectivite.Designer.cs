namespace _2019_04_17_DownloadTCP_WinForms
{
    partial class TestDownload
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
            this.TestDeTelechargement = new System.Windows.Forms.Button();
            this.TestGoogle = new System.Windows.Forms.Button();
            this.TestElythe = new System.Windows.Forms.Button();
            this.TestCalypso = new System.Windows.Forms.Button();
            this.MessagesConnectivites = new System.Windows.Forms.RichTextBox();
            this.VitesseTelechargement = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // TestDeTelechargement
            // 
            this.TestDeTelechargement.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestDeTelechargement.Location = new System.Drawing.Point(229, 46);
            this.TestDeTelechargement.Name = "TestDeTelechargement";
            this.TestDeTelechargement.Size = new System.Drawing.Size(224, 78);
            this.TestDeTelechargement.TabIndex = 0;
            this.TestDeTelechargement.Text = "Testez la vitesse de téléchargement";
            this.TestDeTelechargement.UseVisualStyleBackColor = true;
            this.TestDeTelechargement.Click += new System.EventHandler(this.TestDeTelechargement_Click);
            // 
            // TestGoogle
            // 
            this.TestGoogle.Location = new System.Drawing.Point(229, 162);
            this.TestGoogle.Name = "TestGoogle";
            this.TestGoogle.Size = new System.Drawing.Size(224, 32);
            this.TestGoogle.TabIndex = 1;
            this.TestGoogle.Text = "Test connection à Google.com";
            this.TestGoogle.UseVisualStyleBackColor = true;
            this.TestGoogle.Click += new System.EventHandler(this.TestGoogle_Click);
            // 
            // TestElythe
            // 
            this.TestElythe.Location = new System.Drawing.Point(229, 200);
            this.TestElythe.Name = "TestElythe";
            this.TestElythe.Size = new System.Drawing.Size(224, 32);
            this.TestElythe.TabIndex = 2;
            this.TestElythe.Text = "Test connection à Elythe.com";
            this.TestElythe.UseVisualStyleBackColor = true;
            this.TestElythe.Click += new System.EventHandler(this.TestElythe_Click);
            // 
            // TestCalypso
            // 
            this.TestCalypso.Location = new System.Drawing.Point(229, 238);
            this.TestCalypso.Name = "TestCalypso";
            this.TestCalypso.Size = new System.Drawing.Size(224, 32);
            this.TestCalypso.TabIndex = 3;
            this.TestCalypso.Text = "Test connection à Calypso3d.fr";
            this.TestCalypso.UseVisualStyleBackColor = true;
            this.TestCalypso.Click += new System.EventHandler(this.TestCalypso_Click);
            // 
            // MessagesConnectivites
            // 
            this.MessagesConnectivites.Location = new System.Drawing.Point(495, 46);
            this.MessagesConnectivites.Name = "MessagesConnectivites";
            this.MessagesConnectivites.Size = new System.Drawing.Size(227, 224);
            this.MessagesConnectivites.TabIndex = 4;
            this.MessagesConnectivites.Text = "";
            // 
            // VitesseTelechargement
            // 
            this.VitesseTelechargement.Location = new System.Drawing.Point(229, 130);
            this.VitesseTelechargement.Name = "VitesseTelechargement";
            this.VitesseTelechargement.Size = new System.Drawing.Size(224, 23);
            this.VitesseTelechargement.TabIndex = 5;
            // 
            // TestDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VitesseTelechargement);
            this.Controls.Add(this.MessagesConnectivites);
            this.Controls.Add(this.TestCalypso);
            this.Controls.Add(this.TestElythe);
            this.Controls.Add(this.TestGoogle);
            this.Controls.Add(this.TestDeTelechargement);
            this.Name = "TestDownload";
            this.ShowIcon = false;
            this.Text = "Test de connectivité";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestDeTelechargement;
        private System.Windows.Forms.Button TestGoogle;
        private System.Windows.Forms.Button TestElythe;
        private System.Windows.Forms.Button TestCalypso;
        private System.Windows.Forms.RichTextBox MessagesConnectivites;
        private System.Windows.Forms.ProgressBar VitesseTelechargement;
    }
}

