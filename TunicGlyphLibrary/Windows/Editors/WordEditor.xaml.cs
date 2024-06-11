using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TunicGlyphLibrary.Library;

namespace TunicGlyphLibrary.Windows.Elements.Editors
{
    public partial class WordEditor : UserControl
    {
        public Word Word { get; private set; } = new Word();
        
        public WordEditor()
        {
            InitializeComponent();
        }
        
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
        // glyph Editor
        private void AddGlyphBtn_OnClick(object sender, RoutedEventArgs e)
        {
            WordDisplay.AddEmptyGlyph();
        }
        private void RemoveGlyphBtn_OnClick(object sender, RoutedEventArgs e)
        {
            WordDisplay.RemoveLastGlyph();
        }
        // word search button
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