﻿#pragma checksum "C:\Users\Alex.Zeng\Desktop\124124124124\课程表\课程表\Course.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C05F105C4AC67FF89D69D08FD878B392"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace TimeTable {
    
    
    public partial class Course : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot pivotWeek;
        
        internal System.Windows.Controls.ListBox listboxCourse;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton appbar_Add;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton appbar_Off;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem menuItem1;
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem menuItem2;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/TimeTable;component/Course.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.pivotWeek = ((Microsoft.Phone.Controls.Pivot)(this.FindName("pivotWeek")));
            this.listboxCourse = ((System.Windows.Controls.ListBox)(this.FindName("listboxCourse")));
            this.appbar_Add = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("appbar_Add")));
            this.appbar_Off = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("appbar_Off")));
            this.menuItem1 = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("menuItem1")));
            this.menuItem2 = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("menuItem2")));
        }
    }
}

