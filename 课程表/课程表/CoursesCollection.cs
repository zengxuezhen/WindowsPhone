using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;
namespace TimeTable
{
    public class CoursesCollection:INotifyPropertyChanged
    {
        private ObservableCollection<CourseTable> coursetables;

        public ObservableCollection<CourseTable> Coursetables
        {
            get { return coursetables; }
            set {
                if (coursetables!=value)
                {
                    coursetables = value;
                    NotifyPropertyChanged("");
                }
               }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
            }
        }
    }
  

}
