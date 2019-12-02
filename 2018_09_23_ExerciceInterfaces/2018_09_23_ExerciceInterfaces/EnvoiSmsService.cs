using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_09_23_ExerciceInterfaces
{
    public class EnvoiSmsService : IEnvoiMessageService
    {
        public void Envoyer(String message, Utilisateur u)
        {
            Console.WriteLine($"Message envoyé à {u.Telephone} : {message}");
        }
    }
}
