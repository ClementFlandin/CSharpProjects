using System;

namespace _2018_09_23_ExerciceInterfaces
{
    public interface IEnvoiMessageService
    {
        void Envoyer(String message, Utilisateur u);
    }
}