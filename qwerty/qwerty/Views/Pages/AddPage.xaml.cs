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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
            cmbTrainer.ItemsSource = dbContext.db.TRAINER.Select(item => item.Name).ToList();
            cmbCourse.ItemsSource = dbContext.db.COURSE.Select(item => item.Title).ToList();
        }

        private void btnDataGrid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GridPage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            COURSEREGISTRATION newCourseregistration = new COURSEREGISTRATION();

            var a = dbContext.db.TRAINER.FirstOrDefault(item => item.Name == cmbTrainer.Text);
            var b = dbContext.db.COURSE.FirstOrDefault(item => item.Title == cmbCourse.Text);

            newCourseregistration.CreatedDate = Convert.ToDateTime(dpCreatedDate.SelectedDate);
            newCourseregistration.IsDone = txbIsDone.Text;
            newCourseregistration.TotalPoint = Convert.ToInt32(txbTotalPoint.Text);
            newCourseregistration.Comment = txbComment.Text;

            newCourseregistration.Trainerid = a.Id;
            newCourseregistration.Courseid = b.Id;

            MessageBox.Show("Данные добавлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            dbContext.db.COURSEREGISTRATION.Add(newCourseregistration);
            dbContext.db.SaveChanges();
        }
    }
}
