//This code was generated by a tool.
//Changes to this file will be lost if the code is regenerated.
// See the blog post here for help on using the generated code: http://erikej.blogspot.dk/2014/10/database-first-with-sqlite-in-universal.html
using System.Data.SQLite;
using System;

namespace Mercure
{
    
    public class SQLiteDb
    {
        string _path;
        public SQLiteDb(string path)
        {
            _path = path;
        }
        
         public void Create()
        {

        }
    }

    public partial class Articles
    {
        //[PrimaryKey]
        public Object RefArticle { get; set; }
        
        //[MaxLength(150)]
        //[NotNull]
        public String Description { get; set; }
        
        //[NotNull]
        public Object RefSousFamille { get; set; }
        
        //[NotNull]
        public Object RefMarque { get; set; }
        
        //[NotNull]
        public Double PrixHT { get; set; }
        
        //[NotNull]
        public Object Quantite { get; set; }
        
    }
    
    public partial class Familles
    {
        //[PrimaryKey]
        public Object RefFamille { get; set; }
        
        //[NotNull]
        public Object Nom { get; set; }
        
    }
    
    public partial class Marques
    {
        //PrimaryKey]
        public Object RefMarque { get; set; }
        
        //[NotNull]
        public Object Nom { get; set; }
        
    }
    
    public partial class SousFamilles
    {
        //[PrimaryKey]
        public Object RefSousFamille { get; set; }
        
        //[NotNull]
        public Object RefFamille { get; set; }
        
        //[NotNull]
        public Object Nom { get; set; }
       
    }
    
}