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


        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Article"/>.
        /// </summary>
        /// <param name="Reference"> la référence de l'article </param>
        /// <param name="Description"> le description de l'article </param>
        /// <param name="Sous_Famille"> la sous-famille associée </param>
        /// <param name="Marque"> la marque de l'article </param>
        /// <param name="Prix"> le prix unitaire (hors taxes) de l'article </param>
        /// <param name="Quantite"> la quantité de l'article présente </param>
        public Article(string Reference, string Description, SousFamille Sous_Famille, Marque Marque, double Prix, int Quantite)
        {
            this.Reference = Reference;
            this.Description = Description;

            this.Sous_Famille = Sous_Famille;

            this.Marque = Marque;

            this.Prix = Prix;

            this.Quantite = Quantite;
        }

        /// <summary>
        /// Retourne la référence de l'article.
        /// </summary>
        /// <returns>La référence</returns>
        public string Recuperer_Reference()
        {
            return Reference;
        }

        /// <summary>
        /// Retourne la description de l'article.
        /// </summary>
        /// <returns>La description</returns>
        public string Recuperer_Description()
        {
            return Description;
        }

        /// <summary>
        /// Retourne la sous-famille de l'article.
        /// </summary>
        /// <returns>Un objet <see cref="SousFamille"/></returns>
        public SousFamille Recuperer_Sous_Famille()
        {
            return Sous_Famille;
        }

        /// <summary>
        /// Retourne la marque de l'article.
        /// </summary>
        /// <returns>Un objet <see cref="Marque"/></returns>
        public Marque Recuperer_Marque()
        {
            return Marque;
        }

        /// <summary>
        /// Retourne le prix unitaire hors taxes de l'article.
        /// </summary>
        /// <returns>Le prix unitaire hors taxes</returns>
        public double Recuperer_Prix()
        {
            return Prix;
        }

        /// <summary>
        /// Retourne la quantité de l'article présente.
        /// </summary>
        /// <returns>La quantité d'articles présents</returns>
        public int Recuperer_Quantite()
        {
            return Quantite;
        }

        /// <summary>
        /// Retourne l'ensemble des données définissant l'article sous forme de tableau.
        /// </summary>
        /// <returns>Un tableau de <see cref="string"/></returns>
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
