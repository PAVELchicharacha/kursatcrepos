using System.Windows;
using WpfApp1.ViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Логика взаимодействия для WindowRequests.xaml
    /// </summary>
    public partial class WindowRequests : Window
    {
        public WindowRequests()
        {
            InitializeComponent();
        }

        private void Selector_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            switch (Selector.SelectedIndex)
            {
                case 0:
                    DisplaceInformation.ItemsSource = new ClubVisitorVM().getVisitors();
                    break;
                case 1:
                    DisplaceInformation.ItemsSource = new CoachVM().getCoaches();
                    break;
                case 2:
                    DisplaceInformation.ItemsSource = new ClubServiceVM().getServices();
                    break;
            }
        }
    }
}
