﻿#pragma checksum "..\..\..\View\Accueil.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A38D42A88EF072FC85866BF45CF899E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using WpfMusicSchool.MyUserControl;
using WpfMusicSchool.View;


namespace WpfMusicSchool.View {
    
    
    /// <summary>
    /// StudentView
    /// </summary>
    public partial class StudentView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\View\Accueil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button navigationBack;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\View\Accueil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button navigationThrow;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\Accueil.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button navigationframe;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfMusicSchool;component/view/accueil.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Accueil.xaml"
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
            this.navigationBack = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\View\Accueil.xaml"
            this.navigationBack.Click += new System.Windows.RoutedEventHandler(this.navigation_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.navigationThrow = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\View\Accueil.xaml"
            this.navigationThrow.Click += new System.Windows.RoutedEventHandler(this.navigationThrow_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.navigationframe = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\View\Accueil.xaml"
            this.navigationframe.Click += new System.Windows.RoutedEventHandler(this.navigationframe_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

