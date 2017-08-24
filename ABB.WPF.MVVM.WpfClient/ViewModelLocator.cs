using ABB.WPF.MVVM.Services;
using ABB.WPF.MVVM.WpfClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB.WPF.MVVM.WpfClient
{
    public class ViewModelLocator
    {
        public ShellViewModel ShellViewModel => new ShellViewModel(App.NavigationService, new MockMenuService());
        public PageViewModel PageViewModel => new PageViewModel(App.NavigationService, new FilePageContentService());
    }
}
