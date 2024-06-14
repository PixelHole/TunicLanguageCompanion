using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TunicGlyphLibrary.Library;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class WordLibraryItem : UserControl
    {
        public delegate void EditRequest(Word word);
        public delegate void DeleteRequest(Word word);
        public event EditRequest OnEditRequest;
        public event DeleteRequest OnDeleteRequest;
        
        
        private Word _word  = new Word();
        public Word Word
        {
            get => _word;
            set
            {
                _word = value;
                UpdateDisplay();
            }
        }
        
        
        public WordLibraryItem()
        {
            InitializeComponent();
            UpdateDisplay();
        }
        public WordLibraryItem(Word word)
        {
            InitializeComponent();
            Word = word;
        }

        private void UpdateDisplay()
        {
            WordDisplay.Glyphs = Word.Glyphs;
            if (Word.Definitions.Count == 0)
            {
                DefinitionTextBlock.Text = "No Definition Given";
                return;
            }

            DefinitionTextBlock.Text = Word.Definitions[0];
        }

        private void RequestDeleteWord()
        {
            OnDeleteRequest?.Invoke(Word);
        }
        private void RequestEditWord()
        {
            OnEditRequest?.Invoke(Word);
        }

        private void HideControlButtons()
        {
            ControlPanel.Visibility = Visibility.Hidden;
        }
        private void ShowControlButtons()
        {
            ControlPanel.Visibility = Visibility.Visible;
        }
        
        private void Frame_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ShowControlButtons();
        }
        private void Frame_OnMouseLeave(object sender, MouseEventArgs e)
        {
            HideControlButtons();
        }
        private void EditBtn_OnClick(object sender, RoutedEventArgs e)
        {
            RequestEditWord();
        }
        private void DeleteBtn_OnClick(object sender, RoutedEventArgs e)
        {
            RequestDeleteWord();
        }
    }
}