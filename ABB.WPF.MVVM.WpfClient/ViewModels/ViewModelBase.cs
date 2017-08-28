using ABB.WPF.MVVM.Common;
using ABB.WPF.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB.WPF.MVVM.WpfClient.ViewModels
{
    public abstract class ViewModelBase : Base
    {
        protected readonly INavigationService navigationService;

        public ViewModelBase(INavigationService navigationService = null)
        {
            this.navigationService = navigationService;

        }
    }
}
