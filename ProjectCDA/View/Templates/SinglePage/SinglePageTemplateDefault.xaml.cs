using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ProjectCDA.View.Templates.SinglePage
{
    /// <summary>
    /// Interaction logic for SinglePageTemplateDefault.xaml
    /// </summary>
    public partial class SinglePageTemplateDefault : UserControl
    {
        public SinglePageTemplateDefault()
        {
            InitializeComponent();
        }
        
        private void TextBox_PreviewDragEnter(object sender, DragEventArgs e)
        {
            Debug.Print("TextBox_DragEnter");
            e.Effects = DragDropEffects.Copy;
        }

        private void TextBox_PreviewDrop(object sender, DragEventArgs e)
        {
            Debug.Print("TextBox_PreviewDrop");
        }

        private void TextBox_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.Print("TextBox_MouseRightButtonDown => Start dragging");
        }




        private void TextBox_MouseMove(object sender, MouseEventArgs e)
        {
            /* TextBox textBox = sender as TextBox;
             if (textBox != null && e.LeftButton == MouseButtonState.Pressed)
             {
                 Debug.Print("TextBox_MouseMove => MOVE MOVE!!!");
                 DragDrop.DoDragDrop( (DependencyObject)e.Source,
                                      textBox.Text,
                                      DragDropEffects.Copy);
             }*/

            Debug.Print("TextBox_MouseMove");
            Debug.Print(e.ToString());
            Debug.Print(e.Source.ToString());
            Debug.Print(e.OriginalSource.ToString());

            if (e.RightButton == MouseButtonState.Pressed && e.OriginalSource is TextBox)
            {
                Debug.Print("MOVE MOVE!!!");

                DragDrop.DoDragDrop((DependencyObject)e.Source,
                                      (e.OriginalSource as TextBox).Text,
                                      DragDropEffects.Move);

                /*// Package the data.
                DataObject data = new DataObject();
                data.SetData("Text", (sender as TextBox).Text);
                data.SetData("Object", this);

                // Inititate the drag-and-drop operation.
                DragDrop.DoDragDrop(this, data, DragDropEffects.Copy | DragDropEffects.Move);*/
            }
        }

        private void TextBox_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            Debug.Print("TextBox_GiveFeedback => FEEDBACK!!!");
        }


        private void TextBox_DragEnter(object sender, DragEventArgs e)
        {
            Debug.Print("TextBox_DragEnter");
        }

        private void TextBox_DragLeave(object sender, DragEventArgs e)
        {
            Debug.Print("TextBox_DragLeave");
        }

        private void TextBox_DragOver(object sender, DragEventArgs e)
        {
            Debug.Print("TextBox_DragOver");
        }

        private void TextBox_Drop(object sender, DragEventArgs e)
        {
            Debug.Print("TextBox_Drop");
        }


        private void TextBox_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.Print("TextBox_MouseLeftButtonDown");
        }

        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.Print("TextBox_MouseDown");
        }

        private void TextBox_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            Debug.Print("TextBox_PreviewMouseUp");
        }


        private void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.Print("TextBox_PreviewMouseDown");

            if (e.RightButton == MouseButtonState.Pressed)
            {
                /*DragDrop.DoDragDrop((DependencyObject)e.Source,
                                 "LOL WUT",
                                 DragDropEffects.Move);

                e.Handled = true;*/

                //DragDrop.AddQueryContinueDragHandler(this, QueryContinueDragHandler);
            }
        }

        private void QueryContinueDragHandler(object source, QueryContinueDragEventArgs e)
        {
            Debug.Print("QueryContinueDragHandler");
            e.Handled = true;

            // Check if we need to bail
            if (e.EscapePressed)
            {
                e.Action = DragAction.Cancel;
                return;
            }

            // Now, default to actually having dropped
            e.Action = DragAction.Drop;

            if ((e.KeyStates & DragDropKeyStates.LeftMouseButton) != DragDropKeyStates.None)
            {
                // Still dragging with Left Mouse Button
                e.Action = DragAction.Continue;
            }
            else if ((e.KeyStates & DragDropKeyStates.RightMouseButton) != DragDropKeyStates.None)
            {
                // Still dragging with Right Mouse Button
                e.Action = DragAction.Continue;
            }
        }

        private void TextBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.Print("TextBox_PreviewMouseLeftButtonDown");
            DragDrop.DoDragDrop((DependencyObject)e.Source,
                                 (sender as TextBox).Text,
                                 DragDropEffects.Move);
        }

        private void TextBox_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.Print("TextBox_PreviewMouseRightButtonDown");

            DragDrop.DoDragDrop((DependencyObject)e.Source,
                                 (sender as TextBox).Text,
                                 DragDropEffects.Move);

            DragDrop.AddQueryContinueDragHandler(this, QueryContinueDragHandler);











            /*Debug.Print("TextBox_PreviewMouseRightButtonDown => Start dragging!");

            Debug.Print(sender.ToString());
            Debug.Print(e.ToString());

            if ((sender as TextBox).Text != "")
            {
                Debug.Print("Jedziemy:");
                Debug.Print((sender as TextBox).Text);

                DataObject data = new DataObject(DataFormats.Text, (sender as TextBox).Text);
                DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
            }*/


            //DataObject data = new DataObject(DataFormats.Text, ((Label)e.Source).Content);

            //DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
        }
    }
}
