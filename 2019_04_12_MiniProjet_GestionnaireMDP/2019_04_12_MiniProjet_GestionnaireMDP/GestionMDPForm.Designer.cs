namespace _2019_04_12_MiniProjet_GestionnaireMDP
{
    partial class Security
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
            this.LiteDBDataGridView = new System.Windows.Forms.DataGridView();
            this.SiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HashPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.Button();
            this.NomSite = new System.Windows.Forms.Label();
            this.NomUtilisateur = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.SiteInput = new System.Windows.Forms.TextBox();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.LiteDBDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // LiteDBDataGridView
            // 
            this.LiteDBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LiteDBDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SiteName,
            this.UserName,
            this.HashPassword});
            this.LiteDBDataGridView.Location = new System.Drawing.Point(32, 198);
            this.LiteDBDataGridView.Name = "LiteDBDataGridView";
            this.LiteDBDataGridView.Size = new System.Drawing.Size(609, 212);
            this.LiteDBDataGridView.TabIndex = 0;
            // 
            // SiteName
            // 
            this.SiteName.HeaderText = "Nom du site";
            this.SiteName.Name = "SiteName";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Nom d\'utilisateur";
            this.UserName.Name = "UserName";
            // 
            // HashPassword
            // 
            this.HashPassword.HeaderText = "MDP (Haché)";
            this.HashPassword.Name = "HashPassword";
            // 
            // Logo
            // 
            this.Logo.ImageLocation = "C:\\Users\\Clément\\OBS.PNG";
            this.Logo.Location = new System.Drawing.Point(32, 43);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(97, 101);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(386, 81);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(154, 63);
            this.Add.TabIndex = 2;
            this.Add.Text = "Ajouter";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.UserDataInput_Click);
            // 
            // NomSite
            // 
            this.NomSite.AutoSize = true;
            this.NomSite.Location = new System.Drawing.Point(203, 35);
            this.NomSite.Name = "NomSite";
            this.NomSite.Size = new System.Drawing.Size(63, 13);
            this.NomSite.TabIndex = 3;
            this.NomSite.Text = "Nom du site";
            // 
            // NomUtilisateur
            // 
            this.NomUtilisateur.AutoSize = true;
            this.NomUtilisateur.Location = new System.Drawing.Point(202, 74);
            this.NomUtilisateur.Name = "NomUtilisateur";
            this.NomUtilisateur.Size = new System.Drawing.Size(84, 13);
            this.NomUtilisateur.TabIndex = 4;
            this.NomUtilisateur.Text = "Nom d\'utilisateur";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(202, 109);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(71, 13);
            this.Password.TabIndex = 5;
            this.Password.Text = "Mot de passe";
            // 
            // SiteInput
            // 
            this.SiteInput.Location = new System.Drawing.Point(206, 51);
            this.SiteInput.Name = "SiteInput";
            this.SiteInput.Size = new System.Drawing.Size(126, 20);
            this.SiteInput.TabIndex = 6;
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(205, 86);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(126, 20);
            this.UserInput.TabIndex = 7;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(205, 124);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(126, 20);
            this.PasswordInput.TabIndex = 8;
            // 
            // Security
            // 
            this.ClientSize = new System.Drawing.Size(653, 422);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.SiteInput);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.NomUtilisateur);
            this.Controls.Add(this.NomSite);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.LiteDBDataGridView);
            this.Name = "Security";
            this.ShowIcon = false;
            this.Text = "OBSecurity - Gestionnaire de mots de passe";
            ((System.ComponentModel.ISupportInitialize)(this.LiteDBDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LiteDBDataGridView;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label NomSite;
        private System.Windows.Forms.Label NomUtilisateur;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox SiteInput;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HashPassword;
    }
}

