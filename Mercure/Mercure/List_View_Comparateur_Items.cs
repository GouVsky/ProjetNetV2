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



        public List_View_Comparateur_Items()
        {
            Colonne = 0;

            Ordre = SortOrder.Ascending;
        }

        public List_View_Comparateur_Items(int Colonne, SortOrder Ordre)
        {
            this.Colonne = Colonne;

            this.Ordre = Ordre;
        }

        public int Compare(object Compare, object Comparant)
        {
            int Valeur = String.Compare(((ListViewItem) Compare).SubItems[Colonne].Text,
                                        ((ListViewItem) Comparant).SubItems[Colonne].Text);

            if (Ordre == SortOrder.Descending)
                Valeur *= -1;

            return Valeur;
        }
    }
}
