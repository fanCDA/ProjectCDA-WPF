﻿using ProjectCDA.View.Dialogs;
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
        private MainViewModel vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = (MainViewModel)DataContext;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            vm.LoadStartingData();
        }


        private void Cmd_Executed_New(object sender, ExecutedRoutedEventArgs e)
        {
            InputDialogSample inputDialog = new InputDialogSample();
            if (inputDialog.ShowDialog() == true)
            {
                // Debug.Print("Value: " + inputDialog.Value);
                vm.LoadBrandNewData(inputDialog.Value);
            }
        }

        private void Cmd_Executed_Save(object sender, ExecutedRoutedEventArgs e)
        {
            vm.SavedData();
        }

        private void Cmd_Executed_Close(object sender, ExecutedRoutedEventArgs e)
        {
            this.Close();
        }
    }
}
