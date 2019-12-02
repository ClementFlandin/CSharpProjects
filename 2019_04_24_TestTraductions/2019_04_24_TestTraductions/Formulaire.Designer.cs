namespace _2019_04_24_TestTraductions
{
    partial class Formulaire
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
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.LanguagesAvailable = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(92, 90);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(55, 13);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First name";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(92, 163);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(56, 13);
            this.LastName.TabIndex = 1;
            this.LastName.Text = "Last name";
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Location = new System.Drawing.Point(357, 90);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(55, 13);
            this.Language.TabIndex = 2;
            this.Language.Text = "Language";
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(95, 255);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(126, 54);
            this.Button.TabIndex = 3;
            this.Button.Text = "BUTTON";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(95, 107);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(126, 20);
            this.textbox1.TabIndex = 4;
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(95, 180);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(126, 20);
            this.textbox2.TabIndex = 5;
            // 
            // LanguagesAvailable
            // 
            this.LanguagesAvailable.FormattingEnabled = true;
            this.LanguagesAvailable.Location = new System.Drawing.Point(360, 105);
            this.LanguagesAvailable.Name = "LanguagesAvailable";
            this.LanguagesAvailable.Size = new System.Drawing.Size(121, 21);
            this.LanguagesAvailable.TabIndex = 6;
            this.LanguagesAvailable.TextChanged += new System.EventHandler(this.LanguagesAvailable_TextChanged);
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 392);
            this.Controls.Add(this.LanguagesAvailable);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Name = "Formulaire";
            this.Text = "Formulaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.ComboBox LanguagesAvailable;
    }
}

