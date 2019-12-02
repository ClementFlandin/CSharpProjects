using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_04_02_DownloadSpeedDefi
{
    class Program
    {
        static void Main(string[] args)
        {
            //get an entry which is converted into a double which gives the file size
            Console.WriteLine("What is the size of the downloaded file (in Mo)?");
            string sizeEntry = Console.ReadLine();
            int size = Convert.ToInt32(sizeEntry);

            //get an entry which is to give the downloading time, and is then converted into a double to give the minutes required for the download
            Console.WriteLine("What is the downloading time (in minutes)?");
            string timeEntry = Console.ReadLine();
            double time = Convert.ToInt32(timeEntry);

            //Convert time, which is in minutes, into the corresponding seconds with the MinutesToSeconds method
            double seconds = MinutesToSeconds(time);

            //Double that gives the download speed in Mo per second
            double speed = size / seconds;

            //Round the speed to the 2nd decimal digit
            speed = Math.Round(speed, 2);

            //Give the downloading speed in Mo/s
            Console.WriteLine("The downloading speed is : {0} Mo/s", speed);

            Console.ReadKey();
        }
        /// <summary>
        /// Multiply the minutes by 60 to get the seconds
        /// </summary>
        /// <param name="minutes"></param>
        /// <returns></returns>
        static double MinutesToSeconds(double minutes)
        {
            return minutes * 60;
        }
    }
}
