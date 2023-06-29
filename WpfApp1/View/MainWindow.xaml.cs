using courseworkkk.View;
using System.Windows;

namespace courseworkkk
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
            ExecutorProjectWindow executorProjectWindow = new ExecutorProjectWindow();
            executorProjectWindow.Show();
        }
        private void MenuItem_Click_Project(object sender, RoutedEventArgs e)
        {
            ProjectWindow projectWindow = new ProjectWindow();
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
