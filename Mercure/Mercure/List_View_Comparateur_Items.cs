using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    class List_View_Comparateur_Items : IComparer
    {
        private int Colonne;

        private SortOrder Ordre;


        /// <summary>
        /// Initialise une nouvelle instance de <see cref="List_View_Comparateur_Items"/>.
        /// </summary>
        public List_View_Comparateur_Items()
        {
            Colonne = 0;

            Ordre = SortOrder.Ascending;
        }

        /// <summary>
        /// Initialise une nouvelle instance de <see cref="List_View_Comparateur_Items"/> avec une colonne et un type de tri.
        /// </summary>
        /// <param name="Colonne"> le numéro de la colonne à trier </param>
        /// <param name="Ordre"> le type de tri à effectuer </param>
        public List_View_Comparateur_Items(int Colonne, SortOrder Ordre)
        {
            this.Colonne = Colonne;

            this.Ordre = Ordre;
        }

        /// <summary>
        /// Compare chaque élément de liste entre eux.
        /// </summary>
        /// <param name="Compare"> l'élément de référence </param>
        /// <param name="Comparant"> l'élément comparant </param>
        /// <returns></returns>
        public int Compare(object Compare, object Comparant)
        {
            int Valeur = 0;

            double Compare_Nombre = 0;
            double Comparant_Nombre = 0;

            string Compare_Texte = ((ListViewItem) Compare).SubItems[Colonne].Text;
            string Comparant_Texte = ((ListViewItem) Comparant).SubItems[Colonne].Text;


            // Si l'on souhaite effectuer un tri sur une colonne contenant des valeurs numériques,
            // il ne faut pas trier dans un ordre alphanumérique mais dans un ordre croissant.

            if (double.TryParse(Compare_Texte, out Compare_Nombre)
                && double.TryParse(Comparant_Texte, out Comparant_Nombre))
            {
                Valeur = Compare_Nombre.CompareTo(Comparant_Nombre);
            }

            else
                Valeur = String.Compare(Compare_Texte, Comparant_Texte);

            if (Ordre == SortOrder.Descending)
                Valeur *= -1;

            return Valeur;
        }
    }
}
