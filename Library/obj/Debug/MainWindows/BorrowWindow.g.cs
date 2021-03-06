﻿#pragma checksum "..\..\..\MainWindows\BorrowWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B6C310F6DCF676B77D3EF2CAF56E98DE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace Library.MainWindows {
    
    
    /// <summary>
    /// BorrowWindow
    /// </summary>
    public partial class BorrowWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\MainWindows\BorrowWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar toolBar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MainWindows\BorrowWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addOrderButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MainWindows\BorrowWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteReaderButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\MainWindows\BorrowWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button returnButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindows\BorrowWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deptorsButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\MainWindows\BorrowWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid borrowTable;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library;component/mainwindows/borrowwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindows\BorrowWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 15 "..\..\..\MainWindows\BorrowWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.deleteCommand_CanExecute);
            
            #line default
            #line hidden
            
            #line 15 "..\..\..\MainWindows\BorrowWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.deleteCommand_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 16 "..\..\..\MainWindows\BorrowWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.markCommand_CanExecute);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\MainWindows\BorrowWindow.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.markCommand_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.toolBar = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 4:
            this.addOrderButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\MainWindows\BorrowWindow.xaml"
            this.addOrderButton.Click += new System.Windows.RoutedEventHandler(this.addOrderButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.deleteReaderButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.returnButton = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.deptorsButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\MainWindows\BorrowWindow.xaml"
            this.deptorsButton.Click += new System.Windows.RoutedEventHandler(this.deptorsButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.borrowTable = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

