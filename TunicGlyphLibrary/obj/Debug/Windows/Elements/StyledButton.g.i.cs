﻿#pragma checksum "..\..\..\..\Windows\Elements\StyledButton.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C6D34F1FD45CB3EDBFB3B2A05A1344A77687B8992784A60DCCFD499D66E69A94"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace TunicGlyphLibrary.Windows.Elements {
    
    
    /// <summary>
    /// StyledButton
    /// </summary>
    public partial class StyledButton : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\Windows\Elements\StyledButton.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainBody;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\Windows\Elements\StyledButton.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle ButtonBackground;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Windows\Elements\StyledButton.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ButtonText;
        
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
            System.Uri resourceLocater = new System.Uri("/TunicGlyphLibrary;component/windows/elements/styledbutton.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Elements\StyledButton.xaml"
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
            
            #line 10 "..\..\..\..\Windows\Elements\StyledButton.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.BackGround_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\Windows\Elements\StyledButton.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.BackGround_OnMouseLeave);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\Windows\Elements\StyledButton.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.BackGround_OnMouseDown);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\..\Windows\Elements\StyledButton.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.BackGround_OnMouseUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainBody = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.ButtonBackground = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 4:
            this.ButtonText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

