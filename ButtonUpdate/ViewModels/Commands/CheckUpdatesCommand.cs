using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ButtonUpdate.ViewModels.Commands
{
    public class CheckUpdatesCommand : ICommand
    {
        public ViewModelBase ViewModel { get; set; }

        public CheckUpdatesCommand(ViewModelBase viewModelBase)
        {
            this.ViewModel = viewModelBase;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ViewModel.CheckUpdatesAfterClick();
        }
    }
}
