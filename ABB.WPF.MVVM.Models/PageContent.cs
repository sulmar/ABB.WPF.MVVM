using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB.WPF.MVVM.Models
{
    public class PageContent : Base
    {
        public IList<PageItem> Items { get; set; } = new List<PageItem>();

    }
}
