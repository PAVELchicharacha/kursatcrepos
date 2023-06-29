using System;
using System.Windows;
using WpfApp1.Model;
using WpfApp1.ViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Логика взаимодействия для CoachWindow.xaml
    /// </summary>
    public partial class CoachWindow : Window
    {
        CoachVM VM = new CoachVM();
        ClubServiceVM serviceVM = new ClubServiceVM();
        Sex Sex = Sex.Male;
        public CoachWindow()
        {
            InitializeComponent();
            CoachesService.ItemsSource = serviceVM.getServices();
        }
        private void Button_NiceClick(object sender, RoutedEventArgs e)
        {
            Coach coach = new Coach(FirstName.Text, SecondName.Text, Convert.ToByte(DateBirth.Text), Sex, CoachesService.SelectedValue as ClubServices);
            MessageBox.Show("Успешно!");
        }
        private void Gender_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Sex = (Sex)Gender.SelectedValue;
        }
    }
}
