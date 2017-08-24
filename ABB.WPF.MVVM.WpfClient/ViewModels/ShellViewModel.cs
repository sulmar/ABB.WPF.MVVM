using ABB.WPF.MVVM.Common;
using ABB.WPF.MVVM.Models;
using ABB.WPF.MVVM.Services;
using ABB.WPF.MVVM.WpfClient.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ABB.WPF.MVVM.WpfClient.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        public Menu Menu { get; set; }

        private readonly IMenuService menuService;

        public ShellViewModel(INavigationService navigationService, IMenuService menuService)
            : base(navigationService)
        {
            this.menuService = menuService;

            Load();
        }


        public void Load()
        {
            Menu = menuService.Get();

            Menu.MenuItems = Menu.MenuItems
                .Union(Get()).OrderBy(item=>item.MenuItemId)
                .ToList();

        }

        private IList<MenuItem> Get()
        {
            var items = new List<MenuItem>
            {
                new MenuItem { MenuItemId = 99, Name = "Help", Caption = "Help", MenuItemType = MenuItemType.Static },
                new MenuItem { MenuItemId = 0, Name = "Start", Caption = "Start", MenuItemType = MenuItemType.Static },
            };

            return items;
        }


        #region SelectItemCommand

        private ICommand _SelectItemCommand;
        public ICommand SelectItemCommand
        {
            get
            {
                if (_SelectItemCommand == null)
                {
                    _SelectItemCommand = new RelayCommand<MenuItem>(p => SelectItem(p)); 
                }

                return _SelectItemCommand;
            }
        }

        private void SelectItem(MenuItem item)
        {
            switch (item.MenuItemType)
            {
                case MenuItemType.Dynamic: SelectDynamicItem(item); break;
                case MenuItemType.Static: SelectStaticItem(item); break;
            }
        }

        private void SelectDynamicItem(MenuItem item)
        {
            navigationService.Navigate<PageView>(item);
            
        }

        private void SelectStaticItem(MenuItem item)
        {
            navigationService.Navigate(item.Name + "View", item);
        }


        #endregion
    }
}
