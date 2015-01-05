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
using System.Data.Linq.Mapping;
using System.ComponentModel;
namespace TimeTable
{
    //该类实现 INotifyPropertyChanged, INotifyPropertyChanging两个接口，监听类中的属性是否发生改变
    [Table]
    public class CourseTable : INotifyPropertyChanged,INotifyPropertyChanging
    {

      

        //建字段id，设置为主键，IsDbGenerated(自动增长)
        private int id;
        [Column(CanBeNull = false, IsDbGenerated = true, IsPrimaryKey = true, AutoSync = AutoSync.OnInsert, DbType = "INT NOT NULL Identity")]

        public int Id
        {
            get { return id; }
            set {
                if (id!=value)
                {
                    NotifyPropertyChanging("Id");
                    id = value;
                    NotifyPropertyChanged("Id");
                }
              }
        }
        private string coursename;//课程名
        [Column]
        public string Coursename
        {
            get { return coursename; }
            set {
                if (coursename!=value)
                {
                    NotifyPropertyChanging("Coursename");
                    coursename = value;
                    NotifyPropertyChanged("Coursename");
                }
                }
        }
        private DateTime coursetime;//时间
        [Column]
        public DateTime Coursetime
        {
            get { return coursetime; }
            set
            {
                if (coursetime!=value)
                {
                    NotifyPropertyChanging("Coursetime");
                    coursetime = value;
                NotifyPropertyChanged("Coursetime");
                }
            }
        }
        private string courseroom;//教室
        [Column]
        public string Courseroom
        {
            get { return courseroom; }
            set
            {
                if (courseroom != value)
                {
                    NotifyPropertyChanging("Courseroom");
                    courseroom = value;
                    NotifyPropertyChanged("Courseroom");
                }
            }
        }
        private string courseweek;//星期
        [Column]
        public string Courseweek
        {
            get { return courseweek; }
            set
            {
                if (courseweek != value)
                {
                    NotifyPropertyChanging("Courseweek");
                    courseweek = value;
                    NotifyPropertyChanged("Courseweek");
                }
               
            }
        }
        private int coursecount;//节数
        [Column]
        public int Coursecount
        {
            get { return coursecount; }
            set
            {
                if (coursecount != value)
                {
                    NotifyPropertyChanging("Coursecount");
                    coursecount = value;
                    NotifyPropertyChanged("Coursecount");
                }
                 else
                {
                    coursecount = 1;
                    NotifyPropertyChanged("Coursecount");

                }
            }
        }
        //必须为PropertyChanged和PropertyChanging
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;
        //通知数据上下文表的字段发生了改变
        public void NotifyPropertyChanged(string propertyName) {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        //通知数据上下文表的字段将发生了改变
        public void NotifyPropertyChanging(string propertyName) {
            if (PropertyChanging!= null)
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }
    }
}
