using System;
using System.Collections.Generic;

namespace TestEfCore.DataAccess.DataObjects
{
    public partial class Stagiaire
    {
        public int IdStagiaire { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public int IdFormation { get; set; }

        public virtual Formation IdFormationNavigation { get; set; }
    }
}
