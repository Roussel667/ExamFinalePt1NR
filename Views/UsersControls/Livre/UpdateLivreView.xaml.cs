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

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnChercher_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
