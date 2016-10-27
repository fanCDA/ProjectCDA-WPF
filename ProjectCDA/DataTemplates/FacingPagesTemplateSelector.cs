using ProjectCDA.Model;
using ProjectCDA.Model.Constants;
using System.Windows;
using System.Windows.Controls;

namespace ProjectCDA.DataTemplates
{
    class FacingPagesTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FacingPages facingPages = item as FacingPages;
            FrameworkElement element = container as FrameworkElement;

            if (facingPages == null || element == null)
                return null;

            switch (facingPages.Type)
            {
                case FacingPagesTypes.DEFAULT:
                    // We have numbers on top and header.
                    // Assuming we have both left and right single pages.
                    return element.FindResource("FacingPagesTemplateDefault") as DataTemplate;

                case FacingPagesTypes.NO_HEADER:
                    // We have just the numbers on top.
                    // Assuming we have both left and right single pages.
                    return element.FindResource("FacingPagesTemplateNoHeader") as DataTemplate;

                case FacingPagesTypes.SINGLE_PAGE:
                    // We have numbers on top and header.
                    // Assuming we have both left and right single pages.
                    return element.FindResource("FacingPagesTemplateJustLeftPage") as DataTemplate;

                default:
                    // In case we have Type not handled above use default one...
                    return element.FindResource("FacingPagesTemplateDefault") as DataTemplate;
            }
        }
    }
}
