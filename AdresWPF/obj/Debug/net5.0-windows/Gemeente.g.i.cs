﻿#pragma checksum "..\..\..\Gemeente.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16919ADB91B3F93D06757BF957DE7541B9FD1B0B"
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
    /// Gemeente
    /// </summary>
    public partial class Gemeente : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\Gemeente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelGemeenteWINDOWNISCODE;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Gemeente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelGemeentenNaam;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Gemeente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GemeenteBestaan;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Gemeente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GemeenteVerwijderen;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Gemeente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GemeenteToevoegen;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Gemeente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GemeenteUpdaten;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Gemeente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GaNaarHome;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Gemeente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxNISCODE;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Gemeente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxGemeentenaam;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Gemeente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox1;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Gemeente.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AdresWPF;component/gemeente.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Gemeente.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.labelGemeenteWINDOWNISCODE = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.labelGemeentenNaam = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.GemeenteBestaan = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Gemeente.xaml"
            this.GemeenteBestaan.Click += new System.Windows.RoutedEventHandler(this.BestaatGemeente_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GemeenteVerwijderen = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\Gemeente.xaml"
            this.GemeenteVerwijderen.Click += new System.Windows.RoutedEventHandler(this.VerwijderGemeente_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GemeenteToevoegen = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.GemeenteUpdaten = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Gemeente.xaml"
            this.GemeenteUpdaten.Click += new System.Windows.RoutedEventHandler(this.UpdateGemeente_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.GaNaarHome = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Gemeente.xaml"
            this.GaNaarHome.Click += new System.Windows.RoutedEventHandler(this.KeerTerugNaarMain_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.textBoxNISCODE = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.textBoxGemeentenaam = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.comboBox1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\Gemeente.xaml"
            this.comboBox1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBox1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

