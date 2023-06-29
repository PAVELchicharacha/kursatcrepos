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

namespace WpfApp1.View
{
    /// <summary>
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        ClubVisitorVM VM = new ClubVisitorVM();
        ClubServiceVM serviceVM = new ClubServiceVM();
        Sex Sex = Sex.Male;
        public ClientWindow()
        {
            InitializeComponent();
            VisitorService.ItemsSource = serviceVM.getServices();
        }

        private void Button_NiceClick(object sender, RoutedEventArgs e)
        {
            ClubVisitor clubVisitor = new ClubVisitor(FirstName.Text, SecondName.Text, DateBirth.Text, Sex, VisitorService.SelectedValue as ClubServices);
            MessageBox.Show("Успешно!");
        }
        private void Gender_SelectionChanged(object sender, RoutedEventArgs e)
        {
            Sex = (Sex)Gender.SelectedValue;
        }
    }
}
