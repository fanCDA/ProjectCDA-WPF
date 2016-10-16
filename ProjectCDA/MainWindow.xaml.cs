using System.Windows;

namespace ProjectCDA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Menu_ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
