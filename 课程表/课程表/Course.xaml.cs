﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace TimeTable
{
    public partial class Course : PhoneApplicationPage
    {
        public Course()
        {
            InitializeComponent();
        }

        private void appbar_Add_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddCourse.xaml",UriKind.Relative));
        }
    }
}