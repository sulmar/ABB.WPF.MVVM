using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB.WPF.MVVM.Models
{
    public class Menu : Base
    {
        public IList<MenuItem> MenuItems { get; set; }
    }
}
