using System;
using System.Windows.Input;

namespace MVVMSample
{
    public class Command : ICommand
    {
        private Action _exec;
        private Func<bool> _canExec;

        public Command(Action exec, Func<bool> canExec)
        {
            _exec = exec;
            _canExec = canExec;
        }

        public void Execute(object parameter)
        {
            _exec();
        }

        public bool CanExecute(object parameter)
        {
            return _canExec();
        }

        public event EventHandler CanExecuteChanged;
    }
}
