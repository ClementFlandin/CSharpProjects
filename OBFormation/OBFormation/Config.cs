using Nini.Config;
using System;
using System.Windows.Forms;

namespace OBFormation
{
    static class Config
    {
        private static IniConfigSource _Ini = null;

        public static IniConfigSource Ini
        {
            get
            {
                if (_Ini == null)
                {
                    try
                    {
                        _Ini = new IniConfigSource("MySQL.ini");
                    }
                    catch (Exception ex)
                    {
                        Log.SaveErrorData(ex);
                        MessageBox.Show("Unable to load MySQL.ini file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        Environment.Exit(0);
                    }
                }
                return _Ini;
            }
        }
    }
}
