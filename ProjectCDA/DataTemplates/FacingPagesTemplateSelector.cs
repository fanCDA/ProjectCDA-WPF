using ProjectCDA.Model;
using System.Windows;
using System.Windows.Controls;

namespace ProjectCDA.DataTemplates
{
    class FacingPagesTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FacingPages twoPages = item as FacingPages;
            FrameworkElement element = container as FrameworkElement;

            if (twoPages == null || element == null)
                return null;

            if(twoPages.hasNumbers)
            {
                if(twoPages.hasHeaderField)
                {
                    // We have numbers on top and header.
                    // Assuming we have both left and right single pages.
                    return element.FindResource("FacingPagesTemplateDefault") as DataTemplate;
                }
                else
                {
                    // We have just the numbers on top.
                    // Assuming we have both left and right single pages.
                    return element.FindResource("FacingPagesTemplateNoHeader") as DataTemplate;
                }
            }
            else
            {
                // No numbers on top and no header.
                // Assuming we have just left page.
                return element.FindResource("FacingPagesTemplateJustLeftPage") as DataTemplate;
            }
        }
    }
}
