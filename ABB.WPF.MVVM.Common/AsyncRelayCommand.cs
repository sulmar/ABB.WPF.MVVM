using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ABB.WPF.MVVM.Common
{
    // Inspired by Stephen Cleary 
    // Async Programming : Patterns for Asynchronous MVVM Applications: Commands
    // https://msdn.microsoft.com/en-us/magazine/dn630647.aspx

    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync(object parameter);
    }


    public class AsyncRelayCommand : IAsyncCommand
    {
        private Func<Task> execute;
        private Predicate<object> canExecute;

        public AsyncRelayCommand(Func<Task> execute, Predicate<object> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public Task ExecuteAsync(object parameter = null) => execute();

        public bool CanExecute(object parameter) => canExecute == null || canExecute(parameter);

        public async void Execute(object parameter = null) => await ExecuteAsync(parameter);

    }

    public class AsyncRelayCommand<T> : IAsyncCommand
    {
        private Func<T, Task> execute;
        private Predicate<T> canExecute;

        public AsyncRelayCommand(Func<T, Task> execute, Predicate<T> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public Task ExecuteAsync(object parameter = null) => execute((T)parameter);

        public bool CanExecute(object parameter) => canExecute == null || canExecute((T)parameter);

        public async void Execute(object parameter = null) => await ExecuteAsync(parameter);

    }
}
