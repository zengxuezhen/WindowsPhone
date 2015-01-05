using System;
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
using System.Data.Linq;

namespace TimeTable
{
    public partial class AddCourse : PhoneApplicationPage
    {
        private CourseContext CourseDB;
       private CourseCollection CourseCol = new CourseCollection();
  
      
        public AddCourse()
        {
            InitializeComponent();
            CourseDB = new CourseContext(CourseContext.Connectionstr);
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //增加一条数据
            CourseTable ct = new CourseTable() { Coursename = txtName.Text, Coursecount = Convert.ToInt32(txtCount.Text), 
                Courseroom = txtRoom.Text, Courseweek = txtWeek.Text, Coursetime = (DateTime)txtTime.Value };
            //添加到集合中
            CourseCol.Coursetables.Add(ct);
          
           
            //准备添加到数据库中
            CourseDB.course.InsertOnSubmit(ct);
            //确实数据库的修改
            CourseDB.SubmitChanges();
            NavigationService.Navigate(new Uri("/Course.xaml", UriKind.Relative));
        }
    }
}
