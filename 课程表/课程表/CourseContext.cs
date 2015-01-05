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
using System.Data.Linq;

namespace TimeTable
{
    public class CourseContext:DataContext
    {
        //连接字符串，必须设置明确的格式isostore:/
        public static string Connectionstr = "Data Source=isostore:/Course.sdf";
        //传递连接字符串到Context基类
        public CourseContext(string connectionstring) : base(connectionstring) {  }
        //定义一个在数据库中的表
        public Table<CourseTable> course;
    }
}
