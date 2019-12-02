using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace _2019_04_09_DefiWinFormsHorlogeParlante
{
    public partial class Fenetre : Form
    {
        public Fenetre()
        {
            InitializeComponent();
        }
        private SpeechSynthesizer synth = new SpeechSynthesizer();

        private void SpeechButtonSayDate_Click(object sender, EventArgs e)
        {
            string message = String.Format("Nous sommes le {0}.", DateTime.Now.ToShortDateString());
            synth.Speak(message);
        }
        private void SpeechButtonSayDay_Click(object sender, EventArgs e)
        {
            var culture = new System.Globalization.CultureInfo("fr-FR");
            var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            string message = String.Format("Nous sommes {0}.", day);
            synth.Speak(message);
        }
        private void SpeechButtonSayHour_Click(object sender, EventArgs e)
        {
            string message = String.Format("Il est actuellement {0}.", DateTime.Now.ToShortTimeString());
            synth.Speak(message);
        }
    }
}
