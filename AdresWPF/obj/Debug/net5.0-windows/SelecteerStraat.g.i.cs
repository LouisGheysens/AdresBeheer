﻿#pragma checksum "..\..\..\SelecteerStraat.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CC6BB29C98F06FEEB748A96675ECF4672A4AC391"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AdresWPF;
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


namespace AdresWPF {
    
    
    /// <summary>
    /// BestaatElement
    /// </summary>
    public partial class BestaatElement : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\SelecteerStraat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GaNaarHome;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\SelecteerStraat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelGemeenteN;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\SelecteerStraat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelGemeenteCode;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\SelecteerStraat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxNiscode;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\SelecteerStraat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox1Gemeentenaam;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\SelecteerStraat.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/AdresWPF;V1.0.0.0;component/selecteerstraat.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SelecteerStraat.xaml"
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
            this.GaNaarHome = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\SelecteerStraat.xaml"
            this.GaNaarHome.Click += new System.Windows.RoutedEventHandler(this.KeerTerugNaarMain_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.labelGemeenteN = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.labelGemeenteCode = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.textBoxNiscode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textBox1Gemeentenaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 40 "..\..\..\SelecteerStraat.xaml"
            this.dataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

