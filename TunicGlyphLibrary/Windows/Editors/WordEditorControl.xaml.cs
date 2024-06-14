using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using TunicGlyphLibrary.Library;

namespace TunicGlyphLibrary.Windows.Editors
{
    public partial class WordEditorControl : UserControl
    {
        public WordEditorControl()
        {
            InitializeComponent();
            SetupWordDisplay();
        }
        
        
        // Word Editor Functions
        public void ResetEditor()
        {
            WordDisplay.Clear();
            DefinitionsEditor.Clear();
        }
        
        // UI Mouse Handler
        private void WordEditorPanel_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ShowGlyphSearchButton();
        }
        private void WordEditorPanel_OnMouseLeave(object sender, MouseEventArgs e)
        {
            HideGlyphSearchButton();
        }
        private void DefinitionEditorGrid_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ShowDefinitionSearchButton();
        }
        private void DefinitionEditorGrid_OnMouseLeave(object sender, MouseEventArgs e)
        {
            HideDefinitionSearchButton();
        }
        
        // word Display
        private void SetupWordDisplay()
        {
            WordDisplay.GlyphInactiveBrush = new SolidColorBrush(Color.FromRgb(242, 184, 136));
            WordDisplay.GlyphActiveBrush = new SolidColorBrush(Color.FromRgb(61, 51, 51));
            WordDisplay.GlyphHighlightBrush = new SolidColorBrush(Color.FromRgb(115, 76, 68));
            WordDisplay.GlyphHighlightBrush = new SolidColorBrush(Color.FromRgb(115, 76, 68));
            WordDisplay.AddEmptyGlyph();
        }

        // glyph Editor
        private void AddGlyphBtn_OnClick()
        {
            WordDisplay.AddEmptyGlyph();
        }
        private void RemoveGlyphBtn_OnClick()
        {
            WordDisplay.RemoveLastGlyph();
        }

        // word search buttons
        private void HideGlyphSearchButton()
        {
            GlyphSearchBtn.Visibility = Visibility.Hidden;
        }
        private void ShowGlyphSearchButton()
        {
            GlyphSearchBtn.Visibility = Visibility.Visible;
        }
        private void HideDefinitionSearchButton()
        {
            DefinitionSearchBtn.Visibility = Visibility.Hidden;
        }
        private void ShowDefinitionSearchButton()
        {
            DefinitionSearchBtn.Visibility = Visibility.Visible;
        }
    }
}