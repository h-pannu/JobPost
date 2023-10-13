using JobPost.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace JobPost.Commands
{
    public class AddCommand : ICommand
    {
        private JobListViewModel _jobListViewModel;
        public AddCommand(JobListViewModel jobListViewModel)
        {
            _jobListViewModel = jobListViewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            //throw new NotImplementedException();
            //Do Something
            _jobListViewModel.AddJob();
        }
    }
}
