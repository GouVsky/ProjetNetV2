﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercure
{
    public class Marque
    {
        private int Reference;
        private string Nom;

        public Marque(int Reference, string Nom)
        {
            this.Reference = Reference;
            this.Nom = Nom;
        }

        public int Recuperer_Reference()
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
