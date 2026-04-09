using ExamFinalePt1NR.Interfaces;
using ExamFinalePt1NR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFinalePt1NR.Data.REpositories.JsonRepositories
{
    public class JsonLivreRepository : ILivreRepository
    {
        private readonly string _filePath = "../../../Data/Livres.json";

        public void Add(Livre t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Livre t)
        {
            throw new NotImplementedException();
        }

        public List<Livre> GetALL()
        {
            throw new NotImplementedException();
        }

        public List<Livre> GetByCategorie(string catégorie)
        {
            throw new NotImplementedException();
        }

        public Livre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Livre t)
        {
            throw new NotImplementedException();
        }
    }
}
