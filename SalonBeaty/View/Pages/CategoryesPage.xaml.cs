using SalonBeaty.Controllers;
using SalonBeaty.Models;
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

namespace SalonBeaty.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для CategoryesPage.xaml
    /// </summary>
    public partial class CategoryesPage : Page
    {
        int idCategory;
        public CategoryesPage()
        {
            InitializeComponent();
            CategoryesListView.ItemsSource = ServiceCategoryesController.GetServiceCategoryes();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Grid activeCategory = sender as Grid;
            ServiceCategoryes activeData = activeCategory.DataContext as ServiceCategoryes;
            this.NavigationService.Navigate(new ServicePage(activeData));
           
        }
    }
}
