using ExamFinalePt1NR.Data.REpositories.JsonRepositories;
using ExamFinalePt1NR.Interfaces;
using ExamFinalePt1NR.Models;
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
    /// Logique d'interaction pour DeleteLivreView.xaml
    /// </summary>
    public partial class DeleteLivreView : UserControl
    {
        private JsonLivreRepository _livreRepository;
        private Models.Livre _livreaSupprimer;

        public DeleteLivreView()
        {
            InitializeComponent();
            _livreRepository = new JsonLivreRepository();
            
        }

        private void BtnClick_Supprimer(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtId.Text))
            {
                MessageBox.Show("Veuillez entrer un ID.");
                return;
            }

            if (!int.TryParse(TxtId.Text, out int id))
            {
                MessageBox.Show("L'ID doit être un nombre valide.");
                return;
            }

            _livreaSupprimer = _livreRepository.GetById(id);

            if (_livreaSupprimer== null)
            {
                MessageBox.Show("Aucun livre sélectionnée.");
                return;
            }

            _livreRepository.Delete(_livreaSupprimer);
            MessageBox.Show("Livre supprimée avec succès.");

            TxtId.Clear();
            
            
            _livreaSupprimer = null;
        }

        private void BtnClick_Annuler(object sender, RoutedEventArgs e)
        {
            TxtId.Clear();
        }
    }
}
