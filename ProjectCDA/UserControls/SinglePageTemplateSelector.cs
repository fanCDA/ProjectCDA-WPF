using ProjectCDA.Model;
using System.Windows;
using System.Windows.Controls;

namespace ProjectCDA.UserControls
{
    class SinglePageTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            SinglePage singlePage = item as SinglePage;
            FrameworkElement element = container as FrameworkElement;

            if (singlePage == null || element == null)
                return null;

            return element.FindResource("SinglePageTemplateDefault") as DataTemplate;
        }
    }
}
