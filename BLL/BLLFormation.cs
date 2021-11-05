using System;
using System.Collections.Generic;
using System.Text;
using TestEfCore.DataAccess.DataObjects;
using System.Linq;

namespace TestEfCore.BLL
{
    class BLLFormation
    {
        // Méthode qui permet d'ajouter une nouvelle formation
        public void ajouterFormation(string _Nom, string _niveau, int _nbStagiaire)
        {
            //bool testOK = false;
            ////Création d'un nouvel objet Formation
            //using formationsContext db = new formationsContext();
            ////Ajoutons maintenant la nouvelle formation à la classe puis ajoutons la classe au DataContext
            //db.Formation.Add(formationAAjouter);//on ajoute un objet dans la liste
            //if (db.SaveChanges() > 0)// on persiste en base
            //    testOK = true;
            //return testOK;

            using var db = new formationsContext();
            Formation newFormation = new Formation()
            {
                Nom = _Nom,
                Niveau = _niveau,
                NbStagiaires = _nbStagiaire
            };

            db.Formation.Add(newFormation);
            db.SaveChanges();
        }
        // Méthode qui permet d'ajouter une nouvelle formation
        public bool supprimerFormation(int PK)
        {
            bool testOK = false;
            //Création d'un nouvel objet Formation
            using formationsContext db = new formationsContext();
            // Je cherche la formation qui correspond à la PK
            var form = from f in db.Formation where (f.IdFormation == PK) select f;
            //Je supprime la formation du context
            db.Formation.Remove(form.First());
            if (db.SaveChanges() > 0)// on persiste en base
                testOK = true;
            return testOK;
        }
        public List<Formation> getFormation()
        {
            List<Formation> liste = new List<Formation>();
            //Création d'un nouvel objet Formation
            using formationsContext db = new formationsContext();
            var form = from f in db.Formation select f;

            foreach (var elt in form)
            {
                liste.Add(elt);
            }
            return liste;
        }
    }
}
