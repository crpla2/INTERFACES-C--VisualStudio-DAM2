﻿#pragma checksum "..\..\..\PageClientes.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BE0D08261DC448C1E9129BC5FF89332C99B6A9CA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfAppFitipaldi;


namespace WpfAppFitipaldi {
    
    
    /// <summary>
    /// PageClientes
    /// </summary>
    public partial class PageClientes : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\PageClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel formularioClientes;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\PageClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox clientesComboBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\PageClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nombreTextBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\PageClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox apellidosTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\PageClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox direccionTextBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\PageClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox telefonoTextBox;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\PageClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dniTextBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\PageClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insertarButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\PageClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button actualizarButton;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\PageClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button borrarButton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\PageClientes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button limpiarButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfAppFitipaldi;component/pageclientes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PageClientes.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.formularioClientes = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.clientesComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\PageClientes.xaml"
            this.clientesComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.clientesComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.nombreTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.apellidosTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.direccionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.telefonoTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.dniTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.insertarButton = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\PageClientes.xaml"
            this.insertarButton.Click += new System.Windows.RoutedEventHandler(this.insertarButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.actualizarButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\PageClientes.xaml"
            this.actualizarButton.Click += new System.Windows.RoutedEventHandler(this.actualizarButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.borrarButton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\PageClientes.xaml"
            this.borrarButton.Click += new System.Windows.RoutedEventHandler(this.borrarButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.limpiarButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\PageClientes.xaml"
            this.limpiarButton.Click += new System.Windows.RoutedEventHandler(this.limpiarButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

