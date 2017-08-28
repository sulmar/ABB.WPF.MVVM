using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB.WPF.MVVM.Models
{
    public class Business : Base
    {
        public int BusinessId { get; set; }

        public string Name { get; set; }


        public override bool Equals(object obj)
        {
            Business business = obj as Business;

            if (business == null) return false;
            
            return this.BusinessId == business.BusinessId;
        }

        public override int GetHashCode() => this.BusinessId.GetHashCode();
    }
}
