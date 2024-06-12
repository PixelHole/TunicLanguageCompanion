using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class DefinitionPanel : UserControl
    {
        public delegate void DeleteRequest(string definition);
        public event DeleteRequest OnDeleteRequest;
        
        private string _definition;
        public string Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                UpdateDefinitionText();
            }
        }
        public DefinitionPanel()
        {
            DataContext = this;
            InitializeComponent();
        }
        public DefinitionPanel(string definition) : this()
        {
            Definition = definition;
        }

        private void UpdateDefinitionText()
        {
            DefinitionText.Text = Definition;
        }

        private void CloseBtn_OnClick(object sender, RoutedEventArgs e)
        {
            OnDeleteRequest?.Invoke(Definition);
        }
    }
}