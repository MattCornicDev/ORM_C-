using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestEfCore.Views;

namespace TestEfCore.DataAccess.DataObjects
{
    public partial class Formation
    {
        public Formation()
        {
            Stagiaire = new HashSet<Stagiaire>();
        }

        public int IdFormation { get; set; }
        public string Nom { get; set; }
        public string Niveau { get; set; }
        public int NbStagiaires { get; set; }

        public virtual ICollection<Stagiaire> Stagiaire { get; set; }
    }
}
