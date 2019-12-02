using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _2019_04_04_MiniProjet_Upload
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize a double that is going to stock the interval between start time and end time (of downloading)
            double interval;

            //We use a WebClient, starting with its initialisation
            using (WebClient wc = new WebClient())
            {
                //We stock the start date in the DateTime variable "start", we are specially intersted in the seconds and milliseconds
                DateTime start = DateTime.Now;
                //We ask to download a 5 Mo file by using its url
                wc.UploadFile(@"https://localhost/", "POST", "C:\\Users\\Clément\\fichier1Mo.txt");
                wc.Dispose();
                //wc.UploadFile("C:\\Users\\Clément\\fichier1Mo.txt", "fichier1Mo.txt");
                //We stock the end time in the DateTime variable "end"
                DateTime end = DateTime.Now;
                //We assign to interval the difference between start time and end time, and we convert it into seconds
                interval = (end - start).TotalSeconds;
            }

            //We divide the file size by the seconds needed to download it, and we print it to the console
            Console.WriteLine("Upload speed : " + Math.Round(5.0 / interval, 3) + "Mo/s");

            Console.ReadKey();
        }

    }
}
//[08:19] Olivier Battini: En fait, il faut un serveur distant qui héberge une donnée pour le download TCP, et pour le reste il faut que le serveur reçoive ou envoie des données.
//[08:19] Olivier Battini: Pour l'UDP il faudrait un programme sur le serveur distant qui envoie ou récupère
//des données. Ca je peux le faire ce programme car ce n'est pas demandé dans le miniprojet.
//[08:20] Olivier Battini: Par contre pour les test down et up TCP, on peut passer par un serveur FTP.
//[08:20] Olivier Battini: Test en download : on téléhcarge un fichier FTP.
//[08:20] Olivier Battini: Test en upload ; on téléverse un fichier FTP.
//[08:20] Olivier Battini: Pour l'UDP faut que je fasse un petit programme.
//[08:20] Olivier Battini: coté serveur