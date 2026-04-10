using ExamFinalePt1NR.Interfaces;
using ExamFinalePt1NR.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ExamFinalePt1NR.Data.REpositories.JsonRepositories
{
    public class JsonLivreRepository : ILivreRepository
    {
        private readonly string _filePath = "../../../Data/Livres.json";

        public List<Livre> ChargerDepuisJson()
        {
            if (!File.Exists(_filePath))
                return new List<Livre>();

            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Livre>>(json) ?? new List<Livre>();
        }
        private void SauvegarderDansJson(List<Livre> livres)
        {
            string json = JsonSerializer.Serialize(livres, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        public void Add(Livre t)
        {
            List<Livre> livres= ChargerDepuisJson();

            t.Id = livres.Count > 0 ? livres.Max(p => p.Id) + 1 : 1;
            livres.Add(t);

            SauvegarderDansJson(livres);
        }

        public void Delete(Livre id)
        {
            List<Livre> livres = ChargerDepuisJson();
            Livre livreASupprimer = livres.FirstOrDefault(l => l.Id == id.Id);
            if (livreASupprimer != null)
            {
                livres.Remove(livreASupprimer);
                SauvegarderDansJson(livres);
            }
        }

        public List<Livre> GetALL()
        {
             return ChargerDepuisJson();
        }

        public List<Livre> GetByCategorie(string categorie)
        {
            return ChargerDepuisJson().Where(l => l.Categorie.Contains(categorie)).ToList();
        }

        public Livre GetById(int id)
        {
            return ChargerDepuisJson().FirstOrDefault(l => l.Id == id);
        }

        public void Update(Livre t)
        {
            List<Livre> livres = ChargerDepuisJson();
            Livre livreExist = livres.FirstOrDefault(l => l.Id == t.Id);

            if (livreExist != null)
            {
                livreExist.Titre = t.Titre;
                livreExist.Auteur = t.Auteur;
                livreExist.Isbn = t.Isbn;
                livreExist.Prix = t.Prix;
                livreExist.Categorie = t.Categorie;
                livreExist.Quantite = t.Quantite;

                SauvegarderDansJson(livres);
            }
        }

        public List<Livre> GetByCritere(string critere)
        {
            critere = critere.ToLower();
            return ChargerDepuisJson().Where(l =>  l.Titre.ToLower().Contains(critere) ||
                                                   l.Auteur.ToLower().Contains(critere) ||
                                                   l.Isbn.ToLower().Contains(critere) ||                                                 
                                                   l.Categorie.ToLower().Contains(critere)).ToList();
        }
    }
}
