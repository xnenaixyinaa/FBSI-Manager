﻿#pragma checksum "..\..\..\..\..\MVVM\Views\Containers\PhonesContainer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "197A9564F08843381E47E4C503F1BDFC8BE8CCD2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FBSI_Manager;
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


namespace FBSI_Manager {
    
    
    /// <summary>
    /// PhonesContainer
    /// </summary>
    public partial class PhonesContainer : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\..\MVVM\Views\Containers\PhonesContainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem SelectItem;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\..\MVVM\Views\Containers\PhonesContainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem EditItem;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\..\MVVM\Views\Containers\PhonesContainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem AddItem;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\..\MVVM\Views\Containers\PhonesContainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem RemoveItem;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\..\MVVM\Views\Containers\PhonesContainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Container;
        
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
            System.Uri resourceLocater = new System.Uri("/FBSI Manager;component/mvvm/views/containers/phonescontainer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\MVVM\Views\Containers\PhonesContainer.xaml"
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
            this.SelectItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 14 "..\..\..\..\..\MVVM\Views\Containers\PhonesContainer.xaml"
            this.SelectItem.Click += new System.Windows.RoutedEventHandler(this.SelectItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EditItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\..\..\..\MVVM\Views\Containers\PhonesContainer.xaml"
            this.EditItem.Click += new System.Windows.RoutedEventHandler(this.EditItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\..\..\..\MVVM\Views\Containers\PhonesContainer.xaml"
            this.AddItem.Click += new System.Windows.RoutedEventHandler(this.AddItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RemoveItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\..\..\..\MVVM\Views\Containers\PhonesContainer.xaml"
            this.RemoveItem.Click += new System.Windows.RoutedEventHandler(this.RemoveItem_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Container = ((System.Windows.Controls.StackPanel)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
