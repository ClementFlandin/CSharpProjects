namespace _2019_04_09_DefiWinFormsHorlogeParlante
{
    partial class Fenetre
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
            this.ButtonSayDate = new System.Windows.Forms.Button();
            this.ButtonSayDay = new System.Windows.Forms.Button();
            this.ButtonSayHour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSayDate
            // 
            this.ButtonSayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSayDate.Location = new System.Drawing.Point(53, 22);
            this.ButtonSayDate.Name = "ButtonSayDate";
            this.ButtonSayDate.Size = new System.Drawing.Size(314, 84);
            this.ButtonSayDate.TabIndex = 0;
            this.ButtonSayDate.Text = "Dire la date";
            this.ButtonSayDate.UseVisualStyleBackColor = true;
            this.ButtonSayDate.Click += new System.EventHandler(this.SpeechButtonSayDate_Click);
            // 
            // ButtonSayDay
            // 
            this.ButtonSayDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSayDay.Location = new System.Drawing.Point(53, 121);
            this.ButtonSayDay.Name = "ButtonSayDay";
            this.ButtonSayDay.Size = new System.Drawing.Size(314, 84);
            this.ButtonSayDay.TabIndex = 1;
            this.ButtonSayDay.Text = "Dire le jour";
            this.ButtonSayDay.UseVisualStyleBackColor = true;
            this.ButtonSayDay.Click += new System.EventHandler(this.SpeechButtonSayDay_Click);
            // 
            // ButtonSayHour
            // 
            this.ButtonSayHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSayHour.Location = new System.Drawing.Point(53, 222);
            this.ButtonSayHour.Name = "ButtonSayHour";
            this.ButtonSayHour.Size = new System.Drawing.Size(314, 84);
            this.ButtonSayHour.TabIndex = 2;
            this.ButtonSayHour.Text = "Dire l\'heure";
            this.ButtonSayHour.UseVisualStyleBackColor = true;
            this.ButtonSayHour.Click += new System.EventHandler(this.SpeechButtonSayHour_Click);
            // 
            // Fenetre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 356);
            this.Controls.Add(this.ButtonSayHour);
            this.Controls.Add(this.ButtonSayDay);
            this.Controls.Add(this.ButtonSayDate);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Fenetre";
            this.ShowIcon = false;
            this.Text = "Horloge Parlante";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSayDate;
        private System.Windows.Forms.Button ButtonSayDay;
        private System.Windows.Forms.Button ButtonSayHour;
    }
}

