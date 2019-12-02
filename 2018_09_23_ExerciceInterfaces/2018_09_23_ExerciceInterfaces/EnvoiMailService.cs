using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_09_23_ExerciceInterfaces
{
    public class EnvoiMailService : IEnvoiMessageService
    {
        public void Envoyer(String message, Utilisateur u)
        {
            Console.WriteLine($"Message envoyé à {u.EMail} : {message}");
        }
    }
}
