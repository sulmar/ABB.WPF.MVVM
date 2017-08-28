using ABB.WPF.MVVM.Common;
using ABB.WPF.MVVM.Models;
using ABB.WPF.MVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ABB.WPF.MVVM.WpfClient.ViewModels
{
    public class MenuViewModel : ViewModelBase
    {
        public Menu Menu { get; set; }


        private string _Message;

        public string Message
        {
            get { return _Message; }
            set { _Message = value; OnPropertyChanged(); }
        }


        private IMenuService menuService;

        public MenuViewModel() : this(new MockMenuService())
        { }


        public MenuViewModel(IMenuService menuService)
        {
            this.menuService = menuService;

            Load();
        }

        public void Load()
        {
            // Menu = menuService.Get();

        }

        #region PrintCommand

        private ICommand _PrintCommand;

        public ICommand PrintCommand
        {
            get
            {
                if (_PrintCommand == null)
                {
                    _PrintCommand = new RelayCommand(p => Print(), p => CanPrint());
                }

                return _PrintCommand;
            }
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public bool CanPrint()
        {
            return !string.IsNullOrEmpty(Message);
        }

        #endregion


        #region SendCommand

        private ICommand _SendCommand;

        public ICommand SendCommand
        {

            get
            {
                if (_SendCommand == null)
                {
                    _SendCommand = new RelayCommand(p => Send());
                }

                return _SendCommand;
            }
        }

        public void Send()
        {
            throw new NotImplementedException();
        }

 


        #endregion

    }
}
