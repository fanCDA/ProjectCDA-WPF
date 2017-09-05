using System.Windows;

namespace ProjectCDA.View.Dialogs
{
    public partial class InputDialogSample : Window
    {
        private static int DEFAULT_PAGE_NUMBER = 129;

        public InputDialogSample()
        {
            InitializeComponent();
        }

        private void BtnDefault_Click(object sender, RoutedEventArgs e)
        {
            intUpDown.Value = DEFAULT_PAGE_NUMBER;
        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            intUpDown.Value = intUpDown.Minimum;
        }

        private void BtnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public int? Value
        {
            get { return intUpDown.Value; }
        }
    }
}
