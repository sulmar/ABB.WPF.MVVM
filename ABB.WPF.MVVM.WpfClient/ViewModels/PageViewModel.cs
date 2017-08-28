using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABB.WPF.MVVM.Common;
using ABB.WPF.MVVM.Services;
using ABB.WPF.MVVM.Models;
using System.Windows.Input;

namespace ABB.WPF.MVVM.WpfClient.ViewModels
{
    public class PageViewModel : ViewModelBase
    {
        private PageContent _PageContent;
        public PageContent PageContent
        {
            get
            {
                return _PageContent;
            }

            set
            {
                _PageContent = value;
                OnPropertyChanged();
            }
        }

        private readonly IPageContentService pageContentService;

        public PageViewModel(INavigationService navigationService, IPageContentService pageContentService) 
            : base(navigationService)
        {
            this.pageContentService = pageContentService;

           // Load();
        }


        #region LoadCommand

        private ICommand _LoadCommand;
        public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                {
                    _LoadCommand = new RelayCommand(p => Load());
                }

                return _LoadCommand;
            }
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

                // valuesService.Update(value)
            }
        }

        #endregion
    }
}
