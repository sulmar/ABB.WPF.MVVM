using ABB.WPF.MVVM.Common;
using ABB.WPF.MVVM.Models;
using ABB.WPF.MVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB.WPF.MVVM.WpfClient.ViewModels
{
    public class StartViewModel : ViewModelBase
    {
        public IList<Business> Businesses { get; set; }

        public AppContext AppContext => App.AppContext;


        private readonly IBusinessesService businessesService;

        public StartViewModel(INavigationService navigationService, IBusinessesService businessesService)
            : base(navigationService)
        {
            this.businessesService = businessesService;

            Load();
        }

        private void Load()
        {
            Businesses = businessesService.Get();

            AppContext.SelectedBusiness = Businesses.FirstOrDefault();
        }



        private void LoadMenu()
        {
        }
    }
}
