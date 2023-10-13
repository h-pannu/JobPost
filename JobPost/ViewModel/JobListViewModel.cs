using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using JobPost.Models;
using JobPost.Commands;
using System.Collections.ObjectModel;

namespace JobPost.ViewModel
{
    public class JobListViewModel : ChangeNotifier
    {
        public JobListViewModel()
        {
            Jobs = new ObservableCollection<Job>();
        }

        private Job _job;

        public Job TargetJob
        {
            get { return _job; }
            set { _job = value; OnPropertyChanged(nameof(TargetJob)); }
        }

        public ICommand CMDAdd => new RelayCommand(AddJob, null);

        private ObservableCollection<Job> _jobs;

        public ObservableCollection<Job> Jobs
        {
            get { return _jobs; }
            set { _jobs = value; }
        }


        public void AddJob(object person)
        {
            Jobs.Add(TargetJob);  //Add it to collection
            TargetJob = new Job(); //Resetting it
        }
    }
}
