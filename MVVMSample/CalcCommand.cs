using System;
using System.Windows.Input;

namespace MVVMSample
{
    public class CalcCommand : ICommand
    {
        private Action _exec;
        private Func<bool> _canExec;

        public CalcCommand(Action exec, Func<bool> canExec)
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
