using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.Serialization.Formatters.Binary;

namespace _2017_11_13_CollectionsExo
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Article> monStock { get; set; } = new ObservableCollection<Article>();

        public MainWindow()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                                        AttachDbFilename=C:\Users\Clément\source\repos\2017-11-13-CollectionsExo\2017-11-13-CollectionsExo\bdd.mdf;
                                                        Integrated Security=True");
            conn.Open();
            SqlDataReader rdr = null;

            try
            {
                SqlCommand cmd1 = new SqlCommand("select * from Article", conn);
                rdr = cmd1.ExecuteReader();

                //string insertString = @"insert into Article
                //                            (ReferenceNum, Nom, PrixVente, QteStock)
                //                               values (8, 'Eighth', 32, 8)";
                //SqlCommand cmd2 = new SqlCommand(insertString, conn);
                //cmd2.ExecuteNonQuery();

                //string updateString = @"update Article
                //                            set PrixVente=99
                //                            where ReferenceNum=7";
                //SqlCommand cmd3 = new SqlCommand(updateString, conn);
                //cmd3.ExecuteNonQuery();

                //SqlCommand cmd4 = new SqlCommand(@"select ReferenceNum(*) from Article", conn);
                //int count = (int)cmd4.ExecuteScalar();

                while (rdr.Read())
                {
                    int referenceNum = (int)rdr["ReferenceNum"];
                    string nom = (string)rdr["Nom"];
                    int prixVente = (int)rdr["PrixVente"];
                    int qteStock = (int)rdr["QteStock"];
                    Article a = new Article(referenceNum, nom, prixVente, qteStock);
                    monStock.Add(a);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                rdr?.Close();
                conn.Close();
            }

            this.DataContext = this;

            Article a1 = new Article(1, "First", 16, 33);
            Article a2 = new Article(2, "Second", 16, 0);
            Article a3 = new Article(3, "Third", 16, 8);
            Article a4 = new Article(4, "Fourth", 16, 25);
            Article a5 = new Article(5, "Fifth", 16, 12);

            monStock.Add(a1);
            monStock.Add(a2);
            monStock.Add(a3);
            monStock.Add(a4);
            monStock.Add(a5);

            ArrayList l = new ArrayList();
            for (int i = 0; i < 100; i++)
            {
                l.Add(i);
            }

            FileStream s = File.Create("myFile.bin");
            BinaryFormatter b = new BinaryFormatter();

            b.Serialize(s, l);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            var r = rand.Next(50);
            if (!monStock.Any(m => m.ReferenceNum == r))
            {
                Article randomArticle = new Article(r, "New article", r * 5, 25);
                monStock.Add(randomArticle);
            }
            else
            {
                MessageBox.Show("Le numéro de référence existe déjà!");
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            lbItemsSearch.ItemsSource = monStock.Where(m => m.PrixVente > 30);
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            if (lbItems.SelectedItem != null)
            {
                monStock.Remove(lbItems.SelectedItem as Article);
            }

        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (lbItems.SelectedItems != null)
            {
                (lbItems.SelectedItem as Article).Nom = "Random name";
            }
        }

        private void Display_Click(object sender, RoutedEventArgs e)
        {
            lbItemsSearch.ItemsSource = monStock.Where(s => s.ReferenceNum > 5).Take(10);
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            lbItemsSearch.ItemsSource = monStock.Where(s => s.ReferenceNum > 0).OrderBy(s => s.ReferenceNum);
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            lbItemsSearch.ItemsSource = monStock.Where(s => s.PrixVente > 10 && s.PrixVente < 50).OrderBy(s => s.PrixVente);
        }
    }
}
