using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using JobPost.Models;
//using JobPost.Commands;
using System.Collections.ObjectModel;
using Haley.Models;
using Haley.Abstractions;
using Haley.MVVM;

namespace JobPost.ViewModel
{
    public class JobListViewModel : ChangeNotifier
    {
        public JobListViewModel()
        {
            Jobs = new ObservableCollection<Job>();
            TargetJob = new Job();
        }

        private Job _job;

        public Job TargetJob
        {
            get { return _job; }
            set { _job = value; OnPropertyChanged(nameof(TargetJob)); }
        }

        public ICommand CMDAdd => new DelegateCommand(AddJob);
        public ICommand CMDDelete => new DelegateCommand<Job>(DeleteJob);

        private ObservableCollection<Job> _jobs;

        public ObservableCollection<Job> Jobs
        {
            get { return _jobs; }
            set { _jobs = value; }
        }


        public void AddJob()
        {
            Jobs.Add(TargetJob);  //Add it to collection
            TargetJob = new Job(); //Resetting it
        }

        public void DeleteJob(Job obj)
        {
            if (obj == null) return;
            if(!Jobs.Contains(obj)) return;

            Jobs.Remove(obj);  //remove it from collection
        }
    }
}
