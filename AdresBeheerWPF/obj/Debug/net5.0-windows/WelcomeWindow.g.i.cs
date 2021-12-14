﻿#pragma checksum "..\..\..\WelcomeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8EDA8D4AC9EB9AFCFA72E8BB770F7C960D026689"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AdresBeheerWPF;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace AdresBeheerWPF {
    
    
    /// <summary>
    /// WelcomeWindow
    /// </summary>
    public partial class WelcomeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\WelcomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Adressen;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\WelcomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Straten;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\WelcomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Gemeenten;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\WelcomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Adreslocatie;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AdresBeheerWPF;V1.0.0.0;component/welcomewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WelcomeWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Adressen = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\WelcomeWindow.xaml"
            this.Adressen.Click += new System.Windows.RoutedEventHandler(this.NaarAdres_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Straten = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\WelcomeWindow.xaml"
            this.Straten.Click += new System.Windows.RoutedEventHandler(this.NaarStraat_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Gemeenten = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\WelcomeWindow.xaml"
            this.Gemeenten.Click += new System.Windows.RoutedEventHandler(this.NaarGemeente_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Adreslocatie = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\WelcomeWindow.xaml"
            this.Adreslocatie.Click += new System.Windows.RoutedEventHandler(this.NaarLocatie_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

