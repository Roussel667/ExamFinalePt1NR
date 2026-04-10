using ExamFinalePt1NR.Data.REpositories.JsonRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamFinalePt1NR.Models;

namespace ExamFinalePt1NR.Views.UsersControls.Livre
{
    /// <summary>
    /// Logique d'interaction pour UpdateLivreView.xaml
    /// </summary>
    public partial class UpdateLivreView : UserControl
    {
        private JsonLivreRepository _jsonLivreRepository;
        private Models.Livre _livreAModifier;


        public UpdateLivreView()
        {
            InitializeComponent();
            _jsonLivreRepository = new JsonLivreRepository();
        }
        public void ChargerLivre()
        {
            var livres = _jsonLivreRepository.GetALL().ToList();
        }
        private void ChargerLivreFormulaire()
        {
            if (TxtId.Text == null)
                return;

           _livreAModifier = _jsonLivreRepository.GetById(int.Parse(TxtId.Text));

            TxtTitre.Text = _livreAModifier.Titre;
            TxtAuteur.Text = _livreAModifier.Auteur;
            TxtCategorie.Text = _livreAModifier.Categorie;
            TxtQuantite.Text = _livreAModifier.Quantite.ToString();
                      
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnChercher_Click(object sender, RoutedEventArgs e)
        {
            ChargerLivreFormulaire();
        }       
    }
}
