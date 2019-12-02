using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OBFormation
{
    public partial class OBFormationForm : Form
    {
        public OBFormationForm()
        {
            InitializeComponent();
            GetLanguages();
            DisplayFormationsView();
            DisplayStudentsView();
            DisplayTeachersView();
            DisplayFormationsComboBox();
        }

        private void AddFormationButton_Click(object sender, EventArgs e)
        {
            Formations formation = new Formations
            {
                FormationTitle = richTextBox1.Text,
                FormationDescription = richTextBox2.Text,
                StartDate = dateTimePicker.Value.ToShortDateString(),
                EndDate = dateTimePicker1.Value.ToShortDateString()
            };
            Data.AddFormation(formation);

            DisplayFormationsView();
            DisplayFormationsComboBox();
        }

        private void ModifyFormationButton_Click(object sender, EventArgs e)
        {
            Formations formationInput = new Formations
            {
                FormationTitle = richTextBox1.Text,
                FormationDescription = richTextBox2.Text,
                StartDate = dateTimePicker.Value.ToShortDateString(),
                EndDate = dateTimePicker1.Value.ToShortDateString()
            };
            formationInput.FormationId = (int)FormationsDGV.CurrentRow.Cells[0].Value;

            Data.UpdateFormation(formationInput);

            DisplayFormationsView();
            DisplayFormationsComboBox();
        }

        private void RemoveFormationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to permanently remove this Formation?", "Beware!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Formations formation = new Formations
                {
                    FormationId = (int)FormationsDGV.CurrentRow.Cells[0].Value,
                    FormationTitle = FormationsDGV.CurrentRow.Cells[1].Value.ToString(),
                    FormationDescription = FormationsDGV.CurrentRow.Cells[2].Value.ToString(),
                    StartDate = FormationsDGV.CurrentRow.Cells[3].Value.ToString(),
                    EndDate = FormationsDGV.CurrentRow.Cells[4].Value.ToString()
                };

                Data.DeleteFormation(formation);

                DisplayFormationsView();
                DisplayFormationsComboBox();
            }

        }
        private void FormationsDGV_Click(object sender, EventArgs e)
        {
            Formations selectedFormation = new Formations
            {
                FormationTitle = "",
                FormationDescription = "",
                StartDate = "",
                EndDate = ""
            };
            try
            {
                selectedFormation.FormationTitle = FormationsDGV.CurrentRow.Cells[1].Value.ToString();
                selectedFormation.FormationDescription = FormationsDGV.CurrentRow.Cells[2].Value.ToString();
                selectedFormation.StartDate = FormationsDGV.CurrentRow.Cells[3].Value.ToString();
                selectedFormation.EndDate = FormationsDGV.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                Log.SaveErrorData(ex);
            }
            DisplayFormation(selectedFormation);
        }
        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            Students student = new Students
            {
                LastName = StudentLastNameTB.Text,
                FirstName = StudentFirstNameTB.Text,
                Birthday = StudentBirthdayDTP.Value.ToShortDateString(),
                Address = StudentAddressRTB.Text,
                PostalCode = Convert.ToInt32(StudentPostalCodeTB.Text),
                City = StudentCityTB.Text,
                Phone = StudentPhoneTB.Text,
                MobilePhone = StudentMobilePhoneTB.Text
            };
            Data.AddStudent(student);

            DisplayStudentsView();
        }

        private void ModifyStudentButton_Click(object sender, EventArgs e)
        {
            Students studentInput = new Students
            {
                LastName = StudentLastNameTB.Text,
                FirstName = StudentFirstNameTB.Text,
                Birthday = StudentBirthdayDTP.Value.ToShortDateString(),
                Address = StudentAddressRTB.Text,
                PostalCode = Convert.ToInt32(StudentPostalCodeTB.Text),
                City = StudentCityTB.Text,
                Phone = StudentPhoneTB.Text,
                MobilePhone = StudentMobilePhoneTB.Text
            };
            studentInput.StudentId = (int)StudentsDGV.CurrentRow.Cells[0].Value;

            Data.UpdateStudent(studentInput);

            DisplayStudentsView();
        }

        private void RemoveStudentButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to permanently remove this Student?", "Beware!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Students studentInput = new Students
                {
                    StudentId = (int)StudentsDGV.CurrentRow.Cells[0].Value,
                    LastName = StudentsDGV.CurrentRow.Cells[1].Value.ToString(),
                    FirstName = StudentsDGV.CurrentRow.Cells[2].Value.ToString(),
                    Birthday = StudentsDGV.CurrentRow.Cells[3].Value.ToString(),
                    Address = StudentsDGV.CurrentRow.Cells[4].Value.ToString(),
                    PostalCode = (int)StudentsDGV.CurrentRow.Cells[5].Value,
                    City = StudentsDGV.CurrentRow.Cells[6].Value.ToString(),
                    Phone = StudentsDGV.CurrentRow.Cells[7].Value.ToString(),
                    MobilePhone = StudentsDGV.CurrentRow.Cells[8].Value.ToString()
                };
                Data.DeleteStudent(studentInput);

                DisplayStudentsView();
            }
        }
        private void StudentsDGV_Click(object sender, EventArgs e)
        {
            Students selectedStudent = new Students
            {
                LastName = "",
                FirstName = "",
                Birthday = "",
                Address = "",
                PostalCode = 0,
                City = "",
                Phone = "",
                MobilePhone = ""
            };
            try
            {
                selectedStudent.LastName = StudentsDGV.CurrentRow.Cells[1].Value.ToString();
                selectedStudent.FirstName = StudentsDGV.CurrentRow.Cells[2].Value.ToString();
                selectedStudent.Birthday = StudentsDGV.CurrentRow.Cells[3].Value.ToString();
                selectedStudent.Address = StudentsDGV.CurrentRow.Cells[4].Value.ToString();
                selectedStudent.PostalCode = (int)StudentsDGV.CurrentRow.Cells[5].Value;
                selectedStudent.City = StudentsDGV.CurrentRow.Cells[6].Value.ToString();
                selectedStudent.Phone = StudentsDGV.CurrentRow.Cells[7].Value.ToString();
                selectedStudent.MobilePhone = StudentsDGV.CurrentRow.Cells[8].Value.ToString();
            }
            catch (Exception ex)
            {
                Log.SaveErrorData(ex);
            }
            DisplayStudent(selectedStudent);
        }
        private void AddTeacherButton_Click(object sender, EventArgs e)
        {
            Teachers teacher = new Teachers
            {
                TeacherLastName = TeacherLastNameTB.Text,
                TeacherFirstName = TeacherFirstNameTB.Text
            };
            Data.AddTeacher(teacher);

            DisplayTeachersView();
        }

        private void ModifyTeacherButton_Click(object sender, EventArgs e)
        {
            Teachers teacherInput = new Teachers
            {
                TeacherLastName = TeacherLastNameTB.Text,
                TeacherFirstName = TeacherFirstNameTB.Text
            };
            teacherInput.TeacherId = (int)TeachersDGV.CurrentRow.Cells[0].Value;
            Data.UpdateTeacher(teacherInput);
            DisplayTeachersView();
        }
        private void RemoveTeacherButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to permanently remove this Teacher?", "Beware!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Teachers teacher = new Teachers
                {
                    TeacherId = (int)TeachersDGV.CurrentRow.Cells[0].Value,
                    TeacherLastName = TeachersDGV.CurrentRow.Cells[1].Value.ToString(),
                    TeacherFirstName = TeachersDGV.CurrentRow.Cells[2].Value.ToString()
                };
                Data.DeleteTeacher(teacher);
                DisplayTeachersView();
            }

        }
        private void TeachersDGV_Click(object sender, EventArgs e)
        {
            Teachers selectedTeacher = new Teachers
            {
                TeacherLastName = "",
                TeacherFirstName = ""
            };

            try
            {
                selectedTeacher.TeacherLastName = TeachersDGV.CurrentRow.Cells[1].Value.ToString();
                selectedTeacher.TeacherFirstName = TeachersDGV.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                Log.SaveErrorData(ex);
            }
            DisplayTeacher(selectedTeacher);
        }


        private void AddStudentToFormationButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveStudentFromFormationButton_Click(object sender, EventArgs e)
        {

        }
        private void DisplayFormationsView()
        {
            List<Formations> formations = Data.GetFormationsList();

            FormationsDGV.Rows.Clear();

            for (int i = 0; i < formations.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)FormationsDGV.Rows[i].Clone();

                row.Cells[0].Value = formations[i].FormationId;
                row.Cells[1].Value = formations[i].FormationTitle;
                row.Cells[2].Value = formations[i].FormationDescription;
                row.Cells[3].Value = formations[i].StartDate;
                row.Cells[4].Value = formations[i].EndDate;
                FormationsDGV.Rows.Add(row);
            }
        }
        private void DisplayFormation(Formations formation)
        {
            richTextBox1.Text = formation.FormationTitle;
            richTextBox2.Text = formation.FormationDescription;
            dateTimePicker.Value = Convert.ToDateTime(formation.StartDate);
            dateTimePicker1.Value = Convert.ToDateTime(formation.EndDate);
        }
        private void DisplayStudentsView()
        {
            List<Students> students = Data.GetStudentsList();

            StudentsDGV.Rows.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)StudentsDGV.Rows[i].Clone();
                row.Cells[0].Value = students[i].StudentId;
                row.Cells[1].Value = students[i].LastName;
                row.Cells[2].Value = students[i].FirstName;
                row.Cells[3].Value = students[i].Birthday;
                row.Cells[4].Value = students[i].Address;
                row.Cells[5].Value = students[i].PostalCode;
                row.Cells[6].Value = students[i].City;
                row.Cells[7].Value = students[i].Phone;
                row.Cells[8].Value = students[i].MobilePhone;
                StudentsDGV.Rows.Add(row);
            }
        }
        private void DisplayStudent(Students student)
        {
            StudentLastNameTB.Text = student.LastName;
            StudentFirstNameTB.Text = student.FirstName;
            StudentBirthdayDTP.Value = Convert.ToDateTime(student.Birthday);
            StudentAddressRTB.Text = student.Address;
            StudentPostalCodeTB.Text = student.PostalCode.ToString();
            StudentCityTB.Text = student.City;
            StudentPhoneTB.Text = student.Phone;
            StudentMobilePhoneTB.Text = student.MobilePhone;
        }
        /// <summary>
        /// 
        /// </summary>
        private void DisplayTeachersView()
        {
            List<Teachers> teachers = Data.GetTeachersList();

            TeachersDGV.Rows.Clear();
            for (int i = 0; i < teachers.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)TeachersDGV.Rows[i].Clone();
                row.Cells[0].Value = teachers[i].TeacherId;
                row.Cells[1].Value = teachers[i].TeacherLastName;
                row.Cells[2].Value = teachers[i].TeacherFirstName;
                TeachersDGV.Rows.Add(row);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="teacher"></param>
        private void DisplayTeacher(Teachers teacher)
        {
            TeacherLastNameTB.Text = teacher.TeacherLastName;
            TeacherFirstNameTB.Text = teacher.TeacherFirstName;
        }
        /// <summary>
        /// 
        /// </summary>
        private void DisplayFormationsComboBox()
        {
            List<Formations> formations = Data.GetFormationsList();

            SelectFormationCB.Items.Clear();
            foreach (Formations formation in formations)
            {
                SelectFormationCB.Items.Add(formation.FormationTitle);
            }
        }
        private void GetLanguages()
        {
            List<string> languages = Languages.GetLanguagesList();
            foreach(string language in languages)
            {
                SelectLanguageCB.Items.Add(language);
            }
            SelectLanguageCB.SelectedItem = SelectLanguageCB.Items[0];
        }
        private void SelectLanguageCB_TextChanged(object sender, EventArgs e)
        {
            //TranslateApp();
        }
        private void TranslateApp()
        {
            // Translating each control inside each tab
            foreach (Control tab in OBFormationTab.Controls)
            {
                // Translating the tab name
                tab.Text = Languages.GetTranslation(GetCurrentLanguage(), tab.Text);

                // Translating each control (labels, buttons, grid columns...)
                // inside each tab
                foreach (Control control in tab.Controls)
                {
                    // Translating the control text
                    control.Text = Languages.GetTranslation(GetCurrentLanguage(), control.Text);
                }
            }
        }

        private string GetCurrentLanguage()
        {
            return SelectLanguageCB.SelectedItem.ToString();
        }
    }
}
