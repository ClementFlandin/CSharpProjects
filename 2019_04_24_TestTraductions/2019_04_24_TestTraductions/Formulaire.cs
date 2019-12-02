using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _2019_04_24_TestTraductions.Languages;
using Nini.Config;
using System.Threading;
using System.Globalization;

namespace _2019_04_24_TestTraductions
{
    public partial class Formulaire : Form
    {
        /// <summary>
        /// We initialize the winform along with its combobox
        /// </summary>
        public Formulaire()
        {
            InitializeComponent();
            InitializeCombobox();
        }
        /// <summary>
        /// We set the ini config source
        /// </summary>
        private readonly IniConfigSource fichierIni = new IniConfigSource("languages.ini");

        /// <summary>
        /// Initialization of the combobox items
        /// </summary>
        private void InitializeCombobox()
        {
            //We get the languages list from the Data class
            List<Language> languages = Languages.GetLanguages();
            //For each language we add its name to a combobox item
            foreach (Language language in languages)
            {
                LanguagesAvailable.Items.Add(language.Name);
            }
        }
        /// <summary>
        /// Event called when we click the button, displays a message depending on the language selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            //A string called language that is set to the combobox selected languag
            string language = LanguagesAvailable.Text;
            //We choose the CultureInfo depending on the language
            if (language == "Français")
            {
                SetCultureInfo(new CultureInfo("fr-FR"));
            }
            else if (LanguagesAvailable.Text == "English")
            {
                SetCultureInfo(new CultureInfo("en-UK"));
            }
            SetMessageContent(language);
        }

        private void LanguagesAvailable_TextChanged(object sender, EventArgs e)
        {
            string language = LanguagesAvailable.Text;
            SetLabelsAndButtonTexts(language);
        }
        /// <summary>
        /// We set the message content depending on the language
        /// </summary>
        /// <param name="language">Language selected in the combobox</param>
        private void SetMessageContent(string language)
        {
            MessageBox.Show(String.Format(fichierIni.Configs[language].GetString("MessageButton"), textbox1.Text, DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString()));
        }
        /// <summary>
        /// We set the culture info
        /// </summary>
        /// <param name="ci"></param>
        private void SetCultureInfo(CultureInfo ci)
        {
            Thread.CurrentThread.CurrentCulture = ci;
        }
        /// <summary>
        /// We set the labels and button text depending on the selected language in the combobox
        /// </summary>
        /// <param name="language"></param>
        private void SetLabelsAndButtonTexts(string language)
        {
            FirstName.Text = fichierIni.Configs[language].GetString("FirstName");
            LastName.Text = fichierIni.Configs[language].GetString("LastName");
            Language.Text = fichierIni.Configs[language].GetString("Language");
            Button.Text = fichierIni.Configs[language].GetString("Button").ToUpper();
        }
    }
}
