﻿#pragma checksum "..\..\DialogBox.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "24A9835D4C6BB6C8C86C96BD7E5451C54736DC63EF0A8B9EFA623275B28025FE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BotNet_Server_UI;
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


namespace BotNet_Server_UI {
    
    
    /// <summary>
    /// DialogBox
    /// </summary>
    public partial class DialogBox : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\DialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ServerTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\DialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox sResponseTextBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\DialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox ResponseTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\DialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AuthButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\DialogBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbShow;
        
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
            System.Uri resourceLocater = new System.Uri("/BotNet Server UI;component/dialogbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DialogBox.xaml"
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
            
            #line 8 "..\..\DialogBox.xaml"
            ((BotNet_Server_UI.DialogBox)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ServerTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 19 "..\..\DialogBox.xaml"
            this.ServerTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.Field_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.sResponseTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\DialogBox.xaml"
            this.sResponseTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.Field_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ResponseTextBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 22 "..\..\DialogBox.xaml"
            this.ResponseTextBox.KeyDown += new System.Windows.Input.KeyEventHandler(this.Field_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AuthButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\DialogBox.xaml"
            this.AuthButton.Click += new System.Windows.RoutedEventHandler(this.OKButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.cbShow = ((System.Windows.Controls.CheckBox)(target));
            
            #line 24 "..\..\DialogBox.xaml"
            this.cbShow.Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 24 "..\..\DialogBox.xaml"
            this.cbShow.Unchecked += new System.Windows.RoutedEventHandler(this.cbShow_Unchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

