using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using TunicGlyphLibrary.Library;

namespace TunicGlyphLibrary.Windows.Editors
{
    public partial class WordEditorControl : UserControl
    {
        public Word EditingWord { get; private set; }
        public bool EditingMode { get; private set; } = false;
        
        public WordEditorControl()
        {
            InitializeComponent();
            SetupWordDisplay();
            InitialSetup();
        }
        
        private void InitialSetup()
        {
            WordLibrary.OnRequestWordEdit += RequestEditWord;
            WordLibrary.OnWordRemoved += OnWordRemoved;
            
            DoneBtn.SetColors(Color.FromRgb(179, 165, 85), Color.FromRgb(233, 216, 118));
            CancelBtn.SetColors(Color.FromRgb(199, 123, 88), Color.FromRgb(252, 158, 115));
        }
        
        
        // Event Handlers
        private void RequestEditWord(Word word)
        {
            EditingWord = word;
            Word copy = new Word(word.Glyphs, word.Definitions);
            DefinitionsEditor.Definitions = copy.Definitions;
            WordDisplay.Glyphs = copy.Glyphs;
            EditingMode = true;
            ShowCancelButton();
        }
        private void OnWordRemoved(int index, Word word)
        {
            if (EditingWord == word)
            {
                ResetEditor();
            }
        }
        
        // Word Editor Functions
        public void ResetEditor()
        {
            WordDisplay.Clear();
            DefinitionsEditor.Clear();
            EditingMode = false;
            EditingWord = null;
            HideCancelButton();
        }
        public Word GetWord()
        {
            return new Word(WordDisplay.Glyphs, DefinitionsEditor.Definitions);
        }
        private void HideCancelButton()
        {
            CancelBtn.Visibility = Visibility.Collapsed;
        }
        private void ShowCancelButton()
        {
            CancelBtn.Visibility = Visibility.Visible;
        }
        private void SaveWordToLibrary()
        {
            var word = GetWord();
            if (!EditingMode)
            {
                if (WordLibrary.AddWord(word)) ResetEditor();
                return;
            }

            WordLibrary.EditWord(EditingWord, word);
            ResetEditor();
        }
        
        // UI Mouse Handler
        private void WordEditorPanel_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ShowGlyphControlPanel();
        }
        private void WordEditorPanel_OnMouseLeave(object sender, MouseEventArgs e)
        {
            HideGlyphControlPanel();
        }
        private void DefinitionEditorGrid_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ShowDefinitionControlPanel();
        }
        private void DefinitionEditorGrid_OnMouseLeave(object sender, MouseEventArgs e)
        {
            HideDefinitionControlPanel();
        }
        
        // word Display
        private void SetupWordDisplay()
        {
            WordDisplay.GlyphInactiveBrush = new SolidColorBrush(Color.FromRgb(215, 208, 178));
            WordDisplay.GlyphActiveBrush = new SolidColorBrush(Color.FromRgb(75, 61, 68));
            WordDisplay.GlyphHighlightBrush = new SolidColorBrush(Color.FromRgb(101, 81, 91));
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
        private void HideGlyphControlPanel()
        {
            WordDisplayUtility.Visibility = Visibility.Hidden;
        }
        private void ShowGlyphControlPanel()
        {
            WordDisplayUtility.Visibility = Visibility.Visible;
        }
        private void HideDefinitionControlPanel()
        {
            DefPanelUtility.Visibility = Visibility.Hidden;
        }
        private void ShowDefinitionControlPanel()
        {
            DefPanelUtility.Visibility = Visibility.Visible;
        }
        
        // Main UI event handlers
        private void DefinitionClearBtn_OnClick()
        {
            DefinitionsEditor.Clear();
        }
        private void GlyphClearBtn_OnClick()
        {
            WordDisplay.Clear();
        }
        private void DefinitionSearchBtn_OnClick()
        {
            
        }
        private void GlyphSearchBtn_OnClick()
        {
            
        }
        private void SaveToLibraryBtn_OnClick()
        {
            SaveWordToLibrary();
        }
        private void CancelBtn_OnClick()
        {
            ResetEditor();
        }
    }
}