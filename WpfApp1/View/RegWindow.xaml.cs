using courseworkkk.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace courseworkkk.View
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
            DataContext = new LoginViewModel(this);
        }

        private void Button_RegClick(object sender, RoutedEventArgs e)
        {
            string log = LoginBox.Text.Trim();
            string pass = PasswordBox.Password.Trim();

            if(log.Length < 5)
            {
                LoginBox.ToolTip = "В логине должно быть не менее 5-ти символов!";
                LoginBox.Background = Brushes.LightYellow;
            } 
            if (pass.Length < 5) 
            {
                PasswordBox.ToolTip = "В пароле должно быть не менее 5-ти символов!";
                PasswordBox.Background = Brushes.LightYellow;
            }
            if (log.Length >= 5)
            {
                LoginBox.ToolTip = "Все хорошо";
                LoginBox.Background = Brushes.Transparent;
            }
            if (pass.Length >= 5)
            {
                PasswordBox.ToolTip = "Все хорошо";
                PasswordBox.Background = Brushes.Transparent;
            }
        }
    }
}
