using ABB.WPF.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ABB.WPF.MVVM.WpfClient
{
    public class PageItemDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var pageItem = (PageItem)item;

            var resourceName = $"{pageItem.Type}Template";

            // Ładowanie zasobu z kodu
            DataTemplate dataTemplate = Application.Current.FindResource(resourceName) as DataTemplate;

            return dataTemplate;
        }
    }
}
