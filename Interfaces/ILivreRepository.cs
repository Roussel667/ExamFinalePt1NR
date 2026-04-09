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
        List<Livre> GetByCategorie(string catégorie); //retourne tous les livres du dépôt appartenant à la
                                                      //catégorie passée en paramètre.
    }
}
