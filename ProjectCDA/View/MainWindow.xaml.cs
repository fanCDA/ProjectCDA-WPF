using ProjectCDA.View.Dialogs;
using ProjectCDA.ViewModel;
using System.Diagnostics;
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainViewModel vm = (MainViewModel)DataContext;
            vm.LoadStartingData();
        }


        private void Cmd_Executed_New(object sender, ExecutedRoutedEventArgs e)
        {
            InputDialogSample inputDialog = new InputDialogSample();
            if (inputDialog.ShowDialog() == true)
            {
                Debug.Print("Value: " + inputDialog.Value);
            }
        }

        private void Cmd_Executed_Save(object sender, ExecutedRoutedEventArgs e)
        {
            MainViewModel vm = (MainViewModel)DataContext;
            vm.SavedData();
        }

        private void Cmd_Executed_Close(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
