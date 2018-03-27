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
        public SortOrder Tri = SortOrder.Ascending;

        public int Colonne;

        public List_View_Comparateur_Items()
        {
            Colonne = 0;
        }

        public List_View_Comparateur_Items(int Colonne)
        {
            this.Colonne = Colonne;
        }

        public int Compare(object Compare, object Comparant)
        {
            int Valeur = String.Compare(((ListViewItem) Compare).SubItems[Colonne].Text,
                                        ((ListViewItem )Comparant).SubItems[Colonne].Text);

            if (Tri == SortOrder.Descending)
                return -Valeur;

            else
                return Valeur;
        }
    }
}
