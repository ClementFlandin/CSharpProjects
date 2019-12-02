using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_04_24_TestTraductions
{
    static class Languages
    {
        /// <summary>
        /// Static method that allows to get the list of languages available
        /// </summary>
        /// <returns>List of languages</returns>
        public static List<Language> GetLanguages()
        {
            //We initialize an empty list of languages
            List<Language> languages = new List<Language>();
            //We ad two distinct languages to the list and then return the list
            Language french = new Language
            {
                Name = "Français"
            };
            languages.Add(french);
            Language english = new Language
            {
                Name = "English"
            };
            languages.Add(english);
            return languages;
        }
        /// <summary>
        /// Public class that sets the name of a language
        /// </summary>
        public class Language
        {
            public string Name { get; set; }
        }
    }
}
