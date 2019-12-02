using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace _2019_04_19_PremiersPasMySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string connectionString = "server=localhost;user=root;port=3306;password=";
                MySqlConnection conn = new MySqlConnection(connectionString);

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                Console.WriteLine("Connected to MySQL !");

                while (true)
                {

                    Console.WriteLine("Please, enter a SQL command :");
                    string sql = Console.ReadLine();

                    if (sql == "quit") break;

                    //string sql = "SELECT Name, HeadOfState FROM Country WHERE Continent='Oceania'";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                    }
                    rdr.Close();
                }

                conn.Close();
                Console.WriteLine("Closing MySQL connection. Bye !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }

        }
    }
}
