using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercure
{
    public class Article
    {
        private string Reference;
        private string Description;

        private SousFamille Sous_Famille;

        private Marque Marque;

        private double Prix;

        private int Quantite;


        public Article(string Reference, string Description, SousFamille Sous_Famille, Marque Marque, double Prix, int Quantite)
        {
            this.Reference = Reference;
            this.Description = Description;

            this.Sous_Famille = Sous_Famille;

            this.Marque = Marque;

            this.Prix = Prix;

            this.Quantite = Quantite;
        }

        public string Recuperer_Reference()
        {
            return Reference;
        }

        public string Recuperer_Description()
        {
            return Description;
        }

        public SousFamille Recuperer_Sous_Famille()
        {
            return Sous_Famille;
        }

        public Marque Recuperer_Marque()
        {
            return Marque;
        }

        public double Recuperer_Prix()
        {
            return Prix;
        }

        public int Recuperer_Quantite()
        {
            return Quantite;
        }

        public string[] Recuperer_Donnees()
        {
            string[] Donnees = {Reference,
                                Description,
                                Sous_Famille.Recuperer_Famille().Recuperer_Nom(),
                                Sous_Famille.Recuperer_Nom(),
                                Marque.Recuperer_Nom(),
                                Convert.ToString(Prix),
                                Convert.ToString(Quantite)};

            return Donnees;
        }
    }
}
