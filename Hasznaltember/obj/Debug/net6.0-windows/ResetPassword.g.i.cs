﻿#pragma checksum "..\..\..\ResetPassword.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AD108DDE61C99E51DBC525A5BFDB45FD7B188BA5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Hasznaltember;
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


namespace Hasznaltember {
    
    
    /// <summary>
    /// ResetPassword
    /// </summary>
    public partial class ResetPassword : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\ResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbEmail;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\ResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbUsername;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\ResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNewPassword;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\ResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pbNewPassword;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\ResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblNewPassword;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\ResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNewPasswordRepeat;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\ResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pbNewPasswordRepeat;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\ResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblNewPasswordRepeat;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\ResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnResetPassword;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\ResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbEmailError;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\ResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbUsernameError;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\ResetPassword.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbPasswordError;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Hasznaltember;V1.0.0.0;component/resetpassword.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ResetPassword.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tbEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tbUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.tbNewPassword = ((System.Windows.Controls.TextBox)(target));
            
            #line 54 "..\..\..\ResetPassword.xaml"
            this.tbNewPassword.GotFocus += new System.Windows.RoutedEventHandler(this.Next1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pbNewPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 61 "..\..\..\ResetPassword.xaml"
            this.pbNewPassword.PasswordChanged += new System.Windows.RoutedEventHandler(this.pbNewPassword_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tblNewPassword = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tbNewPasswordRepeat = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\ResetPassword.xaml"
            this.tbNewPasswordRepeat.GotFocus += new System.Windows.RoutedEventHandler(this.Next2);
            
            #line default
            #line hidden
            return;
            case 7:
            this.pbNewPasswordRepeat = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 81 "..\..\..\ResetPassword.xaml"
            this.pbNewPasswordRepeat.PasswordChanged += new System.Windows.RoutedEventHandler(this.pbNewPasswordRepeat_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tblNewPasswordRepeat = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.btnResetPassword = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\ResetPassword.xaml"
            this.btnResetPassword.Click += new System.Windows.RoutedEventHandler(this.btnResetPassword_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lbEmailError = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.lbUsernameError = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.lbPasswordError = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

