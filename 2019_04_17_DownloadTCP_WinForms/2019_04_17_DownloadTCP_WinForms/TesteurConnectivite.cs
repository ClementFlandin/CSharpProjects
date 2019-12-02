using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Nini.Config;

namespace _2019_04_17_DownloadTCP_WinForms
{
    public partial class TestDownload : Form
    {
        public TestDownload()
        {
            InitializeComponent();
            MessagesConnectivites_Textloaded();
        }
        private void MessagesConnectivites_Textloaded()
        {
            MessagesConnectivites.Text = String.Format("Tests de connectivité\n\nTest de téléchargement\nLe fichier de 5 Mo a été téléchargé en secondes" +
                ", soit à la vitesse de Mo/s\n\nTest de connection à des sites\nTest de connection à Google.com\nTest de connection à Elythe.com\nTest de connection à Calypso3d.fr");
        }
        private void TestDeTelechargement_Click(object sender, EventArgs e)
        {
            double interval;
            using (WebClient wc = new WebClient())
            {
                DateTime start = DateTime.Now;

                wc.DownloadFile("https://infokiosques.net/IMG/pdf/Ludd.pdf", "Ludd.pdf");
                DateTime end = DateTime.Now;
                interval = (end - start).TotalSeconds;
            }
            MessageBox.Show(String.Format("Votre téléchargement s'est effectué à la vitesse de {0} Mo/s", 5.0 / interval));
            if(MessagesConnectivites.Text== String.Format("Tests de connectivité\n\nTest de téléchargement\nLe fichier de 5 Mo a été téléchargé en secondes" +
                ", soit à la vitesse de Mo/s\n\nTest de connection à des sites\nTest de connection à Google.com\nTest de connection à Elythe.com\nTest de connection à Calypso3d.fr"))
            {
                MessagesConnectivites.Clear();
                MessagesConnectivites.AppendText("Tests de connectivité\n\n");
            }
            MessagesConnectivites.AppendText(String.Format("Le fichier de 5 Mo a été téléchargé en {0} secondes, soit à la vitesse de {1} Mo/s\n", interval, 5.0 / interval)); 
        }

        private void TestGoogle_Click(object sender, EventArgs e)
        {
            string google = "http://google.com";
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadString(@google);
                }
                MessageBox.Show("Le test a réussi", "Super", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessagesConnectivites.Text == String.Format("Tests de connectivité\n\nTest de téléchargement\nLe fichier de 5 Mo a été téléchargé en secondes" +
                ", soit à la vitesse de Mo/s\n\nTest de connection à des sites\nTest de connection à Google.com\nTest de connection à Elythe.com\nTest de connection à Calypso3d.fr"))
                {
                    MessagesConnectivites.Clear();
                    MessagesConnectivites.AppendText("Tests de connectivité\n\n");
                }
                MessagesConnectivites.AppendText(String.Format("La connection à {0} a réussi", google));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le test a échoué", "Raté",  MessageBoxButtons.OK,MessageBoxIcon.Stop);
                MessagesConnectivites.AppendText(String.Format("La connection à {0} a échoué", google));
            }


        }

        private void TestElythe_Click(object sender, EventArgs e)
        {
            string elythe = "https://elythe.com";
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadString(@elythe);
                }

                MessageBox.Show("Le test a réussi", "Super",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessagesConnectivites.Text == String.Format("Tests de connectivité\n\nTest de téléchargement\nLe fichier de 5 Mo a été téléchargé en secondes" +
", soit à la vitesse de Mo/s\n\nTest de connection à des sites\nTest de connection à Google.com\nTest de connection à Elythe.com\nTest de connection à Calypso3d.fr"))
                {
                    MessagesConnectivites.Clear();
                    MessagesConnectivites.AppendText("Tests de connectivité\n\n");
                }
                MessagesConnectivites.AppendText(String.Format("La connection à {0} a réussi", elythe));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le test a échoué", "Raté", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessagesConnectivites.AppendText(String.Format("La connection à {0} a échoué", elythe));
            }

        }

        private void TestCalypso_Click(object sender, EventArgs e)
        {

            string calypso = "http://calypso3d.fr";
            try
            {
                using (WebClient wc = new WebClient())
                {
                    wc.DownloadString(@calypso);
                }
                MessageBox.Show("Le test a réussi", "Super", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessagesConnectivites.Text == String.Format("Tests de connectivité\n\nTest de téléchargement\nLe fichier de 5 Mo a été téléchargé en secondes" +
", soit à la vitesse de Mo/s\n\nTest de connection à des sites\nTest de connection à Google.com\nTest de connection à Elythe.com\nTest de connection à Calypso3d.fr"))
                {
                    MessagesConnectivites.Clear();
                }
                MessagesConnectivites.AppendText(String.Format("La connection à {0} a réussi", calypso));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Le test a échoué", "Raté", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessagesConnectivites.AppendText(String.Format("La connection à {0} a échoué", calypso));
            }

        }

    }
}
