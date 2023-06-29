using System.Windows;
using WpfApp1.View;
using WpfApp1.ViewModel;

namespace WpfApp1 
{ 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();  
        }

        private void MenuItem_Click_Client(object sender, RoutedEventArgs e)
        {
            ClientWindow clientWindow = new ClientWindow();
            clientWindow.Show();
        }
        private void MenuItem_Click_Executor(object sender, RoutedEventArgs e)
        {
            CoachWindow executorProjectWindow = new CoachWindow();
            executorProjectWindow.Show();
        }
        private void MenuItem_Click_Project(object sender, RoutedEventArgs e)
        {
            TaskProjectWindow projectWindow = new TaskProjectWindow();
            projectWindow.Show();
        }
        private void MenuItem_Click_Requests(object sender, RoutedEventArgs e)
        {
            WindowRequests windowRequests = new WindowRequests();
            windowRequests.Show();
        }

        private void Button_ExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItem_TaskClick(object sender, RoutedEventArgs e)
        {
            TaskProjectWindow taskProjectWindow = new TaskProjectWindow();
            taskProjectWindow.Show();
            this.Close();
        }
    }
}
