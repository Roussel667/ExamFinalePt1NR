using ExamFinalePt1NR.Models;
using ExamFinalePt1NR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace ExamFinalePt1NR.ViewModels
{
    public class LivreViewModel
    {
        private LivreService _service;
        public List<Livre> Livres { get; set; }

        public LivreViewModel(LivreService service)
        {
            _service = service;
        }
        public void ChargerLivres() //Charge(rempli) laliste des livres.
        {
            Livres = _service.GetAllLivre();
        }
        public List<Livre> GetAllLivres() //retourne la liste des livres.
        {
            return Livres; 
        }
        public void AjouterLivre(Livre nouveauLivre) //ajoute le livre au dépôt.
        {
            _service.AddLivre(nouveauLivre);
            ChargerLivres();
        }
        public void ModifierLivre(Livre livre) //Modifie le livre passé en paramètre.
        {
            _service.UpdateLivre(livre);
            ChargerLivres();
        }
        public void SupprimerLivre(int id) //supprime le livre dont l’id est passé comme paramètre.
        {
            _service.DeleteLivre(id);
            ChargerLivres();
        }
        public List<Livre> RechercherLivres(string critere) //retourne la liste des livres qui répondent
                                                            //au critère passé comme paramètre.
        {
             return _service.SearchLivres(critere);
        }
    }
}
