﻿#pragma checksum "..\..\..\..\Windows\Elements\DefinitionsEditorControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DB4DC7CB7369CA60384F6CDAF4A19E5643C0C8DAC3EFD574D26D8DEA551A2C10"
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
using TunicGlyphLibrary.Windows.Elements;


namespace TunicGlyphLibrary.Windows.Elements {
    
    
    /// <summary>
    /// DefinitionsEditorControl
    /// </summary>
    public partial class DefinitionsEditorControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\Windows\Elements\DefinitionsEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid DefinitionEditorGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Windows\Elements\DefinitionsEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel DefinitionsStack;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Windows\Elements\DefinitionsEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DefinitionTextBox;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Windows\Elements\DefinitionsEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddDefinitionBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/TunicGlyphLibrary;component/windows/elements/definitionseditorcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Elements\DefinitionsEditorControl.xaml"
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
            this.DefinitionEditorGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.DefinitionsStack = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 3:
            this.DefinitionTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\..\..\Windows\Elements\DefinitionsEditorControl.xaml"
            this.DefinitionTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.DefinitionTextBox_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddDefinitionBtn = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Windows\Elements\DefinitionsEditorControl.xaml"
            this.AddDefinitionBtn.Click += new System.Windows.RoutedEventHandler(this.AddDefinitionBtn_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

