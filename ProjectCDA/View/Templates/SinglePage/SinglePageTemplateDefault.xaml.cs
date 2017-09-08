using System;
using System.Windows;
using System.Windows.Controls;

namespace ProjectCDA.View.Templates.SinglePage
{
    public partial class SinglePageTemplateDefault : UserControl
    {
        public SinglePageTemplateDefault()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewMouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                var dataObj = new DataObject(textBox.Text);
                dataObj.SetData("DragSource", e.Source);
                DragDrop.DoDragDrop(e.Source as DependencyObject, dataObj, DragDropEffects.Move);
                e.Handled = true;
            }
        }

        private void TextBox_PreviewQueryContinueDrag(object source, System.Windows.QueryContinueDragEventArgs e)
        {
            TextBox textBox = source as TextBox;

            e.Handled = true;

            if (e.EscapePressed)
            {
                e.Action = DragAction.Cancel;
                return;
            }

            if ((e.KeyStates & DragDropKeyStates.LeftMouseButton) != DragDropKeyStates.None)
            {
                e.Action = DragAction.Continue;
                return;
            }

            if ((e.KeyStates & DragDropKeyStates.RightMouseButton) != DragDropKeyStates.None)
            {
                e.Action = DragAction.Continue;
                return;
            }

            e.Action = DragAction.Drop;
            e.Handled = false;
        }

        private void Tf1_PreviewDrop(object sender, DragEventArgs e)
        {
            // `sender` is a sender of the event, so it's destination TextBox
            // `dragSource` is where DragEvent started
            var dragSource = e.Data.GetData("DragSource");
            
            if(dragSource!= null)
            {
                var data = e.Data.GetData(DataFormats.Text);

                (dragSource as TextBox).Text = (sender as TextBox).Text;
                (sender as TextBox).Text = String.Empty;
            }
        }
    }
}
