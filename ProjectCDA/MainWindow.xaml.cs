using System.Windows;
using System.Windows.Input;

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


        private void Cmd_CanExecute_Close(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Cmd_Executed_Close(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
