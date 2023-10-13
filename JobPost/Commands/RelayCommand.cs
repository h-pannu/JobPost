using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JobPost.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<object> _executeAction;
        private Func<object, bool> _canExecuteActions;

        public bool CanExecute(object? parameter)
        {
            if (_canExecuteActions == null) return true;
            return _canExecuteActions.Invoke(parameter);
        }

        public void Execute(object? parameter)
        {
            _executeAction?.Invoke(parameter);
        }

        public RelayCommand(Action<object> executeAction, Func<object, bool> canExecuteActions)
        {
            _canExecuteActions = canExecuteActions;
            _executeAction = executeAction;
        }
    }
}
