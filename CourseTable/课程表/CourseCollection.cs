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
    //创建页面数据绑定的集合
    public class CourseCollection:INotifyPropertyChanged
    {
        //创建一个动态数据集合，当数据发生改变时，提供通知
        private ObservableCollection<CourseTable> coursetables=new ObservableCollection<CourseTable>();

        public ObservableCollection<CourseTable> Coursetables
        {
            get { return coursetables; }
            set
            {
                if (coursetables != value)
                {
                    coursetables = value;
                    NotifyPropertyChanged("Coursetables");
                }
            }
        }
        
        //实现接口
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
