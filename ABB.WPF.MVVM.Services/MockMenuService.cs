using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABB.WPF.MVVM.Models;
using System.Threading;

namespace ABB.WPF.MVVM.Services
{
    public class MockMenuService : IMenuService
    {
        public IList<MenuItem> Get()
        {
            var menuitems = new List<MenuItem>
            {
                new MenuItem
                {
                    MenuItemId = 1,
                    Name = "OMS",
                    Caption = "OMS",
                    Businesses = new List<Business>
                    {
                        new Business { BusinessId = 1, Name ="A" },
                        new Business { BusinessId = 2, Name ="B"  }
                    }
                },

                new MenuItem
                {
                    MenuItemId = 2,
                    Name = "GMS",
                    Caption = "GMS",
                    Businesses = new List<Business>
                    {
                        new Business { BusinessId = 2, Name ="B" }
                    }
                },

                new MenuItem
                {
                    MenuItemId = 3,
                    Name = "EMS",
                    Caption = "EMS",
                    Businesses = new List<Business>
                    {
                        new Business { BusinessId = 1, Name = "A" },
                        new Business { BusinessId = 3, Name = "C" },
                    }
                },

            };


          

            return menuitems;
        }
    }

}

