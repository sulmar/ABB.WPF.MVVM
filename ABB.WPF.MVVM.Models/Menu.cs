using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB.WPF.MVVM.Models
{
    public class Menu : Base
    {

        private IList<MenuItem> _MenuItems;
    
        public IList<MenuItem> MenuItems
        {
            get
            {
                return _MenuItems;
            }
            set
            {
                _MenuItems = value;
                 OnPropertyChanged();
            }
        }

      
    }
}
