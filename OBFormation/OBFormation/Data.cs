using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace OBFormation
{
    static class Data
    {
        private static readonly string _ConnectionString = String.Format(
            "server={0};port={1};user={2};password={3}",
            GetConfigValue("server"),
            GetConfigValue("port"),
            GetConfigValue("user"),
            GetConfigValue("password"));

        private static MySqlConnection _Connection = null;
        private static string GetConfigValue(string key)
        {
            return Config.Ini.Configs["MySQL"].GetString(key);
        }

        public static MySqlConnection Connection
        {
            get
            {
                MySqlConnection connection = new MySqlConnection(_ConnectionString);
                connection.Open();
                if (_Connection == null)
                {
                    new MySqlCommand(String.Format(
                        "CREATE DATABASE IF NOT EXISTS `{0}`;", GetConfigValue("database")), connection).ExecuteNonQuery();
                    new MySqlCommand(String.Format(
                        "USE `{0}`;", GetConfigValue("database")), connection).ExecuteNonQuery();
                    new MySqlCommand(String.Format(
                        "CREATE TABLE IF NOT EXISTS `formations` (" +
                        "`formationid` int(6) NOT NULL AUTO_INCREMENT PRIMARY KEY," +
                        "`formationtitle` varchar(100) NOT NULL," +
                        "`formationdescription` varchar(250)," +
                        "`startdate` VARCHAR(50) NOT NULL," +
                        "`enddate` VARCHAR(50) NOT NULL" +
                        ") EnGINE = InnoDB;"),connection).ExecuteNonQuery();
                    new MySqlCommand(String.Format(
                        "CREATE TABLE IF NOT EXISTS `students` (" +
                        "`studentid` int(6) NOT NULL AUTO_INCREMENT PRIMARY KEY," +
                        "`lastname` varchar(50) NOT NULL," +
                        "`firstname` varchar(50) NOT NULL," +
                        "`birthday` VARCHAR(50) NOT NULL," +
                        "`address` varchar(250)," +
                        "`postalcode` int(10)," +
                        "`city` varchar(50)," +
                        "`phone` varchar(20)," +
                        "`mobilephone` varchar(20)" +
                        ") ENGINE = InnoDB;"),connection).ExecuteNonQuery();
                    new MySqlCommand(String.Format(
                        "CREATE TABLE IF NOT EXISTS `teachers` (" +
                        "`teacherid` int(6) NOT NULL AUTO_INCREMENT PRIMARY KEY," +
                        "`teacherlastname` varchar(50) NOT NULL," +
                        "`teacherfirstname` varchar(50) NOT NULL" +
                        ") ENGINE = InnoDB;"), connection).ExecuteNonQuery();
                    new MySqlCommand(String.Format(
                        "CREATE TABLE IF NOT EXISTS `belonging` (" +
                        "`id_formation` int(6) NOT NULL," +
                        "`id_student` int(6) NOT NULL," +
                        "FOREIGN KEY (id_formation) REFERENCES formations(formationid)," +
                        "FOREIGN KEY (id_student) REFERENCES students(studentid)"+
                        ") ENGINE = InnoDB;"),connection).ExecuteNonQuery();
                }
                else
                {
                    new MySqlCommand(String.Format(
                        "USE `{0}`;", GetConfigValue("database")), connection).ExecuteNonQuery();
                }
                _Connection = connection;
                return _Connection;
            }
        }
        public static void AddFormation(Formations formation)
        {
            using(MySqlConnection conn = Connection)
            {
                string query = "INSERT INTO `formations` (formationtitle,formationdescription,startdate,enddate) VALUES (@formtitle,@formdesc,@start,@end);";
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.Parameters.AddWithValue("formtitle", formation.FormationTitle);
                comm.Parameters.AddWithValue("formdesc", formation.FormationDescription);
                comm.Parameters.AddWithValue("start", formation.StartDate);
                comm.Parameters.AddWithValue("end", formation.EndDate);
                comm.ExecuteNonQuery();
            }
        }
        public static void UpdateFormation(Formations formation)
        {
            using (MySqlConnection conn = Connection)
            {
                string query = "UPDATE `formations` SET formationtitle=@formtitle,formationdescription=@formdesc,startdate=@start,enddate=@end";
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.Parameters.AddWithValue("formtitle", formation.FormationTitle);
                comm.Parameters.AddWithValue("formdesc", formation.FormationDescription);
                comm.Parameters.AddWithValue("start", formation.StartDate);
                comm.Parameters.AddWithValue("end", formation.EndDate);
                comm.ExecuteNonQuery();
            }
        }
        public static void DeleteFormation(Formations formation)
        {
            using (MySqlConnection conn = Connection)
            {
                string query = "DELETE FROM `formations` WHERE formationid=@formid";
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.Parameters.AddWithValue("formid", formation.FormationId);
                comm.ExecuteNonQuery();
            }
        }
        public static List<Formations> GetFormationsList()
        {
            List<Formations> formations = new List<Formations>();
            using (MySqlConnection conn = Connection)
            {
                MySqlCommand comm = new MySqlCommand("SELECT * FROM `formations`;",conn);
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Formations form = new Formations
                    {
                        FormationId = reader.GetInt32("formationId"),
                        FormationTitle=reader.GetString("formationtitle"),
                        FormationDescription=reader.GetString("formationdescription"),
                        StartDate=reader.GetString("startdate"),
                        EndDate=reader.GetString("enddate")
                    };
                    formations.Add(form);
                }
                reader.Close();
            }
            return formations;
        }
        public static void AddStudent(Students student)
        {
            using (MySqlConnection conn = Connection)
            {
                string query = "INSERT INTO `students` (lastname,firstname,birthday,address,postalcode,city,phone,mobilephone) VALUES (" +
                    "@lastname,@firstname,@birthday,@address,@postcode,@city,@phone,@mobile);";
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.Parameters.AddWithValue("lastname", student.LastName);
                comm.Parameters.AddWithValue("firstname", student.FirstName);
                comm.Parameters.AddWithValue("birthday", student.Birthday);
                comm.Parameters.AddWithValue("address", student.Address);
                comm.Parameters.AddWithValue("postcode", student.PostalCode);
                comm.Parameters.AddWithValue("city", student.City);
                comm.Parameters.AddWithValue("phone", student.Phone);
                comm.Parameters.AddWithValue("mobile", student.MobilePhone);
                comm.ExecuteNonQuery();
            }
        }
        public static void UpdateStudent(Students student)
        {
            using(MySqlConnection conn = Connection)
            {
                string query = "UPDATE `students` SET lastname=@lastname,firstname=@firstname,birthday=@birthday,address=@address," +
                "postalcode=@postcode,city=@city,phone=@phone,mobilephone=@mobile";
                MySqlCommand comm= new MySqlCommand(query, conn);
                comm.Parameters.AddWithValue("lastname", student.LastName);
                comm.Parameters.AddWithValue("firstname", student.FirstName);
                comm.Parameters.AddWithValue("birthday", student.Birthday);
                comm.Parameters.AddWithValue("address", student.Address);
                comm.Parameters.AddWithValue("postcode", student.PostalCode);
                comm.Parameters.AddWithValue("city", student.City);
                comm.Parameters.AddWithValue("phone", student.Phone);
                comm.Parameters.AddWithValue("mobile", student.MobilePhone);
                comm.ExecuteNonQuery();
            }
        }
        public static void DeleteStudent(Students student)
        {
            using(MySqlConnection conn = Connection)
            {
                string query = "DELETE FROM `students` WHERE studentid=@studid";
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.Parameters.AddWithValue("studid", student.StudentId);
                comm.ExecuteNonQuery();
            }
        }
        public static List<Students> GetStudentsList()
        {
            List<Students> students = new List<Students>();
            using (MySqlConnection conn = Connection)
            {
                MySqlCommand comm = new MySqlCommand("SELECT * FROM `students`;",conn);
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Students stud = new Students
                    {
                        StudentId = reader.GetInt32("studentid"),
                        LastName = reader.GetString("lastname"),
                        FirstName = reader.GetString("firstname"),
                        Birthday = reader.GetString("birthday"),
                        Address = reader.GetString("address"),
                        PostalCode = reader.GetInt32("postalcode"),
                        City = reader.GetString("city"),
                        Phone = reader.GetString("phone"),
                        MobilePhone = reader.GetString("mobilephone")
                    };
                    students.Add(stud);
                }
                reader.Close();
            }
            return students;
        }
        public static void AddTeacher(Teachers teacher)
        {
            using (MySqlConnection conn = Connection)
            {
                string query = "INSERT INTO `teachers` (teacherlastname,teacherfirstname) VALUES (@lastname,@firstname)";
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.Parameters.AddWithValue("lastname", teacher.TeacherLastName);
                comm.Parameters.AddWithValue("firstname", teacher.TeacherFirstName);
                comm.ExecuteNonQuery();
            }
        }
        public static void UpdateTeacher(Teachers teacher)
        {
            using(MySqlConnection conn = Connection)
            {
                string query = "UPDATE `teachers` SET teacherlastname=@teachlastname,teacherfirstname=@teachfirstname WHERE teacherid=@teachid ";
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.Parameters.AddWithValue("teachlastname", teacher.TeacherLastName);
                comm.Parameters.AddWithValue("teachfirstname", teacher.TeacherFirstName);
                comm.Parameters.AddWithValue("teachid", teacher.TeacherId);
                comm.ExecuteNonQuery();
            }
        }
        public static void DeleteTeacher(Teachers teacher)
        {
            using (MySqlConnection conn = Connection)
            {
                string query = "DELETE FROM `teachers` WHERE teacherid=@teachid";
                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.Parameters.AddWithValue("teachid",teacher.TeacherId);
                comm.ExecuteNonQuery();
            }
        }
        public static List<Teachers> GetTeachersList()
        {
            List<Teachers> teachers = new List<Teachers>();
            using(MySqlConnection conn = Connection)
            {
                MySqlCommand comm = new MySqlCommand("SELECT * FROM `teachers`;",conn);
                MySqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Teachers teacher = new Teachers
                    {
                        TeacherId = reader.GetInt32("teacherid"),
                        TeacherLastName = reader.GetString("teacherlastname"),
                        TeacherFirstName = reader.GetString("teacherfirstname")
                    };
                    teachers.Add(teacher);
                }
                reader.Close();
            }
            return teachers;
        }
    }
    //class Belonging
    //{
    //    public int Id_Formation { get; set; }
    //    public int Id_Student { get; set; }
    //}
    class Formations
    {
        public int FormationId { get; set; }
        public string FormationTitle { get; set; }
        public string FormationDescription { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
    class Students
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
    }
    class Teachers
    {
        public int TeacherId { get; set; }
        public string TeacherLastName { get; set; }
        public string TeacherFirstName { get; set; }
    }
}
