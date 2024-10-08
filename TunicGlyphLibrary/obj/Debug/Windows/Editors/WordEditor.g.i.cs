﻿#pragma checksum "..\..\..\..\Windows\Editors\WordEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E84079497DDBB8FC75DEDFF86E08ED500F6DBFBE594CE8E7D91CF4CCB4CCA945"
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


namespace TunicGlyphLibrary.Windows.Editors {
    
    
    /// <summary>
    /// WordEditor
    /// </summary>
    public partial class WordEditor : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\Windows\Editors\WordEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TunicGlyphLibrary.Windows.Elements.LanguageWordControl WordDisplay;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Windows\Editors\WordEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveGlyphBtn;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Windows\Editors\WordEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddGlyphBtn;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Windows\Editors\WordEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button GlyphSearchBtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Windows\Editors\WordEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DefinitionSearchBtn;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\Windows\Editors\WordEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal TunicGlyphLibrary.Windows.Elements.DefinitionsEditor DefinitionsEditor;
        
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
            System.Uri resourceLocater = new System.Uri("/TunicGlyphLibrary;component/windows/editors/wordeditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\Editors\WordEditor.xaml"
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
            
            #line 17 "..\..\..\..\Windows\Editors\WordEditor.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.WordEditorPanel_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 17 "..\..\..\..\Windows\Editors\WordEditor.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.WordEditorPanel_OnMouseLeave);
            
            #line default
            #line hidden
            return;
            case 2:
            this.WordDisplay = ((TunicGlyphLibrary.Windows.Elements.LanguageWordControl)(target));
            return;
            case 3:
            this.RemoveGlyphBtn = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Windows\Editors\WordEditor.xaml"
            this.RemoveGlyphBtn.Click += new System.Windows.RoutedEventHandler(this.RemoveGlyphBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.AddGlyphBtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\Windows\Editors\WordEditor.xaml"
            this.AddGlyphBtn.Click += new System.Windows.RoutedEventHandler(this.AddGlyphBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GlyphSearchBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            
            #line 29 "..\..\..\..\Windows\Editors\WordEditor.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.DefinitionEditorGrid_OnMouseEnter);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\..\Windows\Editors\WordEditor.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.DefinitionEditorGrid_OnMouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DefinitionSearchBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.DefinitionsEditor = ((TunicGlyphLibrary.Windows.Elements.DefinitionsEditor)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

