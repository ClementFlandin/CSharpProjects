using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _2019_04_22_DefiWinformMySQL
{
    public partial class LaFerme : Form
    {
        public LaFerme()
        {
            Initialization();
            InitializeComponent();

        }
        private const string connectionString = "server=localhost;user=root;port=3306;password=";
        private MySqlConnection conn = new MySqlConnection(connectionString);
        private MySqlCommand cmd = new MySqlConnection(connectionString).CreateCommand();

        
        private void Initialization()
        {
            conn.Open();

            string sql = "CREATE DATABASE `laferme`;";
            new MySqlCommand(sql, conn);
            sql = "CREATE TABLE especes(id INT NOT NULL AUTO_INCREMENT, nom VARCHAR(32), PRIMARY KEY(id)) ENGINE = INNODB;";
            cmd = new MySqlCommand(sql, conn);
            cmd = new MySqlCommand("USE laferme; CREATE TABLE IF NOT EXISTS `especes` (" +
                    "`id` int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY," +
                    "`nom` varchar(64)" +
                    ") ENGINE=InnoDB", conn);
            cmd = conn.CreateCommand();
            cmd.CommandText = "USE laferme;";
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EspeceDeLAnimalCB.Items.Add(reader["nom"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {

            }


        }

        private void AjoutEspece_Click(object sender, EventArgs e)
        {
            try
            {
                new MySqlCommand("USE laferme; CREATE TABLE IF NOT EXISTS `especes` (" +
                    "`id` int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY," +
                    "`nom` varchar(64) NOT NULL" +
                    ") ENGINE=InnoDB", conn).ExecuteNonQuery();
                EspeceDeLAnimalCB.Items.Add(NouvelleEspeceTB.Text.ToString());

                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO especes(nom) VALUES (@nom);";
                cmd.Parameters.AddWithValue("@nom", NouvelleEspeceTB.Text.ToString());
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                MessageBox.Show(String.Format("Espèce \"{0}\" créée en base!", NouvelleEspeceTB.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AjoutAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                new MySqlCommand("USE laferme; CREATE TABLE IF NOT EXISTS `animal` (" +
                    "`id` int(11) NOT NULL AUTO_INCREMENT PRIMARY KEY," +
                    "FOREIGN KEY (id) REFERENCES especes(id)," +
                    "`nom` varchar(64) NOT NULL" +
                    ") ENGINE = InnoDB", conn).ExecuteNonQuery();
                cmd = conn.CreateCommand();
                cmd.CommandText = "USE laferme; INSERT INTO animal(nom) VALUES(@nom);";
                cmd.Parameters.AddWithValue("@nom", NouvelAnimalTB.Text.ToString());
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                MessageBox.Show(String.Format("{0} ajouté à la base!", NouvelAnimalTB.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CloseConnection()
        {
            conn.Close();
        }

        private void LaFerme_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();
        }
    }
}
