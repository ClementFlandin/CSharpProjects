using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBFormation
{
    static class Log
    {
        private static readonly string _LogPath = "errors.log";

        public static void SaveErrorData(Exception exception)
        {
            if (!File.Exists(_LogPath))
            {
                FileStream fs = File.Create(_LogPath);
                fs.Close();
            }

            File.AppendAllText(_LogPath, String.Format("An error of type {0} has occured at {1}, with the following message : {2}\n", exception.GetType(), DateTime.Now, exception.Message));
        }
    }
}
