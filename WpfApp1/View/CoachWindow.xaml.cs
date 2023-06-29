using courseworkkk.ViewModel;
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
using WpfApp1.Model;
using WpfApp1.ViewModel;

namespace courseworkkk.View
{
    /// <summary>
    /// Логика взаимодействия для ExecutorProjectWindow.xaml
    /// </summary>
    public partial class ExecutorProjectWindow : Window
    {
        CoachVM VM = new CoachVM();
        ClubServiceVM serviceVM = new ClubServiceVM();
        Sex Gender = Sex.Male;
        public ExecutorProjectWindow()
        {
            InitializeComponent();
            CoachesService.ItemsSource = serviceVM.getServices();
            DataContext = new ExecutorProjectViewModel(this);
        }
        private void Button_NiceClick(object sender, RoutedEventArgs e)
        {
            Coach coach = new Coach(FirstName.Text, SecondName.text, DateBirth.text,Gender, CoachesService.SelectedValue as ClubServices);
            MessageBox.Show("Успешно!");
        }
        private void Gender_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Gender = (Sex)Gender.SelectedValue;
        }
    }
}
