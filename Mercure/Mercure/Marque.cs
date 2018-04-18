using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mercure
{
    public class Marque
    {
        private int Reference;
        private string Nom;

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="Marque"/>.
        /// </summary>
        /// <param name="Reference"> la référence de la marque </param>
        /// <param name="Nom"> le nom de la marque</param>
        public Marque(int Reference, string Nom)
        {
            this.Reference = Reference;
            this.Nom = Nom;
        }

        /// <summary>
        /// Retourne la référence de la marque.
        /// </summary>
        /// <returns> La référence de la marque </returns>
        public int Recuperer_Reference()
        {
            return Reference;
        }

        /// <summary>
        /// Retourne le nom de la marque.
        /// </summary>
        /// <returns> Le nom de la marque </returns>
        public string Recuperer_Nom()
        {
            return Nom;
        }

        /// <summary>
        /// Retourne un <see cref="string"/> contenant le nom de la marque.
        /// </summary>
        /// <returns>Le nom de la marque</returns>
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
            string[] Donnees = { Convert.ToString(Reference), Nom };

            return Donnees;
        }
    }
}
