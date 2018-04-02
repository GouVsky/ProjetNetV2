using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mercure
{
    public partial class Fenetre_Ajout_Article : Form
    {
        public Fenetre_Ajout_Article()
        {
            InitializeComponent();
        }

        public Fenetre_Ajout_Article(ListViewItem Article)
        {
            InitializeComponent();
        }
    }
}
