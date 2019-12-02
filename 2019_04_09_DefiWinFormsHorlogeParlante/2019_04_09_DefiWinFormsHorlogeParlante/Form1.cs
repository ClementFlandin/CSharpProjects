using System;
using System.Windows.Forms;

namespace _2019_04_09_DefiWinFormsHorlogeParlante
{
    public partial class Fenetre : Form
    {
        public Fenetre()
        {
            InitializeComponent();
        }

        private void ButtonSayDate_Click(object sender, EventArgs e)
        {

            string message = String.Format("Nous sommes le {0}.", DateTime.Now.ToShortDateString());
            MessageBox.Show(message);
        }
        private void ButtonSayDay_Click(object sender, EventArgs e)
        {
            var culture = new System.Globalization.CultureInfo("fr-FR");
            var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            string message = String.Format("Nous sommes {0}.", day);
            MessageBox.Show(message);
        }
        private void ButtonSayHour_Click(object sender, EventArgs e)
        {
            string message = String.Format("Il est actuellement {0}.", DateTime.Now.ToShortTimeString());
            MessageBox.Show(message);
        }
    }
}
