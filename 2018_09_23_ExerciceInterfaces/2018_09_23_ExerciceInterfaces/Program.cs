using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_09_23_ExerciceInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnvoiMessageService envoiMessage1 = new EnvoiMailService();
            IEnvoiMessageService envoiMessage2 = new EnvoiSmsService();

            Utilisateur u1 = new Utilisateur("moi1@mail.com", "01 23 45 67 89", envoiMessage2);
            Utilisateur u2 = new Utilisateur("moi2@mail.com", "09 87 65 43 21", envoiMessage1);

            MessageService message = new MessageService();

            message.MessageBienvenue(u1);
            message.MessageBienvenue(u2);

            message.MessagePub(u1);
            message.MessagePub(u2);

        }
    }
}
