namespace OBFormation
{
    partial class OBFormationForm
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
            this.OBFormationTab = new System.Windows.Forms.TabControl();
            this.FormationsTab = new System.Windows.Forms.TabPage();
            this.StudentsRegisteredLabel = new System.Windows.Forms.Label();
            this.StudentsRegisteredDGV = new System.Windows.Forms.DataGridView();
            this.IdStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsMobilePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateDTP = new System.Windows.Forms.Label();
            this.StartDateDTP = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.FormationDescriptionLabel = new System.Windows.Forms.Label();
            this.FormationTitleLabel = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.RemoveFormationButton = new System.Windows.Forms.Button();
            this.ModifyFormationButton = new System.Windows.Forms.Button();
            this.AddFormationButton = new System.Windows.Forms.Button();
            this.FormationsDGV = new System.Windows.Forms.DataGridView();
            this.FormationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormationTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormationDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentsTab = new System.Windows.Forms.TabPage();
            this.RemoveStudentFromFormationButton = new System.Windows.Forms.Button();
            this.AddStudentToFormationButton = new System.Windows.Forms.Button();
            this.SelectFormation = new System.Windows.Forms.Label();
            this.SelectFormationCB = new System.Windows.Forms.ComboBox();
            this.StudentsDGV = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobilePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveStudentButton = new System.Windows.Forms.Button();
            this.ModifyStudentButton = new System.Windows.Forms.Button();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.StudentMobilePhone = new System.Windows.Forms.Label();
            this.StudentPhone = new System.Windows.Forms.Label();
            this.StudentCity = new System.Windows.Forms.Label();
            this.StudentPostalCode = new System.Windows.Forms.Label();
            this.StudentAddress = new System.Windows.Forms.Label();
            this.StudentBirthday = new System.Windows.Forms.Label();
            this.StudentFirstName = new System.Windows.Forms.Label();
            this.StudentLastName = new System.Windows.Forms.Label();
            this.StudentMobilePhoneTB = new System.Windows.Forms.TextBox();
            this.StudentPhoneTB = new System.Windows.Forms.TextBox();
            this.StudentCityTB = new System.Windows.Forms.TextBox();
            this.StudentPostalCodeTB = new System.Windows.Forms.TextBox();
            this.StudentAddressRTB = new System.Windows.Forms.RichTextBox();
            this.StudentBirthdayDTP = new System.Windows.Forms.DateTimePicker();
            this.StudentFirstNameTB = new System.Windows.Forms.TextBox();
            this.StudentLastNameTB = new System.Windows.Forms.TextBox();
            this.TeachersTab = new System.Windows.Forms.TabPage();
            this.TeacherFirstNameTB = new System.Windows.Forms.TextBox();
            this.TeacherLastNameTB = new System.Windows.Forms.TextBox();
            this.TeacherLastNameLabel = new System.Windows.Forms.Label();
            this.TeacherFirstNameLabel = new System.Windows.Forms.Label();
            this.RemoveTeacherButton = new System.Windows.Forms.Button();
            this.ModifyTeacherButton = new System.Windows.Forms.Button();
            this.AddTeacherButton = new System.Windows.Forms.Button();
            this.TeachersDGV = new System.Windows.Forms.DataGridView();
            this.IdTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectLanguageCB = new System.Windows.Forms.ComboBox();
            this.SelectLanguageLabel = new System.Windows.Forms.Label();
            this.OBFormationTab.SuspendLayout();
            this.FormationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsRegisteredDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormationsDGV)).BeginInit();
            this.StudentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).BeginInit();
            this.TeachersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // OBFormationTab
            // 
            this.OBFormationTab.Controls.Add(this.FormationsTab);
            this.OBFormationTab.Controls.Add(this.StudentsTab);
            this.OBFormationTab.Controls.Add(this.TeachersTab);
            this.OBFormationTab.Location = new System.Drawing.Point(7, 39);
            this.OBFormationTab.Name = "OBFormationTab";
            this.OBFormationTab.SelectedIndex = 0;
            this.OBFormationTab.Size = new System.Drawing.Size(1442, 569);
            this.OBFormationTab.TabIndex = 0;
            // 
            // FormationsTab
            // 
            this.FormationsTab.Controls.Add(this.StudentsRegisteredLabel);
            this.FormationsTab.Controls.Add(this.StudentsRegisteredDGV);
            this.FormationsTab.Controls.Add(this.EndDateDTP);
            this.FormationsTab.Controls.Add(this.StartDateDTP);
            this.FormationsTab.Controls.Add(this.dateTimePicker);
            this.FormationsTab.Controls.Add(this.dateTimePicker1);
            this.FormationsTab.Controls.Add(this.FormationDescriptionLabel);
            this.FormationsTab.Controls.Add(this.FormationTitleLabel);
            this.FormationsTab.Controls.Add(this.richTextBox2);
            this.FormationsTab.Controls.Add(this.richTextBox1);
            this.FormationsTab.Controls.Add(this.RemoveFormationButton);
            this.FormationsTab.Controls.Add(this.ModifyFormationButton);
            this.FormationsTab.Controls.Add(this.AddFormationButton);
            this.FormationsTab.Controls.Add(this.FormationsDGV);
            this.FormationsTab.Location = new System.Drawing.Point(4, 22);
            this.FormationsTab.Name = "FormationsTab";
            this.FormationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.FormationsTab.Size = new System.Drawing.Size(1434, 543);
            this.FormationsTab.TabIndex = 0;
            this.FormationsTab.Text = "Formations";
            this.FormationsTab.UseVisualStyleBackColor = true;
            // 
            // StudentsRegisteredLabel
            // 
            this.StudentsRegisteredLabel.AutoSize = true;
            this.StudentsRegisteredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsRegisteredLabel.Location = new System.Drawing.Point(624, 27);
            this.StudentsRegisteredLabel.Name = "StudentsRegisteredLabel";
            this.StudentsRegisteredLabel.Size = new System.Drawing.Size(327, 20);
            this.StudentsRegisteredLabel.TabIndex = 13;
            this.StudentsRegisteredLabel.Text = "Students registered in the selected formation";
            // 
            // StudentsRegisteredDGV
            // 
            this.StudentsRegisteredDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsRegisteredDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdStudent,
            this.StudentsLastName,
            this.StudentsFirstName,
            this.StudentsBirthDate,
            this.StudentsAddress,
            this.StudentsPostalCode,
            this.StudentsCity,
            this.StudentsPhone,
            this.StudentsMobilePhone});
            this.StudentsRegisteredDGV.Location = new System.Drawing.Point(574, 58);
            this.StudentsRegisteredDGV.Name = "StudentsRegisteredDGV";
            this.StudentsRegisteredDGV.Size = new System.Drawing.Size(845, 482);
            this.StudentsRegisteredDGV.TabIndex = 12;
            // 
            // IdStudent
            // 
            this.IdStudent.HeaderText = "Id";
            this.IdStudent.Name = "IdStudent";
            this.IdStudent.Width = 40;
            // 
            // StudentsLastName
            // 
            this.StudentsLastName.HeaderText = "Last name";
            this.StudentsLastName.Name = "StudentsLastName";
            // 
            // StudentsFirstName
            // 
            this.StudentsFirstName.HeaderText = "First name";
            this.StudentsFirstName.Name = "StudentsFirstName";
            // 
            // StudentsBirthDate
            // 
            this.StudentsBirthDate.HeaderText = "Birthday";
            this.StudentsBirthDate.Name = "StudentsBirthDate";
            // 
            // StudentsAddress
            // 
            this.StudentsAddress.HeaderText = "Address";
            this.StudentsAddress.Name = "StudentsAddress";
            // 
            // StudentsPostalCode
            // 
            this.StudentsPostalCode.HeaderText = "Postal code";
            this.StudentsPostalCode.Name = "StudentsPostalCode";
            this.StudentsPostalCode.Width = 60;
            // 
            // StudentsCity
            // 
            this.StudentsCity.HeaderText = "City";
            this.StudentsCity.Name = "StudentsCity";
            // 
            // StudentsPhone
            // 
            this.StudentsPhone.HeaderText = "Phone";
            this.StudentsPhone.Name = "StudentsPhone";
            // 
            // StudentsMobilePhone
            // 
            this.StudentsMobilePhone.HeaderText = "Mobile phone";
            this.StudentsMobilePhone.Name = "StudentsMobilePhone";
            // 
            // EndDateDTP
            // 
            this.EndDateDTP.AutoSize = true;
            this.EndDateDTP.Location = new System.Drawing.Point(324, 72);
            this.EndDateDTP.Name = "EndDateDTP";
            this.EndDateDTP.Size = new System.Drawing.Size(52, 13);
            this.EndDateDTP.TabIndex = 11;
            this.EndDateDTP.Text = "End Date";
            // 
            // StartDateDTP
            // 
            this.StartDateDTP.AutoSize = true;
            this.StartDateDTP.Location = new System.Drawing.Point(323, 27);
            this.StartDateDTP.Name = "StartDateDTP";
            this.StartDateDTP.Size = new System.Drawing.Size(53, 13);
            this.StartDateDTP.TabIndex = 10;
            this.StartDateDTP.Text = "Start date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(326, 43);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(327, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // FormationDescriptionLabel
            // 
            this.FormationDescriptionLabel.AutoSize = true;
            this.FormationDescriptionLabel.Location = new System.Drawing.Point(160, 28);
            this.FormationDescriptionLabel.Name = "FormationDescriptionLabel";
            this.FormationDescriptionLabel.Size = new System.Drawing.Size(107, 13);
            this.FormationDescriptionLabel.TabIndex = 7;
            this.FormationDescriptionLabel.Text = "Formation description";
            // 
            // FormationTitleLabel
            // 
            this.FormationTitleLabel.AutoSize = true;
            this.FormationTitleLabel.Location = new System.Drawing.Point(11, 27);
            this.FormationTitleLabel.Name = "FormationTitleLabel";
            this.FormationTitleLabel.Size = new System.Drawing.Size(72, 13);
            this.FormationTitleLabel.TabIndex = 6;
            this.FormationTitleLabel.Text = "Formation title";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(163, 43);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(145, 65);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(143, 65);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // RemoveFormationButton
            // 
            this.RemoveFormationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFormationButton.ForeColor = System.Drawing.Color.Red;
            this.RemoveFormationButton.Location = new System.Drawing.Point(355, 125);
            this.RemoveFormationButton.Name = "RemoveFormationButton";
            this.RemoveFormationButton.Size = new System.Drawing.Size(136, 54);
            this.RemoveFormationButton.TabIndex = 3;
            this.RemoveFormationButton.Text = "REMOVE FORMATION";
            this.RemoveFormationButton.UseVisualStyleBackColor = true;
            this.RemoveFormationButton.Click += new System.EventHandler(this.RemoveFormationButton_Click);
            // 
            // ModifyFormationButton
            // 
            this.ModifyFormationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyFormationButton.Location = new System.Drawing.Point(217, 125);
            this.ModifyFormationButton.Name = "ModifyFormationButton";
            this.ModifyFormationButton.Size = new System.Drawing.Size(132, 54);
            this.ModifyFormationButton.TabIndex = 2;
            this.ModifyFormationButton.Text = "MODIFY FORMATION";
            this.ModifyFormationButton.UseVisualStyleBackColor = true;
            this.ModifyFormationButton.Click += new System.EventHandler(this.ModifyFormationButton_Click);
            // 
            // AddFormationButton
            // 
            this.AddFormationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFormationButton.Location = new System.Drawing.Point(84, 125);
            this.AddFormationButton.Name = "AddFormationButton";
            this.AddFormationButton.Size = new System.Drawing.Size(127, 54);
            this.AddFormationButton.TabIndex = 1;
            this.AddFormationButton.Text = "ADD FORMATION";
            this.AddFormationButton.UseVisualStyleBackColor = true;
            this.AddFormationButton.Click += new System.EventHandler(this.AddFormationButton_Click);
            // 
            // FormationsDGV
            // 
            this.FormationsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormationsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FormationId,
            this.FormationTitle,
            this.FormationDescription,
            this.StartDate,
            this.EndDate});
            this.FormationsDGV.Location = new System.Drawing.Point(0, 207);
            this.FormationsDGV.Name = "FormationsDGV";
            this.FormationsDGV.Size = new System.Drawing.Size(568, 330);
            this.FormationsDGV.TabIndex = 0;
            this.FormationsDGV.Click += new System.EventHandler(this.FormationsDGV_Click);
            // 
            // FormationId
            // 
            this.FormationId.HeaderText = "Id";
            this.FormationId.Name = "FormationId";
            this.FormationId.Width = 45;
            // 
            // FormationTitle
            // 
            this.FormationTitle.HeaderText = "Formation title";
            this.FormationTitle.Name = "FormationTitle";
            // 
            // FormationDescription
            // 
            this.FormationDescription.HeaderText = "Formation description";
            this.FormationDescription.Name = "FormationDescription";
            this.FormationDescription.Width = 200;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start date";
            this.StartDate.Name = "StartDate";
            this.StartDate.Width = 85;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "End date";
            this.EndDate.Name = "EndDate";
            this.EndDate.Width = 85;
            // 
            // StudentsTab
            // 
            this.StudentsTab.Controls.Add(this.RemoveStudentFromFormationButton);
            this.StudentsTab.Controls.Add(this.AddStudentToFormationButton);
            this.StudentsTab.Controls.Add(this.SelectFormation);
            this.StudentsTab.Controls.Add(this.SelectFormationCB);
            this.StudentsTab.Controls.Add(this.StudentsDGV);
            this.StudentsTab.Controls.Add(this.RemoveStudentButton);
            this.StudentsTab.Controls.Add(this.ModifyStudentButton);
            this.StudentsTab.Controls.Add(this.AddStudentButton);
            this.StudentsTab.Controls.Add(this.StudentMobilePhone);
            this.StudentsTab.Controls.Add(this.StudentPhone);
            this.StudentsTab.Controls.Add(this.StudentCity);
            this.StudentsTab.Controls.Add(this.StudentPostalCode);
            this.StudentsTab.Controls.Add(this.StudentAddress);
            this.StudentsTab.Controls.Add(this.StudentBirthday);
            this.StudentsTab.Controls.Add(this.StudentFirstName);
            this.StudentsTab.Controls.Add(this.StudentLastName);
            this.StudentsTab.Controls.Add(this.StudentMobilePhoneTB);
            this.StudentsTab.Controls.Add(this.StudentPhoneTB);
            this.StudentsTab.Controls.Add(this.StudentCityTB);
            this.StudentsTab.Controls.Add(this.StudentPostalCodeTB);
            this.StudentsTab.Controls.Add(this.StudentAddressRTB);
            this.StudentsTab.Controls.Add(this.StudentBirthdayDTP);
            this.StudentsTab.Controls.Add(this.StudentFirstNameTB);
            this.StudentsTab.Controls.Add(this.StudentLastNameTB);
            this.StudentsTab.Location = new System.Drawing.Point(4, 22);
            this.StudentsTab.Name = "StudentsTab";
            this.StudentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsTab.Size = new System.Drawing.Size(1434, 543);
            this.StudentsTab.TabIndex = 1;
            this.StudentsTab.Text = "Students";
            this.StudentsTab.UseVisualStyleBackColor = true;
            // 
            // RemoveStudentFromFormationButton
            // 
            this.RemoveStudentFromFormationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveStudentFromFormationButton.ForeColor = System.Drawing.Color.Red;
            this.RemoveStudentFromFormationButton.Location = new System.Drawing.Point(244, 413);
            this.RemoveStudentFromFormationButton.Name = "RemoveStudentFromFormationButton";
            this.RemoveStudentFromFormationButton.Size = new System.Drawing.Size(264, 73);
            this.RemoveStudentFromFormationButton.TabIndex = 23;
            this.RemoveStudentFromFormationButton.Text = "REMOVE STUDENT FROM THE SELECTED FORMATION";
            this.RemoveStudentFromFormationButton.UseVisualStyleBackColor = true;
            this.RemoveStudentFromFormationButton.Click += new System.EventHandler(this.RemoveStudentFromFormationButton_Click);
            // 
            // AddStudentToFormationButton
            // 
            this.AddStudentToFormationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentToFormationButton.Location = new System.Drawing.Point(11, 413);
            this.AddStudentToFormationButton.Name = "AddStudentToFormationButton";
            this.AddStudentToFormationButton.Size = new System.Drawing.Size(227, 73);
            this.AddStudentToFormationButton.TabIndex = 22;
            this.AddStudentToFormationButton.Text = "ADD STUDENT TO THE SELECTED FORMATION";
            this.AddStudentToFormationButton.UseVisualStyleBackColor = true;
            this.AddStudentToFormationButton.Click += new System.EventHandler(this.AddStudentToFormationButton_Click);
            // 
            // SelectFormation
            // 
            this.SelectFormation.AutoSize = true;
            this.SelectFormation.Location = new System.Drawing.Point(11, 344);
            this.SelectFormation.Name = "SelectFormation";
            this.SelectFormation.Size = new System.Drawing.Size(92, 13);
            this.SelectFormation.TabIndex = 21;
            this.SelectFormation.Text = "Select a formation";
            // 
            // SelectFormationCB
            // 
            this.SelectFormationCB.FormattingEnabled = true;
            this.SelectFormationCB.Location = new System.Drawing.Point(14, 360);
            this.SelectFormationCB.Name = "SelectFormationCB";
            this.SelectFormationCB.Size = new System.Drawing.Size(329, 21);
            this.SelectFormationCB.TabIndex = 20;
            // 
            // StudentsDGV
            // 
            this.StudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.LastName,
            this.FirstName,
            this.Birthday,
            this.Address,
            this.PostalCode,
            this.City,
            this.Phone,
            this.MobilePhone});
            this.StudentsDGV.Location = new System.Drawing.Point(514, 34);
            this.StudentsDGV.Name = "StudentsDGV";
            this.StudentsDGV.Size = new System.Drawing.Size(920, 519);
            this.StudentsDGV.TabIndex = 19;
            this.StudentsDGV.Click += new System.EventHandler(this.StudentsDGV_Click);
            // 
            // StudentId
            // 
            this.StudentId.HeaderText = "Id";
            this.StudentId.Name = "StudentId";
            this.StudentId.Width = 40;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last name";
            this.LastName.Name = "LastName";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First name";
            this.FirstName.Name = "FirstName";
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Birthday";
            this.Birthday.Name = "Birthday";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Width = 160;
            // 
            // PostalCode
            // 
            this.PostalCode.HeaderText = "Postal code";
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.Width = 75;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // MobilePhone
            // 
            this.MobilePhone.HeaderText = "Mobile phone";
            this.MobilePhone.Name = "MobilePhone";
            // 
            // RemoveStudentButton
            // 
            this.RemoveStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.RemoveStudentButton.ForeColor = System.Drawing.Color.Red;
            this.RemoveStudentButton.Location = new System.Drawing.Point(334, 220);
            this.RemoveStudentButton.Name = "RemoveStudentButton";
            this.RemoveStudentButton.Size = new System.Drawing.Size(154, 79);
            this.RemoveStudentButton.TabIndex = 18;
            this.RemoveStudentButton.Text = "REMOVE STUDENT";
            this.RemoveStudentButton.UseVisualStyleBackColor = true;
            this.RemoveStudentButton.Click += new System.EventHandler(this.RemoveStudentButton_Click);
            // 
            // ModifyStudentButton
            // 
            this.ModifyStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.ModifyStudentButton.Location = new System.Drawing.Point(174, 220);
            this.ModifyStudentButton.Name = "ModifyStudentButton";
            this.ModifyStudentButton.Size = new System.Drawing.Size(154, 79);
            this.ModifyStudentButton.TabIndex = 17;
            this.ModifyStudentButton.Text = "MODIFY STUDENT";
            this.ModifyStudentButton.UseVisualStyleBackColor = true;
            this.ModifyStudentButton.Click += new System.EventHandler(this.ModifyStudentButton_Click);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentButton.Location = new System.Drawing.Point(11, 220);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(154, 79);
            this.AddStudentButton.TabIndex = 16;
            this.AddStudentButton.Text = "ADD STUDENT";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // StudentMobilePhone
            // 
            this.StudentMobilePhone.AutoSize = true;
            this.StudentMobilePhone.Location = new System.Drawing.Point(361, 148);
            this.StudentMobilePhone.Name = "StudentMobilePhone";
            this.StudentMobilePhone.Size = new System.Drawing.Size(71, 13);
            this.StudentMobilePhone.TabIndex = 15;
            this.StudentMobilePhone.Text = "Mobile phone";
            // 
            // StudentPhone
            // 
            this.StudentPhone.AutoSize = true;
            this.StudentPhone.Location = new System.Drawing.Point(361, 102);
            this.StudentPhone.Name = "StudentPhone";
            this.StudentPhone.Size = new System.Drawing.Size(38, 13);
            this.StudentPhone.TabIndex = 14;
            this.StudentPhone.Text = "Phone";
            // 
            // StudentCity
            // 
            this.StudentCity.AutoSize = true;
            this.StudentCity.Location = new System.Drawing.Point(204, 145);
            this.StudentCity.Name = "StudentCity";
            this.StudentCity.Size = new System.Drawing.Size(24, 13);
            this.StudentCity.TabIndex = 13;
            this.StudentCity.Text = "City";
            // 
            // StudentPostalCode
            // 
            this.StudentPostalCode.AutoSize = true;
            this.StudentPostalCode.Location = new System.Drawing.Point(204, 102);
            this.StudentPostalCode.Name = "StudentPostalCode";
            this.StudentPostalCode.Size = new System.Drawing.Size(63, 13);
            this.StudentPostalCode.TabIndex = 12;
            this.StudentPostalCode.Text = "Postal code";
            // 
            // StudentAddress
            // 
            this.StudentAddress.AutoSize = true;
            this.StudentAddress.Location = new System.Drawing.Point(11, 90);
            this.StudentAddress.Name = "StudentAddress";
            this.StudentAddress.Size = new System.Drawing.Size(45, 13);
            this.StudentAddress.TabIndex = 11;
            this.StudentAddress.Text = "Address";
            // 
            // StudentBirthday
            // 
            this.StudentBirthday.AutoSize = true;
            this.StudentBirthday.Location = new System.Drawing.Point(271, 44);
            this.StudentBirthday.Name = "StudentBirthday";
            this.StudentBirthday.Size = new System.Drawing.Size(45, 13);
            this.StudentBirthday.TabIndex = 10;
            this.StudentBirthday.Text = "Birthday";
            // 
            // StudentFirstName
            // 
            this.StudentFirstName.AutoSize = true;
            this.StudentFirstName.Location = new System.Drawing.Point(138, 44);
            this.StudentFirstName.Name = "StudentFirstName";
            this.StudentFirstName.Size = new System.Drawing.Size(55, 13);
            this.StudentFirstName.TabIndex = 9;
            this.StudentFirstName.Text = "First name";
            // 
            // StudentLastName
            // 
            this.StudentLastName.AutoSize = true;
            this.StudentLastName.Location = new System.Drawing.Point(8, 44);
            this.StudentLastName.Name = "StudentLastName";
            this.StudentLastName.Size = new System.Drawing.Size(56, 13);
            this.StudentLastName.TabIndex = 8;
            this.StudentLastName.Text = "Last name";
            // 
            // StudentMobilePhoneTB
            // 
            this.StudentMobilePhoneTB.Location = new System.Drawing.Point(361, 164);
            this.StudentMobilePhoneTB.Name = "StudentMobilePhoneTB";
            this.StudentMobilePhoneTB.Size = new System.Drawing.Size(137, 20);
            this.StudentMobilePhoneTB.TabIndex = 7;
            // 
            // StudentPhoneTB
            // 
            this.StudentPhoneTB.Location = new System.Drawing.Point(361, 122);
            this.StudentPhoneTB.Name = "StudentPhoneTB";
            this.StudentPhoneTB.Size = new System.Drawing.Size(137, 20);
            this.StudentPhoneTB.TabIndex = 6;
            // 
            // StudentCityTB
            // 
            this.StudentCityTB.Location = new System.Drawing.Point(204, 164);
            this.StudentCityTB.Name = "StudentCityTB";
            this.StudentCityTB.Size = new System.Drawing.Size(142, 20);
            this.StudentCityTB.TabIndex = 5;
            // 
            // StudentPostalCodeTB
            // 
            this.StudentPostalCodeTB.Location = new System.Drawing.Point(204, 122);
            this.StudentPostalCodeTB.Name = "StudentPostalCodeTB";
            this.StudentPostalCodeTB.Size = new System.Drawing.Size(142, 20);
            this.StudentPostalCodeTB.TabIndex = 4;
            // 
            // StudentAddressRTB
            // 
            this.StudentAddressRTB.Location = new System.Drawing.Point(11, 110);
            this.StudentAddressRTB.Name = "StudentAddressRTB";
            this.StudentAddressRTB.Size = new System.Drawing.Size(187, 75);
            this.StudentAddressRTB.TabIndex = 3;
            this.StudentAddressRTB.Text = "";
            // 
            // StudentBirthdayDTP
            // 
            this.StudentBirthdayDTP.Location = new System.Drawing.Point(271, 63);
            this.StudentBirthdayDTP.Name = "StudentBirthdayDTP";
            this.StudentBirthdayDTP.Size = new System.Drawing.Size(185, 20);
            this.StudentBirthdayDTP.TabIndex = 2;
            // 
            // StudentFirstNameTB
            // 
            this.StudentFirstNameTB.Location = new System.Drawing.Point(141, 63);
            this.StudentFirstNameTB.Name = "StudentFirstNameTB";
            this.StudentFirstNameTB.Size = new System.Drawing.Size(124, 20);
            this.StudentFirstNameTB.TabIndex = 1;
            // 
            // StudentLastNameTB
            // 
            this.StudentLastNameTB.Location = new System.Drawing.Point(11, 63);
            this.StudentLastNameTB.Name = "StudentLastNameTB";
            this.StudentLastNameTB.Size = new System.Drawing.Size(124, 20);
            this.StudentLastNameTB.TabIndex = 0;
            // 
            // TeachersTab
            // 
            this.TeachersTab.Controls.Add(this.TeacherFirstNameTB);
            this.TeachersTab.Controls.Add(this.TeacherLastNameTB);
            this.TeachersTab.Controls.Add(this.TeacherLastNameLabel);
            this.TeachersTab.Controls.Add(this.TeacherFirstNameLabel);
            this.TeachersTab.Controls.Add(this.RemoveTeacherButton);
            this.TeachersTab.Controls.Add(this.ModifyTeacherButton);
            this.TeachersTab.Controls.Add(this.AddTeacherButton);
            this.TeachersTab.Controls.Add(this.TeachersDGV);
            this.TeachersTab.Location = new System.Drawing.Point(4, 22);
            this.TeachersTab.Name = "TeachersTab";
            this.TeachersTab.Size = new System.Drawing.Size(1434, 543);
            this.TeachersTab.TabIndex = 2;
            this.TeachersTab.Text = "Teachers";
            this.TeachersTab.UseVisualStyleBackColor = true;
            // 
            // TeacherFirstNameTB
            // 
            this.TeacherFirstNameTB.Location = new System.Drawing.Point(212, 148);
            this.TeacherFirstNameTB.Name = "TeacherFirstNameTB";
            this.TeacherFirstNameTB.Size = new System.Drawing.Size(127, 20);
            this.TeacherFirstNameTB.TabIndex = 7;
            // 
            // TeacherLastNameTB
            // 
            this.TeacherLastNameTB.Location = new System.Drawing.Point(73, 148);
            this.TeacherLastNameTB.Name = "TeacherLastNameTB";
            this.TeacherLastNameTB.Size = new System.Drawing.Size(127, 20);
            this.TeacherLastNameTB.TabIndex = 6;
            // 
            // TeacherLastNameLabel
            // 
            this.TeacherLastNameLabel.AutoSize = true;
            this.TeacherLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherLastNameLabel.Location = new System.Drawing.Point(69, 120);
            this.TeacherLastNameLabel.Name = "TeacherLastNameLabel";
            this.TeacherLastNameLabel.Size = new System.Drawing.Size(96, 24);
            this.TeacherLastNameLabel.TabIndex = 5;
            this.TeacherLastNameLabel.Text = "Last name";
            // 
            // TeacherFirstNameLabel
            // 
            this.TeacherFirstNameLabel.AutoSize = true;
            this.TeacherFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherFirstNameLabel.Location = new System.Drawing.Point(208, 120);
            this.TeacherFirstNameLabel.Name = "TeacherFirstNameLabel";
            this.TeacherFirstNameLabel.Size = new System.Drawing.Size(98, 24);
            this.TeacherFirstNameLabel.TabIndex = 4;
            this.TeacherFirstNameLabel.Text = "First name";
            // 
            // RemoveTeacherButton
            // 
            this.RemoveTeacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveTeacherButton.ForeColor = System.Drawing.Color.Red;
            this.RemoveTeacherButton.Location = new System.Drawing.Point(315, 235);
            this.RemoveTeacherButton.Name = "RemoveTeacherButton";
            this.RemoveTeacherButton.Size = new System.Drawing.Size(150, 56);
            this.RemoveTeacherButton.TabIndex = 3;
            this.RemoveTeacherButton.Text = "REMOVE TEACHER";
            this.RemoveTeacherButton.UseVisualStyleBackColor = true;
            this.RemoveTeacherButton.Click += new System.EventHandler(this.RemoveTeacherButton_Click);
            // 
            // ModifyTeacherButton
            // 
            this.ModifyTeacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyTeacherButton.Location = new System.Drawing.Point(159, 235);
            this.ModifyTeacherButton.Name = "ModifyTeacherButton";
            this.ModifyTeacherButton.Size = new System.Drawing.Size(150, 56);
            this.ModifyTeacherButton.TabIndex = 2;
            this.ModifyTeacherButton.Text = "MODIFY TEACHER";
            this.ModifyTeacherButton.UseVisualStyleBackColor = true;
            this.ModifyTeacherButton.Click += new System.EventHandler(this.ModifyTeacherButton_Click);
            // 
            // AddTeacherButton
            // 
            this.AddTeacherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeacherButton.Location = new System.Drawing.Point(3, 235);
            this.AddTeacherButton.Name = "AddTeacherButton";
            this.AddTeacherButton.Size = new System.Drawing.Size(150, 56);
            this.AddTeacherButton.TabIndex = 1;
            this.AddTeacherButton.Text = "ADD TEACHER";
            this.AddTeacherButton.UseVisualStyleBackColor = true;
            this.AddTeacherButton.Click += new System.EventHandler(this.AddTeacherButton_Click);
            // 
            // TeachersDGV
            // 
            this.TeachersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTeacher,
            this.TeacherLastName,
            this.TeacherFirstName});
            this.TeachersDGV.Location = new System.Drawing.Point(472, 30);
            this.TeachersDGV.Name = "TeachersDGV";
            this.TeachersDGV.Size = new System.Drawing.Size(543, 510);
            this.TeachersDGV.TabIndex = 0;
            this.TeachersDGV.Click += new System.EventHandler(this.TeachersDGV_Click);
            // 
            // IdTeacher
            // 
            this.IdTeacher.HeaderText = "Id";
            this.IdTeacher.Name = "IdTeacher";
            // 
            // TeacherLastName
            // 
            this.TeacherLastName.HeaderText = "Last name";
            this.TeacherLastName.Name = "TeacherLastName";
            this.TeacherLastName.Width = 200;
            // 
            // TeacherFirstName
            // 
            this.TeacherFirstName.HeaderText = "First name";
            this.TeacherFirstName.Name = "TeacherFirstName";
            this.TeacherFirstName.Width = 200;
            // 
            // SelectLanguageCB
            // 
            this.SelectLanguageCB.FormattingEnabled = true;
            this.SelectLanguageCB.Location = new System.Drawing.Point(331, 12);
            this.SelectLanguageCB.Name = "SelectLanguageCB";
            this.SelectLanguageCB.Size = new System.Drawing.Size(186, 21);
            this.SelectLanguageCB.TabIndex = 1;
            this.SelectLanguageCB.TextChanged += new System.EventHandler(this.SelectLanguageCB_TextChanged);
            // 
            // SelectLanguageLabel
            // 
            this.SelectLanguageLabel.AutoSize = true;
            this.SelectLanguageLabel.Location = new System.Drawing.Point(182, 15);
            this.SelectLanguageLabel.Name = "SelectLanguageLabel";
            this.SelectLanguageLabel.Size = new System.Drawing.Size(149, 13);
            this.SelectLanguageLabel.TabIndex = 2;
            this.SelectLanguageLabel.Text = "Please, select your language :";
            // 
            // OBFormationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 620);
            this.Controls.Add(this.SelectLanguageLabel);
            this.Controls.Add(this.SelectLanguageCB);
            this.Controls.Add(this.OBFormationTab);
            this.Name = "OBFormationForm";
            this.Text = "OBFormation";
            this.OBFormationTab.ResumeLayout(false);
            this.FormationsTab.ResumeLayout(false);
            this.FormationsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsRegisteredDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormationsDGV)).EndInit();
            this.StudentsTab.ResumeLayout(false);
            this.StudentsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).EndInit();
            this.TeachersTab.ResumeLayout(false);
            this.TeachersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl OBFormationTab;
        private System.Windows.Forms.TabPage FormationsTab;
        private System.Windows.Forms.TabPage StudentsTab;
        private System.Windows.Forms.TabPage TeachersTab;
        private System.Windows.Forms.ComboBox SelectLanguageCB;
        private System.Windows.Forms.Label SelectLanguageLabel;
        private System.Windows.Forms.DataGridView FormationsDGV;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label FormationDescriptionLabel;
        private System.Windows.Forms.Label FormationTitleLabel;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button RemoveFormationButton;
        private System.Windows.Forms.Button ModifyFormationButton;
        private System.Windows.Forms.Button AddFormationButton;
        private System.Windows.Forms.Label StudentsRegisteredLabel;
        private System.Windows.Forms.DataGridView StudentsRegisteredDGV;
        private System.Windows.Forms.Label EndDateDTP;
        private System.Windows.Forms.Label StartDateDTP;
        private System.Windows.Forms.Label StudentLastName;
        private System.Windows.Forms.TextBox StudentMobilePhoneTB;
        private System.Windows.Forms.TextBox StudentPhoneTB;
        private System.Windows.Forms.TextBox StudentCityTB;
        private System.Windows.Forms.TextBox StudentPostalCodeTB;
        private System.Windows.Forms.RichTextBox StudentAddressRTB;
        private System.Windows.Forms.DateTimePicker StudentBirthdayDTP;
        private System.Windows.Forms.TextBox StudentFirstNameTB;
        private System.Windows.Forms.TextBox StudentLastNameTB;
        private System.Windows.Forms.Label StudentBirthday;
        private System.Windows.Forms.Label StudentFirstName;
        private System.Windows.Forms.Label StudentPostalCode;
        private System.Windows.Forms.Label StudentAddress;
        private System.Windows.Forms.Label StudentCity;
        private System.Windows.Forms.Label StudentPhone;
        private System.Windows.Forms.Button RemoveStudentButton;
        private System.Windows.Forms.Button ModifyStudentButton;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Label StudentMobilePhone;
        private System.Windows.Forms.DataGridView StudentsDGV;
        private System.Windows.Forms.Button RemoveStudentFromFormationButton;
        private System.Windows.Forms.Button AddStudentToFormationButton;
        private System.Windows.Forms.Label SelectFormation;
        private System.Windows.Forms.ComboBox SelectFormationCB;
        private System.Windows.Forms.TextBox TeacherFirstNameTB;
        private System.Windows.Forms.TextBox TeacherLastNameTB;
        private System.Windows.Forms.Label TeacherLastNameLabel;
        private System.Windows.Forms.Label TeacherFirstNameLabel;
        private System.Windows.Forms.Button RemoveTeacherButton;
        private System.Windows.Forms.Button ModifyTeacherButton;
        private System.Windows.Forms.Button AddTeacherButton;
        private System.Windows.Forms.DataGridView TeachersDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentsLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentsFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentsBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentsAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentsPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentsCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentsPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentsMobilePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobilePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormationTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormationDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
    }
}

