using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercure
{
    public class SousFamille
    {
        private int Reference;
        private string Nom;

        private Famille Famille;

        public SousFamille(int Reference, string Nom, Famille Famille)
        {
            this.Reference = Reference;
            this.Nom = Nom;

            this.Famille = Famille;
        }

        public int Recuperer_Reference()
        {
            return Reference;
        }

        public string Recuperer_Nom()
        {
            return Nom;
        }

        public Famille Recuperer_Famille()
        {
            return Famille;
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
