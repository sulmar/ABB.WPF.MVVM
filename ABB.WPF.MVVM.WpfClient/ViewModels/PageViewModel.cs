using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABB.WPF.MVVM.Common;
using ABB.WPF.MVVM.Services;
using ABB.WPF.MVVM.Models;

namespace ABB.WPF.MVVM.WpfClient.ViewModels
{
    public class PageViewModel : ViewModelBase
    {
        public PageContent PageContent { get; set; }

        private readonly IPageContentService pageContentService;

        public PageViewModel(INavigationService navigationService, IPageContentService pageContentService) 
            : base(navigationService)
        {
            this.pageContentService = pageContentService;

            Load();
        }

        private void Load()
        {
            MenuItem menuItem = (MenuItem)navigationService.Parameter;

            PageContent = pageContentService.Get(menuItem.Name);

            // Podpinamy notyfikację do wszystkich elementów
            Subscribe();
        }

        private void Subscribe()
        {
            foreach (var pageItem in PageContent.Items)
            {
                pageItem.PropertyChanged += PageItem_PropertyChanged;
            }
        }

        private void PageItem_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName ==  "Value")
            {
                // TODO: recalculate or save
            }
        }
    }
}
