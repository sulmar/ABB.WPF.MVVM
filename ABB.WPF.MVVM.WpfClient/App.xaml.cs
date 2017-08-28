using ABB.WPF.MVVM.Common;
using ABB.WPF.MVVM.Models;
using ABB.WPF.MVVM.WpfClient.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ABB.WPF.MVVM.WpfClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static NavigationService NavigationService;

        public static AppContext AppContext { get; set; }


        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            NavigationService = new NavigationService();
            AppContext = new AppContext();

            // odpowiednik StartupUri w XAML
            ShellView shellView = new ShellView();
            shellView.Show();

            // Tworzymy instancję NavigationService i przekazujemy referencję do naszego Frame
            //NavigationService = new NavigationService(shellView.ShellFrame);

            NavigationService.frame = shellView.ShellFrame;

            NavigationService.Navigate<StartView>();


        }
    }


}
