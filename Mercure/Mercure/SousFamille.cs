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

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="SousFamille"/>.
        /// </summary>
        /// <param name="Reference"> la référence de la sous-famille </param>
        /// <param name="Nom"> le nom de la sous-famille</param>
        public SousFamille(int Reference, string Nom, Famille Famille)
        {
            this.Reference = Reference;
            this.Nom = Nom;

            this.Famille = Famille;
        }

        /// <summary>
        /// Associe une instance de <see cref="Famille"/> à la sous-famille.
        /// </summary>
        /// <param name="Famille">La famille à associer </param>
        public void Definir_Famille(Famille Famille)
        {
            this.Famille = Famille;
        }

        /// <summary>
        /// Retourne la référence de la sous-famille.
        /// </summary>
        /// <returns> La référence de la sous-famille </returns>
        public int Recuperer_Reference()
        {
            return Reference;
        }

        /// <summary>
        /// Retourne le nom de la sous-famille.
        /// </summary>
        /// <returns> Le nom de la sous-famille </returns>
        public string Recuperer_Nom()
        {
            return Nom;
        }

        /// <summary>
        /// Retourne la famille associée à la sous_famille.
        /// </summary>
        /// <returns>La famille associée à la sous-famille</returns>
        public Famille Recuperer_Famille()
        {
            return Famille;
        }

        /// <summary>
        /// Retourne un <see cref="string"/> contenant le nom de la sous-famille.
        /// </summary>
        /// <returns>Le nom de la sous-famille</returns>
        public override string ToString()
        {
            return Nom;
        }

        /// <summary>
        /// Retourne l'ensemble des données définissant la marque sous forme de tableau.
        /// </summary>
        /// <returns>Un tableau de <see cref="string"/></returns>
        public string[] Recuperer_Donnees()
        {
            string[] Donnees = { Convert.ToString(Reference), Nom, Famille.ToString() };

            return Donnees;
        }
    }
}
