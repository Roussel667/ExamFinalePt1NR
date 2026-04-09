using ExamFinalePt1NR.Interfaces;
using ExamFinalePt1NR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace ExamFinalePt1NR.Services
{
    public class LivreService
    {
        private ILivreRepository _livreRepository;
        public LivreService(ILivreRepository livreRepository)
        {
            _livreRepository = livreRepository;
        }

        public List<Livre> GetAllLivre() //Cette méthode retourne la liste de tous les livres.
        {
            return _livreRepository.GetALL().ToList();
        }
        public Livre GetLivreById(int id)  //Cette méthode retourne le livre ayant l’ID passé comme paramètre s’il existe.
        {
            return _livreRepository.GetById(id);
        }
        public void AddLivre(Livre livre) //Cette méthodeajoute le livre passé comme paramètre au dépôt.
        {
            _livreRepository.Add(livre);
        }
        public void UpdateLivre(Livre livre) //Cette méthode met à jour le livre passé comme paramètre.
        {
            _livreRepository.Update(livre);
        }
        public void DeleteLivre(int id) //Cette méthode supprime le livre dont l’id est passé comme paramètre.
        {
            _livreRepository.Delete(GetLivreById(id));
        }
        public List<Livre> SearchLivres(string critere) //Cette méthode retourne la liste des livres
                                                        //selon le critère passé comme paramètre.
        {
            return _livreRepository.GetByCategorie(critere);
        }



    }
}
