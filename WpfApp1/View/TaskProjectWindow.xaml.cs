using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Model;
using WpfApp1.ViewModel;

namespace WpfApp1.View
{
    /// <summary>
    /// Логика взаимодействия для TaskProjectWindow.xaml
    /// </summary>
    public partial class TaskProjectWindow : Window
    {
        ClubServiceVM VM = new ClubServiceVM();
        PaymentType PT = PaymentType.OnePayTime;
        public TaskProjectWindow()
        {
            InitializeComponent();
        }
        private void Button_NiceClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Успешно!");
            ClubServices CS = new ClubServices(ServiceName.Text, (float)Convert.ToDouble(ServiceCoast.Text), PT);
            VM.addService(CS);
        }

        private void PaymantType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PT = (PaymentType)PaymantTypeBox.SelectedValue;
        }

    }
}
