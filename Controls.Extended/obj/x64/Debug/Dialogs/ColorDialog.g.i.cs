﻿#pragma checksum "..\..\..\..\Dialogs\ColorDialog.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1FCE7FD4F93B74F6101F715CD1885338"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Imagin.Common.Data.Converters;
using Imagin.Controls.Common;
using Imagin.Controls.Extended;
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


namespace Imagin.Controls.Extended {
    
    
    /// <summary>
    /// ColorDialog
    /// </summary>
    public partial class ColorDialog : Imagin.Controls.Common.BasicWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Dialogs\ColorDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Imagin.Controls.Extended.ColorPicker PART_ColorPicker;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Dialogs\ColorDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btOk;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Dialogs\ColorDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/Imagin.Controls.Extended;component/dialogs/colordialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Dialogs\ColorDialog.xaml"
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
            this.PART_ColorPicker = ((Imagin.Controls.Extended.ColorPicker)(target));
            return;
            case 2:
            
            #line 40 "..\..\..\..\Dialogs\ColorDialog.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnRevert);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btOk = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\Dialogs\ColorDialog.xaml"
            this.btOk.Click += new System.Windows.RoutedEventHandler(this.OnOk);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btCancel = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\Dialogs\ColorDialog.xaml"
            this.btCancel.Click += new System.Windows.RoutedEventHandler(this.OnCancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
