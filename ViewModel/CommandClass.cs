using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FirstMainWindow.ViewModel
{
    public class CommandClass : ICommand
    {
        Action<object> execute;
        Func<object, bool> canExecute;

        public CommandClass(Action<object> execute) : this(execute, null)
        {
            this.execute = execute;
        }

        public CommandClass(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
    remove { CommandManager.RequerySuggested -= value; }
        }


        public bool CanExecute(object parameter)
        {
            //return true;
            if (canExecute != null)
            {
                return canExecute(parameter);
            }
            throw new Exception("from canExecute metod in CommandClass");
        }

        public void Execute(object parameter)
        {

            execute(parameter);

        }
    }
}
