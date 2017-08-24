using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ABB.WPF.MVVM.Common
{
    public class NavigationService : INavigationService
    {
        public Frame frame { get; set; }

        public NavigationService(Frame frame = null)
        {
            this.frame = frame;
        }

        public object Parameter { get; private set; }


        // Navigate<PageView>()

        public bool Navigate<T>(object parameter = null)
        {
            return Navigate(typeof(T), parameter);
        }

        private bool Navigate(Type source, object parameter = null)
        {
            // Zapamiętujemy przekazany parametr
            Parameter = parameter;

            // new w runtime'ie
            var src = Activator.CreateInstance(source);

            // Przechodzimy do okna
            return frame.Navigate(src, parameter);

        }

        public bool Navigate(string page, object parameter = null)
        {
            // Szukamy typu w naszej aplikacji na podstawie nazwy
            var type = Assembly.GetEntryAssembly()
                .GetTypes()
                .SingleOrDefault(a => a.Name.Equals(page));

            if (type == null) return false;

            return Navigate(type, parameter);

        }
    }
}
