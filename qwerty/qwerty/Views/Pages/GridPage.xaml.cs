using qwerty.Classes;
using qwerty.Models;
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

namespace qwerty.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для GridPage.xaml
    /// </summary>
    public partial class GridPage : Page
    {
        public GridPage()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            COURSEREGISTRATION deleteCoruseregistration = (COURSEREGISTRATION)dbView.SelectedItem;
            dbContext.db.COURSEREGISTRATION.Remove(deleteCoruseregistration);
            dbContext.db.SaveChanges();
            Page_Loaded(null, null);
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            dbContext.db.SaveChanges();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dbView.ItemsSource = dbContext.db.COURSEREGISTRATION.ToList();
        }
    }
}
