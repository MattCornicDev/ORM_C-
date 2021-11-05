using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TestEfCore.DataAccess.DataObjects;

namespace TestEfCore.BLL
{
    class BLLStagiaire
    {
        public List<Stagiaire> getStagiaires()
        {
            List<Stagiaire> liste = new List<Stagiaire>();

            using formationsContext db = new formationsContext();

            var form = from s in db.Stagiaire select s;

            foreach (var elt in form)
            {
                liste.Add(elt);
            }
            return liste;
        }
    }
}
