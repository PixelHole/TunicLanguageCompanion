﻿#pragma checksum "..\..\..\..\Windows\Panels\DefinitionsEditorControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "94F70B1E8808C4257A064FB8D0F5C8C4F3B6761CC5996558DBF676851271B971"
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
        
        
        #line 10 "..\..\..\..\Windows\Panels\DefinitionsEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid DefinitionEditorGrid;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\Windows\Panels\DefinitionsEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel DefinitionsStack;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Windows\Panels\DefinitionsEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TunicGlyphLibrary.Windows.Elements.StyledTextBox DefinitionTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Windows\Panels\DefinitionsEditorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TunicGlyphLibrary.Windows.Elements.StyledButton AddDefinitionBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/TunicGlyphLibrary;component/windows/panels/definitionseditorcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Panels\DefinitionsEditorControl.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.DefinitionTextBox = ((TunicGlyphLibrary.Windows.Elements.StyledTextBox)(target));
            return;
            case 4:
            this.AddDefinitionBtn = ((TunicGlyphLibrary.Windows.Elements.StyledButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

