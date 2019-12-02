using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using LiteDB;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _2019_04_12_MiniProjet_GestionnaireMDP.PasswordAdvisor;
using static _2019_04_12_MiniProjet_GestionnaireMDP.Hash;

namespace _2019_04_12_MiniProjet_GestionnaireMDP
{
    public partial class Security : Form
    {
        public Security()
        {
            InitializeComponent();
            foreach (CompteUtilisateur compte in listeComptes)
            {
                LiteDBDataGridView.Rows.Add(compte.NomSiteWeb,compte.NomUtilisateur,compte.HashMotDePasse);
            }
        }

        // On récupère la liste des comptes depuis la base
        IEnumerable<CompteUtilisateur> listeComptes = Data.RecupererListeComptes();

        private void UserDataInput_Click(object sender, EventArgs e)
        {
            string site = SiteInput.Text;
            string utilisateur = UserInput.Text;
            string mdp = PasswordInput.Text;
            string hashMdp = GetHashSha256(mdp);

            if (site != "" && utilisateur != "")
            {
                PasswordScore score = CheckStrength(mdp);
                if (score == PasswordScore.Strong || score == PasswordScore.VeryStrong)
                {
                    bool hashCodeExiste = false;
                    foreach (CompteUtilisateur compte in listeComptes)
                    {
                        if (compte.HashMotDePasse == hashMdp)
                        {
                            hashCodeExiste = true;
                            MessageBox.Show("Votre mot de passe a déjà été enregistré", "Attention!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (!hashCodeExiste)
                    {
                        
                        Data.AjouterCompte(new CompteUtilisateur
                        {
                            NomSiteWeb = site,
                            NomUtilisateur = utilisateur,
                            HashMotDePasse = hashMdp
                        });
                        LiteDBDataGridView.Rows.Add(site, utilisateur, hashMdp);
                    }
                }
                else
                {
                    MessageBox.Show("Votre mot de passe n'est pas assez sécurisé!", "Attention!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vous devez rentrer des données correctes!", "Attention!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
