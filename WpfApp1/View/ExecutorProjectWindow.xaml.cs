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

namespace courseworkkk.View
{
    /// <summary>
    /// Логика взаимодействия для ExecutorProjectWindow.xaml
    /// </summary>
    public partial class ExecutorProjectWindow : Window
    {
        public ExecutorProjectWindow()
        {
            InitializeComponent();
            DataContext = new ExecutorProjectViewModel(this);
        }
        private void Button_NiceClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Успешно!");
        }
    }
}
