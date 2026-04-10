using ExamFinalePt1NR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFinalePt1NR.Interfaces
{
    public interface ILivreRepository : IRepository<Livre>
    {
        List<Livre> GetByCategorie(string categorie); //retourne tous les livres du dépôt appartenant à la
                                                      //catégorie passée en paramètre.
        List<Livre> GetByCritere(string critere); //retourne tous les livres du dépôt selon le critère passé en paramètre.
                                                  //Le critère peut être soit le titre, soit l’auteur, soit la catégorie.
    }
}
