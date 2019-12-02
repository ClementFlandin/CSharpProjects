using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2018_09_23_ExerciceInterfaces
{
    public class Utilisateur
    {
        private String _eMail;

        public String EMail
        {
            get { return _eMail; }
            set { _eMail = value; }
        }

        private String _telephone;

        public String Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }

        public IEnvoiMessageService envoi;

        public Utilisateur(String email, String telephone, IEnvoiMessageService preference)
        {
            this._eMail = email;
            this._telephone = telephone;
            this.envoi = preference;
        }
    }
}
