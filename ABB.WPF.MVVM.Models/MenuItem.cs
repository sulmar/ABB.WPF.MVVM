using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB.WPF.MVVM.Models
{
    public class MenuItem : Base
    {
        public int MenuItemId { get; set; }

        public string Name { get; set; }

        public string Caption { get; set; }


        public override string ToString()
        {
            return Caption;
        }


    }
}
