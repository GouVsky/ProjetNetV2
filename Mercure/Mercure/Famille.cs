using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercure
{
    public class Famille
    {
        private string Reference;
        private string Nom;

        public Famille(string Reference, string Nom)
        {
            this.Reference = Reference;
            this.Nom = Nom;
        }

        public string Recuperer_Reference()
        {
            return Reference;
        }

        public string Recuperer_Nom()
        {
            return Nom;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
