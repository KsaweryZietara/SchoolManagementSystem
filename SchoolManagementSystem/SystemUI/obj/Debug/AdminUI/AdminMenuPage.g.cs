﻿#pragma checksum "..\..\..\AdminUI\AdminMenuPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "25060E0CDE809C5E50B20F3374AE6C733C4BB3506D094199310C792971FB7DA2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

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
using SystemUI;


namespace SystemUI.AdminUI {
    
    
    /// <summary>
    /// AdminMenuPage
    /// </summary>
    public partial class AdminMenuPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\AdminUI\AdminMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddStudentButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\AdminUI\AdminMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddTeacherButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\AdminUI\AdminMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddAdminButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\AdminUI\AdminMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewCourseButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\AdminUI\AdminMenuPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame AdminMenuOptions;
        
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
            System.Uri resourceLocater = new System.Uri("/SystemUI;component/adminui/adminmenupage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AdminUI\AdminMenuPage.xaml"
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
            this.AddStudentButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\AdminUI\AdminMenuPage.xaml"
            this.AddStudentButton.Click += new System.Windows.RoutedEventHandler(this.AddStudentButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddTeacherButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\AdminUI\AdminMenuPage.xaml"
            this.AddTeacherButton.Click += new System.Windows.RoutedEventHandler(this.AddTeacherButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddAdminButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\AdminUI\AdminMenuPage.xaml"
            this.AddAdminButton.Click += new System.Windows.RoutedEventHandler(this.AddAdminButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.NewCourseButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\AdminUI\AdminMenuPage.xaml"
            this.NewCourseButton.Click += new System.Windows.RoutedEventHandler(this.NewCourseButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AdminMenuOptions = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

