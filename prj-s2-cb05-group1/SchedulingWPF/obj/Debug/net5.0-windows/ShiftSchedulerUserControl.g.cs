﻿#pragma checksum "..\..\..\ShiftSchedulerUserControl.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "159007438357B66FA46F8C6A8BB8B55D21665FFB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SchedulingWPF;
using SchedulingWPF.Logic;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace SchedulingWPF {
    
    
    /// <summary>
    /// ShiftSchedulerUserControl
    /// </summary>
    public partial class ShiftSchedulerUserControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\ShiftSchedulerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\ShiftSchedulerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SchedulingWPF.Logic.ListBoxExtend lbEmployees;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\ShiftSchedulerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContextMenu ContextMenuLbEmployees;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ShiftSchedulerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblWeekNumber;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\ShiftSchedulerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnWeekBack;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\ShiftSchedulerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnWeekForward;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\ShiftSchedulerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAccept;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\ShiftSchedulerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnReject;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\ShiftSchedulerUserControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar WeekCalendar;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.15.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SchedulingWPF;component/shiftschedulerusercontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ShiftSchedulerUserControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.15.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.15.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.lbEmployees = ((SchedulingWPF.Logic.ListBoxExtend)(target));
            return;
            case 3:
            this.ContextMenuLbEmployees = ((System.Windows.Controls.ContextMenu)(target));
            return;
            case 4:
            this.lblWeekNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.btnWeekBack = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\ShiftSchedulerUserControl.xaml"
            this.btnWeekBack.Click += new System.Windows.RoutedEventHandler(this.btnWeekBack_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnWeekForward = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\ShiftSchedulerUserControl.xaml"
            this.btnWeekForward.Click += new System.Windows.RoutedEventHandler(this.btnWeekForward_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnAccept = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\ShiftSchedulerUserControl.xaml"
            this.btnAccept.Click += new System.Windows.RoutedEventHandler(this.btnAccept_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnReject = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\ShiftSchedulerUserControl.xaml"
            this.btnReject.Click += new System.Windows.RoutedEventHandler(this.btnReject_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.WeekCalendar = ((System.Windows.Controls.Calendar)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

