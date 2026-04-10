using ExamFinalePt1NR.Data.REpositories.JsonRepositories;
using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour FindLivreView.xaml
    /// </summary>
    public partial class FindLivreView : UserControl
    {
        private JsonLivreRepository _jsonLivreRepository;
        public FindLivreView()
        {
            InitializeComponent();
            _jsonLivreRepository = new JsonLivreRepository();
        }

        private void BtnRechercher_Click(object sender, RoutedEventArgs e)
        {
            var critere = TxtCritere.Text.Trim();
            if (string.IsNullOrEmpty(TxtCritere.Text))
            {
                MessageBox.Show("Veuillez entrer un critère de recherche.");
                return;
            }
            else
            {
                var livresTrouves = _jsonLivreRepository.GetByCritere(critere);
                if (livresTrouves.Count == 0)
                {
                    MessageBox.Show("Aucun livre trouvé pour le critère spécifié.");
                }
                else
                {
                    DgLivre.ItemsSource = livresTrouves.ToList();
                }
            }
        }

        private void BtnAfficherTout_Click(object sender, RoutedEventArgs e)
        {
            DgLivre.ItemsSource = _jsonLivreRepository.GetALL().ToList();
        }
    }
}
