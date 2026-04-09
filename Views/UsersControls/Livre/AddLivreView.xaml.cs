using ExamFinalePt1NR.Data.REpositories.JsonRepositories;
using ExamFinalePt1NR.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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

namespace ExamFinalePt1NR.Views.UsersControls.Livre
{
    /// <summary>
    /// Logique d'interaction pour AddLivreView.xaml
    /// </summary>
    public partial class AddLivreView : UserControl
    {
        private JsonLivreRepository _livreRepository;
        public AddLivreView()
        {
            InitializeComponent();
            _livreRepository = new JsonLivreRepository();

            CboCateg.SelectedIndex = 1;
            
        }

        private void BtnAjotuer_Click(object sender, RoutedEventArgs e)
        {
            string titre = TxtTitre.Text;
            string auteur = TxtAuteur.Text;
            string isbn = TxtISBn.Text;
            string prix = TxtPrix.Text;
            string quantite = TxtQuantte.Text;

            if (string.IsNullOrWhiteSpace(titre))
            {
                MessageBox.Show("Veuillez entrer le nom du livre.", "Validation", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!decimal.TryParse(prix, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal prix) &&
                !decimal.TryParse(prix, out prix))
            {
                MessageBox.Show("Veuillez entrer un prix valide.", "Validation", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (CboCateg.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une taille.", "Validation", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            

            Livre nouveauLivre = new Livre
            {
                Titre = titre,
                Auteur = auteur,
                Isbn = isbn,
                Quantite = quantite,
                Prix = prix,
                
            };

            _livreRepository.Add(nouveauLivre);

            MessageBox.Show("La pizza a été ajoutée avec succès.", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            TxtAuteur.Text = "";
            CboCateg.SelectedIndex = 1;
            TxtISBn.Text = "";
            TxtPrix.Text = "";
            TxtQuantte.Text = "";
            TxtTitre.Text = "";
        }
    }
}
