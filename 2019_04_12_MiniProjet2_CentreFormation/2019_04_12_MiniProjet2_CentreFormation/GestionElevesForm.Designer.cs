namespace _2019_04_12_MiniProjet2_CentreFormation
{
    partial class FenetreEleves
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
            this.PrenomEleve = new System.Windows.Forms.Label();
            this.NomEleve = new System.Windows.Forms.Label();
            this.DateNaissance = new System.Windows.Forms.Label();
            this.AdresseEleve = new System.Windows.Forms.Label();
            this.CodePostal = new System.Windows.Forms.Label();
            this.Ville = new System.Windows.Forms.Label();
            this.ElevesDGV = new System.Windows.Forms.DataGridView();
            this.AjoutEleve = new System.Windows.Forms.Button();
            this.ModifEleve = new System.Windows.Forms.Button();
            this.SuppressionEleve = new System.Windows.Forms.Button();
            this.NomEleveInput = new System.Windows.Forms.TextBox();
            this.AdresseInput = new System.Windows.Forms.TextBox();
            this.CodePostalInput = new System.Windows.Forms.TextBox();
            this.VilleInput = new System.Windows.Forms.TextBox();
            this.TelFixe = new System.Windows.Forms.Label();
            this.TelFixeInput = new System.Windows.Forms.TextBox();
            this.TelPortable = new System.Windows.Forms.Label();
            this.TelPortableInput = new System.Windows.Forms.TextBox();
            this.PrenomEleveInput = new System.Windows.Forms.TextBox();
            this.DateNaissancePicker = new System.Windows.Forms.DateTimePicker();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaissanceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VilleCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_fixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel_port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ElevesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PrenomEleve
            // 
            this.PrenomEleve.AutoSize = true;
            this.PrenomEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenomEleve.Location = new System.Drawing.Point(301, 29);
            this.PrenomEleve.Name = "PrenomEleve";
            this.PrenomEleve.Size = new System.Drawing.Size(49, 13);
            this.PrenomEleve.TabIndex = 0;
            this.PrenomEleve.Text = "Prénom";
            // 
            // NomEleve
            // 
            this.NomEleve.AutoSize = true;
            this.NomEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomEleve.Location = new System.Drawing.Point(301, 66);
            this.NomEleve.Name = "NomEleve";
            this.NomEleve.Size = new System.Drawing.Size(32, 13);
            this.NomEleve.TabIndex = 1;
            this.NomEleve.Text = "Nom";
            // 
            // DateNaissance
            // 
            this.DateNaissance.AutoSize = true;
            this.DateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNaissance.Location = new System.Drawing.Point(301, 109);
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Size = new System.Drawing.Size(113, 13);
            this.DateNaissance.TabIndex = 2;
            this.DateNaissance.Text = "Date de naissance";
            // 
            // AdresseEleve
            // 
            this.AdresseEleve.AutoSize = true;
            this.AdresseEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresseEleve.Location = new System.Drawing.Point(301, 150);
            this.AdresseEleve.Name = "AdresseEleve";
            this.AdresseEleve.Size = new System.Drawing.Size(52, 13);
            this.AdresseEleve.TabIndex = 3;
            this.AdresseEleve.Text = "Adresse";
            // 
            // CodePostal
            // 
            this.CodePostal.AutoSize = true;
            this.CodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodePostal.Location = new System.Drawing.Point(301, 190);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(74, 13);
            this.CodePostal.TabIndex = 4;
            this.CodePostal.Text = "Code postal";
            // 
            // Ville
            // 
            this.Ville.AutoSize = true;
            this.Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ville.Location = new System.Drawing.Point(301, 229);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(31, 13);
            this.Ville.TabIndex = 5;
            this.Ville.Text = "Ville";
            // 
            // ElevesDGV
            // 
            this.ElevesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElevesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Prénom,
            this.Nom,
            this.DateNaissanceCol,
            this.Adresse,
            this.CP,
            this.VilleCol,
            this.Tel_fixe,
            this.Tel_port});
            this.ElevesDGV.Location = new System.Drawing.Point(54, 383);
            this.ElevesDGV.Name = "ElevesDGV";
            this.ElevesDGV.Size = new System.Drawing.Size(948, 245);
            this.ElevesDGV.TabIndex = 6;
            // 
            // AjoutEleve
            // 
            this.AjoutEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjoutEleve.Location = new System.Drawing.Point(520, 91);
            this.AjoutEleve.Name = "AjoutEleve";
            this.AjoutEleve.Size = new System.Drawing.Size(211, 66);
            this.AjoutEleve.TabIndex = 7;
            this.AjoutEleve.Text = "AJOUTER ELEVE";
            this.AjoutEleve.UseVisualStyleBackColor = true;
            this.AjoutEleve.Click += new System.EventHandler(this.AjoutEleve_Click);
            // 
            // ModifEleve
            // 
            this.ModifEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifEleve.Location = new System.Drawing.Point(520, 162);
            this.ModifEleve.Name = "ModifEleve";
            this.ModifEleve.Size = new System.Drawing.Size(211, 65);
            this.ModifEleve.TabIndex = 8;
            this.ModifEleve.Text = "MODIFIER ELEVE";
            this.ModifEleve.UseVisualStyleBackColor = true;
            this.ModifEleve.Click += new System.EventHandler(this.ModifEleve_Click);
            // 
            // SuppressionEleve
            // 
            this.SuppressionEleve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppressionEleve.Location = new System.Drawing.Point(520, 233);
            this.SuppressionEleve.Name = "SuppressionEleve";
            this.SuppressionEleve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SuppressionEleve.Size = new System.Drawing.Size(211, 61);
            this.SuppressionEleve.TabIndex = 9;
            this.SuppressionEleve.Text = "SUPPRIMER ELEVE";
            this.SuppressionEleve.UseVisualStyleBackColor = true;
            this.SuppressionEleve.Click += new System.EventHandler(this.Suppression_Click);
            // 
            // NomEleveInput
            // 
            this.NomEleveInput.Location = new System.Drawing.Point(304, 83);
            this.NomEleveInput.Name = "NomEleveInput";
            this.NomEleveInput.Size = new System.Drawing.Size(201, 20);
            this.NomEleveInput.TabIndex = 11;
            // 
            // AdresseInput
            // 
            this.AdresseInput.Location = new System.Drawing.Point(304, 167);
            this.AdresseInput.Name = "AdresseInput";
            this.AdresseInput.Size = new System.Drawing.Size(201, 20);
            this.AdresseInput.TabIndex = 13;
            // 
            // CodePostalInput
            // 
            this.CodePostalInput.Location = new System.Drawing.Point(304, 206);
            this.CodePostalInput.Name = "CodePostalInput";
            this.CodePostalInput.Size = new System.Drawing.Size(201, 20);
            this.CodePostalInput.TabIndex = 14;
            // 
            // VilleInput
            // 
            this.VilleInput.Location = new System.Drawing.Point(304, 246);
            this.VilleInput.Name = "VilleInput";
            this.VilleInput.Size = new System.Drawing.Size(201, 20);
            this.VilleInput.TabIndex = 15;
            // 
            // TelFixe
            // 
            this.TelFixe.AutoSize = true;
            this.TelFixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelFixe.Location = new System.Drawing.Point(301, 269);
            this.TelFixe.Name = "TelFixe";
            this.TelFixe.Size = new System.Drawing.Size(91, 13);
            this.TelFixe.TabIndex = 16;
            this.TelFixe.Text = "Téléphone fixe";
            // 
            // TelFixeInput
            // 
            this.TelFixeInput.Location = new System.Drawing.Point(304, 285);
            this.TelFixeInput.Name = "TelFixeInput";
            this.TelFixeInput.Size = new System.Drawing.Size(201, 20);
            this.TelFixeInput.TabIndex = 17;
            // 
            // TelPortable
            // 
            this.TelPortable.AutoSize = true;
            this.TelPortable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelPortable.Location = new System.Drawing.Point(301, 308);
            this.TelPortable.Name = "TelPortable";
            this.TelPortable.Size = new System.Drawing.Size(117, 13);
            this.TelPortable.TabIndex = 18;
            this.TelPortable.Text = "Téléphone portable";
            // 
            // TelPortableInput
            // 
            this.TelPortableInput.Location = new System.Drawing.Point(304, 325);
            this.TelPortableInput.Name = "TelPortableInput";
            this.TelPortableInput.Size = new System.Drawing.Size(201, 20);
            this.TelPortableInput.TabIndex = 19;
            // 
            // PrenomEleveInput
            // 
            this.PrenomEleveInput.Location = new System.Drawing.Point(304, 45);
            this.PrenomEleveInput.Name = "PrenomEleveInput";
            this.PrenomEleveInput.Size = new System.Drawing.Size(201, 20);
            this.PrenomEleveInput.TabIndex = 20;
            // 
            // DateNaissancePicker
            // 
            this.DateNaissancePicker.Location = new System.Drawing.Point(304, 125);
            this.DateNaissancePicker.Name = "DateNaissancePicker";
            this.DateNaissancePicker.Size = new System.Drawing.Size(200, 20);
            this.DateNaissancePicker.TabIndex = 21;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // DateNaissanceCol
            // 
            this.DateNaissanceCol.HeaderText = "Date de naissance";
            this.DateNaissanceCol.Name = "DateNaissanceCol";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            // 
            // CP
            // 
            this.CP.HeaderText = "Code postal";
            this.CP.Name = "CP";
            // 
            // VilleCol
            // 
            this.VilleCol.HeaderText = "Ville";
            this.VilleCol.Name = "VilleCol";
            // 
            // Tel_fixe
            // 
            this.Tel_fixe.HeaderText = "Tel fixe";
            this.Tel_fixe.Name = "Tel_fixe";
            // 
            // Tel_port
            // 
            this.Tel_port.HeaderText = "Tel portable";
            this.Tel_port.Name = "Tel_port";
            // 
            // FenetreEleves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 640);
            this.Controls.Add(this.DateNaissancePicker);
            this.Controls.Add(this.PrenomEleveInput);
            this.Controls.Add(this.TelPortableInput);
            this.Controls.Add(this.TelPortable);
            this.Controls.Add(this.TelFixeInput);
            this.Controls.Add(this.TelFixe);
            this.Controls.Add(this.VilleInput);
            this.Controls.Add(this.CodePostalInput);
            this.Controls.Add(this.AdresseInput);
            this.Controls.Add(this.NomEleveInput);
            this.Controls.Add(this.SuppressionEleve);
            this.Controls.Add(this.ModifEleve);
            this.Controls.Add(this.AjoutEleve);
            this.Controls.Add(this.ElevesDGV);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.CodePostal);
            this.Controls.Add(this.AdresseEleve);
            this.Controls.Add(this.DateNaissance);
            this.Controls.Add(this.NomEleve);
            this.Controls.Add(this.PrenomEleve);
            this.Name = "FenetreEleves";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des données élèves";
            ((System.ComponentModel.ISupportInitialize)(this.ElevesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrenomEleve;
        private System.Windows.Forms.Label NomEleve;
        private System.Windows.Forms.Label DateNaissance;
        private System.Windows.Forms.Label AdresseEleve;
        private System.Windows.Forms.Label CodePostal;
        private System.Windows.Forms.Label Ville;
        private System.Windows.Forms.DataGridView ElevesDGV;
        private System.Windows.Forms.Button AjoutEleve;
        private System.Windows.Forms.Button ModifEleve;
        private System.Windows.Forms.Button SuppressionEleve;
        private System.Windows.Forms.TextBox NomEleveInput;
        private System.Windows.Forms.TextBox AdresseInput;
        private System.Windows.Forms.TextBox CodePostalInput;
        private System.Windows.Forms.TextBox VilleInput;
        private System.Windows.Forms.Label TelFixe;
        private System.Windows.Forms.TextBox TelFixeInput;
        private System.Windows.Forms.Label TelPortable;
        private System.Windows.Forms.TextBox TelPortableInput;
        private System.Windows.Forms.TextBox PrenomEleveInput;
        private System.Windows.Forms.DateTimePicker DateNaissancePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaissanceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn VilleCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_fixe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel_port;
    }
}

