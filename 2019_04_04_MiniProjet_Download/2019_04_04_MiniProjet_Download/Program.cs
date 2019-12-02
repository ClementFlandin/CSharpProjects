using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _2019_04_04_MiniProjet_Download
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
                wc.DownloadFile("https://infokiosques.net/IMG/pdf/Ludd.pdf","Ludd.pdf");
                //We stock the end time in the DateTime variable "end"
                DateTime end = DateTime.Now;
                //We assign to interval the difference between start time and end time, and we convert it into seconds
                interval = (end - start).TotalSeconds;
            }

            //We divide the file size by the seconds needed to download it, and we print it to the console
            Console.WriteLine("Download speed : " + Math.Round(5.0/ interval, 3) + "Mo/s");

            Console.ReadKey();
        }

    }
}
