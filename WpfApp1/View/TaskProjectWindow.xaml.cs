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
    /// Логика взаимодействия для TaskProjectWindow.xaml
    /// </summary>
    public partial class TaskProjectWindow : Window
    {
        ClubServiceVM VM = new ClubServiceVM();
        PaymentType PT = PaymentType.OnePayTime;
        public TaskProjectWindow()
        {
            InitializeComponent();
            DataContext = new TaskProjectViewModel(this);
        }
        private void Button_NiceClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Успешно!");
            ClubServices CS = new ClubServices(ServiceName.text, (float)Convert.ToDouble(ServiceCoast.text), PT);
            VM.addService(CS);
        }

        private void PaymantType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PT = PaymantTypeBox.SelectedValue as PaymentType;
        }

    }
}
