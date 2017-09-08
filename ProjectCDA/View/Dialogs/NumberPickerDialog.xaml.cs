using System.Windows;

namespace ProjectCDA.View.Dialogs
{
    public partial class NumberPickerDialog : Window
    {
        private int _defaultVal;

        public NumberPickerDialog(int defaultVal, int minVal, int maxVal)
        {
            InitializeComponent();

            intUpDown.Value = _defaultVal = defaultVal;
            intUpDown.Minimum = minVal;
            intUpDown.Maximum = maxVal;
        }

        private void BtnDefault_Click(object sender, RoutedEventArgs e)
        {
            intUpDown.Value = _defaultVal;
        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            intUpDown.Value = intUpDown.Minimum;
        }

        private void BtnDialogOk_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public int Value
        {
            get { return intUpDown.Value is int ? (int)intUpDown.Value : (int)intUpDown.Minimum; }
        }
    }
}
