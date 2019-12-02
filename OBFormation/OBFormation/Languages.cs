using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nini.Config;

namespace OBFormation
{
    static class Languages
    {
        private static IniConfigSource _Ini = null;

        private static IniConfigSource Ini
        {
            get
            {
                if (_Ini == null)
                {
                    try
                    {
                        _Ini = new IniConfigSource("languages.ini");
                    }
                    catch (Exception ex)
                    {
                        Log.SaveErrorData(ex);
                        MessageBox.Show("Unable to load languages.ini file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        Environment.Exit(0);
                    }
                }

                return _Ini;
            }
        }

        public static List<string> GetLanguagesList()
        {
            List<string> languagesList = new List<string>();
            foreach(ConfigBase section in Ini.Configs)
            {
                languagesList.Add(section.Name);
            }
            return languagesList;
        }

        public static string GetTranslation(string language, string phraseCode)
        {
            try
            {
                return Ini.Configs[language].GetString(phraseCode);
            }
            catch (Exception ex)
            {
                Log.SaveErrorData(ex);
                return "? No language ?";
            }
        }
    }
}
