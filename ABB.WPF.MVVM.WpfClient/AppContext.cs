using ABB.WPF.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB.WPF.MVVM.WpfClient
{
    public class AppContext : Base
    {
        public AppContext()
        {
            Menu = new Menu();
        }

        private Business _SelectedBusiness;
        public Business SelectedBusiness
        {
            get
            {
                return _SelectedBusiness;
            }

            set
            {
                _SelectedBusiness = value;

                OnSelectedBusiness(_SelectedBusiness);
            }
        }

        public Menu Menu { get; set; }


        public Action<Business> OnSelectedBusiness;


    }
}
