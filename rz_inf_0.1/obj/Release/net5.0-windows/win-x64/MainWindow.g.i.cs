﻿#pragma checksum "..\..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "817F82190EC244B3A7073266DA8B88BE5379B836"
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


namespace rz_inf_0._1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel btnPdfs;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pdfProductos;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button pdfPedidos;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel btnEmails;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button emailProductos;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button emailPedidos;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel btnGraficos;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button graficosProdCategorias;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button graficosProductosVentas;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/rz_inf_0.1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnPdfs = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.pdfProductos = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\MainWindow.xaml"
            this.pdfProductos.Click += new System.Windows.RoutedEventHandler(this.pdfProductos_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.pdfPedidos = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\MainWindow.xaml"
            this.pdfPedidos.Click += new System.Windows.RoutedEventHandler(this.pdfPedidos_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnEmails = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 5:
            this.emailProductos = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\..\..\MainWindow.xaml"
            this.emailProductos.Click += new System.Windows.RoutedEventHandler(this.emailProductos_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.emailPedidos = ((System.Windows.Controls.Button)(target));
            
            #line 71 "..\..\..\..\MainWindow.xaml"
            this.emailPedidos.Click += new System.Windows.RoutedEventHandler(this.emailPedidos_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnGraficos = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 8:
            this.graficosProdCategorias = ((System.Windows.Controls.Button)(target));
            
            #line 93 "..\..\..\..\MainWindow.xaml"
            this.graficosProdCategorias.Click += new System.Windows.RoutedEventHandler(this.graficosProdCategorias_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.graficosProductosVentas = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\..\MainWindow.xaml"
            this.graficosProductosVentas.Click += new System.Windows.RoutedEventHandler(this.graficosProductosVentas_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
