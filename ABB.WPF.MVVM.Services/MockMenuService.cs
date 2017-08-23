using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABB.WPF.MVVM.Models;

namespace ABB.WPF.MVVM.Services
{
    public class MockMenuService : IMenuService
    {
        public Menu Get()
        {
            var menu = new Menu
            {
                MenuItems = new List<MenuItem>
                {
                    new MenuItem
                    {
                        MenuItemId = 1,
                        Name = "OMS",
                        Caption = "OMS"
                    },

                    new MenuItem
                    {
                        MenuItemId = 2,
                        Name = "GMS",
                        Caption = "GMS"
                    },

                    new MenuItem
                    {
                        MenuItemId = 3,
                        Name = "EMS",
                        Caption = "EMS"
                    },

                }
            };

            return menu;
        }
    }
}
