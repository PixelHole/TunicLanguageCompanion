using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using TunicGlyphLibrary.Library;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class DefinitionsEditorControl : UserControl
    {
        private List<string> _definitions = new List<string>();

        public List<string> Definitions
        {
            get => _definitions;
            set
            {
                _definitions = value;
                UpdateDefinitionsStack();
                ClearDefinitionTextBox();
            }
        }

        public DefinitionsEditorControl()
        {
            InitializeComponent();
        }


        public void Clear()
        {
            Definitions = new List<string>();
            ClearDefinitionTextBox();
        }
        public void AddDefinition(string definition)
        {
            if (Definitions.Contains(definition)) return;
            ClearDefinitionTextBox();
            Definitions.Add(definition);
            CreateDefinitionPanel(definition);
        }
        public void RemoveDefinition(string definition)
        {
            int index = Definitions.IndexOf(definition);
            if (index == -1) return;
            Definitions.RemoveAt(index);
            RemoveDefinitionPanel(index);
        }
        
        // UI Event Handlers
        private void AddDefinitionBtn_OnClick(object sender, RoutedEventArgs e)
        {
            if (DefinitionTextBox.Text != string.Empty)
            {
                AddDefinition(new string(DefinitionTextBox.Text.ToCharArray()));
            }
        }
        private void DefinitionTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (DefinitionTextBox.Text != string.Empty)
            {
                AddDefinitionBtn.IsEnabled = true;
                return;
            }

            AddDefinitionBtn.IsEnabled = false;
        }
        private void DefinitionPanelDeleteHandler(string definition)
        {
            RemoveDefinition(definition);
        }
        
        
        // definition Panel
        private void UpdateDefinitionsStack()
        {
            for (int i = 0; i < Definitions.Count; i++)
            {
                if (i < DefinitionsStack.Children.Count)
                {
                    ((DefinitionPanel)DefinitionsStack.Children[i]).Definition = Definitions[i];
                    continue;
                }

                CreateDefinitionPanel(Definitions[i]);
            }

            for (int i = DefinitionsStack.Children.Count - 1; i > Definitions.Count - 1; i--)
            {
                RemoveDefinitionPanel(i);
            }
        }
        private void CreateDefinitionPanel(string definition)
        {
            DefinitionPanel defPanel = new DefinitionPanel(definition);
            defPanel.OnDeleteRequest += DefinitionPanelDeleteHandler;
            DefinitionsStack.Children.Add(defPanel);
        }
        private void RemoveDefinitionPanel(int index)
        {
            var panel = (DefinitionPanel)DefinitionsStack.Children[index];
            panel.OnDeleteRequest -= DefinitionPanelDeleteHandler;
            DefinitionsStack.Children.Remove(panel);
        }
        
        // definition text box
        private void ClearDefinitionTextBox()
        {
            DefinitionTextBox.Text = "";
        }
    }
}