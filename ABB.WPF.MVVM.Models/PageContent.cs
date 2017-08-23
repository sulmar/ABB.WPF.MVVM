using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB.WPF.MVVM.Models
{
    public class PageContent : Base
    {
        public IList<PageItem> Items { get; set; }
    }


    public class PageItem : Base
    {
        public int PageItemId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Parameters { get; set; }


    }
}
