using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercure
{
    public class Famille
    {
        private int Reference;
        private string Nom;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Famille"/>.
        /// </summary>
        /// <param name="Reference"> la référence de la famille </param>
        /// <param name="Nom"> le nom de la famille </param>
        public Famille(int Reference, string Nom)
        {
            this.Reference = Reference;
            this.Nom = Nom;
        }

        /// <summary>
        /// Retourne la référence de la famille.
        /// </summary>
        /// <returns>La référence de la famille</returns>
        public int Recuperer_Reference()
        {
            return Reference;
        }

        /// <summary>
        /// Retourne le nom de la famille.
        /// </summary>
        /// <returns>Le nom de la famille</returns>
        public string Recuperer_Nom()
        {
            return Nom;
        }

        /// <summary>
        /// Retourne un <see cref="string"/> contenant le nom de la famille.
        /// </summary>
        /// <returns>Le nom de la famille</returns>
        public override string ToString()
        {
            return Nom;
        }

        /// <summary>
        /// Retourne l'ensemble des données définissant la famille sous forme de tableau.
        /// </summary>
        /// <returns>Un tableau de <see cref="string"/></returns>
        public string[] Recuperer_Donnees()
        {
            string[] Donnees = { Convert.ToString(Reference), Nom };

            return Donnees;
        }
    }
}
