﻿using JobPost.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JobPost.Views
{
    /// <summary>
    /// Interaction logic for JobList.xaml
    /// </summary>
    public partial class JobList : Window
    {
        public JobList()
        {
            InitializeComponent();
            DataContext = new JobListViewModel(); //Connecting View with ViewModel
        }
    }
}
