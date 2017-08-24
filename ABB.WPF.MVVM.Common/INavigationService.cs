using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB.WPF.MVVM.Common
{
    public interface INavigationService
    {
        bool Navigate<T>(object parameter = null);

        bool Navigate(string page, object parameter = null);

        object Parameter { get;  }
    }
}
