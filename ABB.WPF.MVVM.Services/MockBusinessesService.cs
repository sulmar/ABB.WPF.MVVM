using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABB.WPF.MVVM.Models;

namespace ABB.WPF.MVVM.Services
{
    public class MockBusinessesService : IBusinessesService
    {
        public IList<Business> Get()
        {
            var businesses = new List<Business>
            {
                new Business { BusinessId = 1, Name = "A"},
                new Business { BusinessId = 2, Name = "B"},
                new Business { BusinessId = 3, Name = "C"},
            };

            return businesses;
        }
    }


    //public class DbBusinessesService : IBusinessesService
    //{
    //    private AbbContext context;

    //    public DbBusinessesService()
    //    {
    //        context = new AbbContext();
    //    }

    //    public IList<Business> Get()
    //    {
    //        return context.Businesses.OrderBy(b=>b.Name).ToList();
    //    }

    //    public void Add(Business business)
    //    {
    //        context.Businesses.Add(business);

    //        context.SaveChanges();
    //    }
    //}

}
