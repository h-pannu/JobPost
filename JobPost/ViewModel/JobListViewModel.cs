using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using JobPost.Models;

namespace JobPost.ViewModel
{
    public class JobListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public JobListViewModel()
        {

        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Job _job;

        public Job Job
        {
            get { return _job; }
            set { _job = value; OnPropertyChanged(nameof(Job)); }
        }


    }
}
