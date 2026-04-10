using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFinalePt1NR.Models
{
    public class Livre
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string Isbn { get; set; }
        public double Prix { get; set; }
        public string Categorie { get; set; }
        public int Quantite { get; set; }

        public Livre() 
        {

        }
        public Livre(int id, string titre, string auteur, string isbn, double prix, string categorie, int quantite)
        {
            Id = id;
            Titre = titre;
            Auteur = auteur;
            Isbn = isbn;
            Prix = prix;
            Categorie = categorie;
            Quantite = quantite;
        }
    }
}
