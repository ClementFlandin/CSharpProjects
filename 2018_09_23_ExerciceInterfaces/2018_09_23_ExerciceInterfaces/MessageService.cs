using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_09_23_ExerciceInterfaces
{
    public class MessageService
    {
        public void MessageBienvenue(Utilisateur u)
        {
            String bienvenue = "Bienvenue à vous!";
            u.envoi.Envoyer(bienvenue, u);
        }

        public void MessagePub(Utilisateur u)
        {
            String message = "Nous vous envoyons ce message automatique pour vous dire que blablabla.... ";
            u.envoi.Envoyer(message, u);
        }
    }
}
