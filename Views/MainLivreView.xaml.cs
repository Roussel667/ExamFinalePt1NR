using ExamFinalePt1NR.ViewModels;
using ExamFinalePt1NR.Views.UsersControls.Livre;
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
using System.Windows.Shapes;

namespace ExamFinalePt1NR.Views
{
    /// <summary>
    /// Logique d'interaction pour MainLivreView.xaml
    /// </summary>
    public partial class MainLivreView : Window
    {
        private LivreViewModel _livreViewModel;
        public MainLivreView()
        {
            InitializeComponent();
        }

        //Fermer l,application
        private void BtnClick_Quitter(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnClick_Ajouter(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Affichage de la section Ajouter");
            MainContent.Content = new AddLivreView();
        }

        

        private void BtnClick_Supprimer(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Affichage de la section Supprimer");
            MainContent.Content = new DeleteLivreView();
            
        }

        private void BtnClick_Modifier(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Affichage de la section Modifier");
            MainContent.Content = new UpdateLivreView();
        }

        private void BtnClick_Rechercher(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Affichage de la section Rechercher");
            MainContent.Content = new FindLivreView();
        }
    }
}
