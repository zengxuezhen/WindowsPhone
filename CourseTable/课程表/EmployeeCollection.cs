﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace TimeTable
{
    //创建页面数据绑定的集合
    //EmployeeCollection用于跟页面的数据绑定
    public class EmployeeCollection : INotifyPropertyChanged
    {
        //定义ObservableCollection来绑定页面的数据，
        //ObservableColloection是一个动态的数据集合，当数据增删改是，提供通知
        private ObservableCollection<CourseTable> employeetables;

        public ObservableCollection<CourseTable> Employeetables
        {
            get { return employeetables; }
            set
            {
                if (employeetables != value)
                {
                    employeetables = value;
                    NotifyPropertyChanged("Employeetables");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}
