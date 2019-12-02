using System;
using System.Collections.Generic;
using System.Linq;
using LiteDB;
using System.Windows.Forms;

namespace _2019_04_12_MiniProjet2_CentreFormation
{
    public partial class FenetreEleves : Form
    {
        IEnumerable<Eleve> listeEleves = Data.RecupererListeEleves();
        public FenetreEleves()
        {
            InitializeComponent();
            foreach (Eleve eleve in listeEleves)
            {
                ElevesDGV.Rows.Add(eleve.Id, eleve.Prenom, eleve.Nom, eleve.DateDeNaissance, eleve.Adresse, eleve.CodePostal, eleve.Ville, eleve.TelFixe, eleve.TelMobile);
            }
        }

        private void AjoutEleve_Click(object sender, EventArgs e)
        {
            bool eleveExisteDeja = false;
            Eleve eleve = new Eleve
            {
                Prenom = PrenomEleveInput.Text,
                Nom = NomEleveInput.Text,
                DateDeNaissance = DateNaissancePicker.Value,
                Adresse = AdresseInput.Text,
                CodePostal = Convert.ToInt32(CodePostalInput.Text),
                Ville = VilleInput.Text,
                TelFixe = TelFixeInput.Text,
                TelMobile = TelPortableInput.Text
            };
            foreach (Eleve el in listeEleves)
            {
                eleveExisteDeja = (el.CompareTo(eleve) == 0);
                if (eleveExisteDeja)
                {
                    MessageBox.Show("Vous essayez de rentrer un élève déjà présent dans la base!", "Attention!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            if (!eleveExisteDeja)
            {

                Data.AjouterEleve(eleve);
                ElevesDGV.Rows.Add(eleve.Id, eleve.Prenom, eleve.Nom, eleve.DateDeNaissance, eleve.Adresse, eleve.CodePostal, eleve.Ville, eleve.TelFixe, eleve.TelMobile);
                ElevesDGV.Update();
                ElevesDGV.Refresh();
            }
        }

        private void ModifEleve_Click(object sender, EventArgs e)
        {
            Eleve eleve = new Eleve
            {
                Prenom = PrenomEleveInput.Text,
                Nom = NomEleveInput.Text,
                DateDeNaissance = DateNaissancePicker.Value,
                Adresse = AdresseInput.Text,
                CodePostal = Convert.ToInt32(CodePostalInput.Text),
                Ville = VilleInput.Text,
                TelFixe = TelFixeInput.Text,
                TelMobile = TelPortableInput.Text
            };
            eleve.Id = (int)ElevesDGV.CurrentRow.Cells[0].Value;

            using (LiteDatabase db = new LiteDatabase("base.db"))
            {
                db.GetCollection<Eleve>().Update(eleve);
            }
            ElevesDGV.SelectedCells[1].Value = eleve.Prenom;
            ElevesDGV.SelectedCells[2].Value = eleve.Nom;
            ElevesDGV.SelectedCells[3].Value = eleve.DateDeNaissance;
            ElevesDGV.SelectedCells[4].Value = eleve.Adresse;
            ElevesDGV.SelectedCells[5].Value = eleve.CodePostal;
            ElevesDGV.SelectedCells[6].Value = eleve.Ville;
            ElevesDGV.SelectedCells[7].Value = eleve.TelFixe;
            ElevesDGV.SelectedCells[8].Value = eleve.TelMobile;
            ElevesDGV.Update();
            ElevesDGV.Refresh();
            MessageBox.Show("L'élève a bien été modifié!", "Information.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Suppression_Click(object sender, EventArgs e)
        {


            DialogResult dr = MessageBox.Show("Voulez vous vraiment supprimer l'élève sélectionné?", "AVERTISSEMENT!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                using (LiteDatabase db = new LiteDatabase("base.db"))
                {
                    int idEleve = int.Parse(ElevesDGV.CurrentRow.Cells[0].Value.ToString());

                    // On supprime l'entrée dans la base de données
                    db.GetCollection<Eleve>().Delete(idEleve);
                }
                ElevesDGV.Rows.RemoveAt(ElevesDGV.CurrentRow.Index);

                ElevesDGV.Update();
                ElevesDGV.Refresh();
            }

        }

    }
}
