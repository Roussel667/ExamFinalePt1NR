using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamFinalePt1NR.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id); //retourne l’objet selon son ID.
        List<T> GetALL(); //retourne tous les objets du dépôt. 
        void Add(T t); //Ajoute l’objet au dépôt.
        void Update(T t); //Modifie l’objet du dépôt.
        void Delete(T t); //supprime l’objet du dépôt.
    }
}
