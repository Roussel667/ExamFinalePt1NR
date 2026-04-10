using ExamFinalePt1NR.Data.REpositories.JsonRepositories;
using ExamFinalePt1NR.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            CboCateg.SelectedIndex = 0;
            
        }

        private void BtnAjotuer_Click(object sender, RoutedEventArgs e)
        {
            string titre = TxtTitre.Text;
            string auteur = TxtAuteur.Text;
            string isbn = TxtISBn.Text;
            double prix = double.Parse(TxtPrix.Text);
            int quantite = int.Parse(TxtQuantte.Text);

            if (string.IsNullOrWhiteSpace(titre))
            {
                MessageBox.Show("Veuillez entrer le nom du livre.", "Validation", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!double.TryParse(TxtPrix.Text, out double prixDecimal))
            {
                MessageBox.Show("Veuillez entrer un prix valide.", "Validation", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (CboCateg.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une taille.", "Validation", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }


            Models.Livre nouveauLivre = new Models.Livre
            {
                Titre = titre,
                Auteur = auteur,
                Isbn = isbn,
                Prix = prix,
                Categorie = CboCateg.SelectionBoxItem.ToString(),
                Quantite = quantite,
            };

            _livreRepository.Add(nouveauLivre);

            MessageBox.Show("Le livre a été ajoutée avec succès.", "Succès", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            TxtAuteur.Text = "";
            CboCateg.SelectedIndex = 0;
            TxtISBn.Text = "";
            TxtPrix.Text = "0";
            TxtQuantte.Text = "0";
            TxtTitre.Text = "";
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BtnDecrementer_Click(object sender, RoutedEventArgs e)
        {
            TxtQuantte.Text = (int.Parse(TxtQuantte.Text) - 1).ToString();
            if (int.Parse(TxtQuantte.Text) < 0)
            {
                TxtQuantte.Text = "0";
            }

        }

        private void BtnIncrementer_Click(object sender, RoutedEventArgs e)
        {
            TxtQuantte.Text = (int.Parse(TxtQuantte.Text) + 1).ToString();
        }
    }
}
