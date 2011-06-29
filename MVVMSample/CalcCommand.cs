using System;
using System.Windows.Input;

namespace MVVMSample
{
    public class CalcCommand : ICommand
    {
        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public event EventHandler CanExecuteChanged;
    }
}
