using JobPost.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Haley.MVVM;
using Haley.Abstractions;
using Haley.Models;

namespace JobPost.Models
{
    public class Job : ChangeNotifier
    {
		public Job()
		{

		}

		private string _title;

		public string Title
		{
			get { return _title; }
			set { _title = value; OnPropertyChanged(nameof(Title)); }
		}

		private string _description;

		public string Description
		{
			get { return _description; }
			set { _description = value; OnPropertyChanged(nameof(Description)); }
		}

		private string _skillsReq;

		public string SkillsReq
		{
			get { return _skillsReq; }
			set { _skillsReq = value; OnPropertyChanged(nameof(SkillsReq)); }
		}

		private int _minExp;

		public int MinExp
		{
			get { return _minExp; }
			set { _minExp = value; OnPropertyChanged(nameof(MinExp)); }
		}


	}
}
