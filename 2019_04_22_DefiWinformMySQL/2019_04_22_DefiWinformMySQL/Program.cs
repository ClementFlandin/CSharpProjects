﻿using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace _2019_04_22_DefiWinformMySQL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LaFerme());
            
        }


    }
}
