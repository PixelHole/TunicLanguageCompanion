using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TunicGlyphLibrary.Library;
using TunicGlyphLibrary.Windows.Elements;

namespace TunicGlyphLibrary.Windows
{
    public partial class MainWindow
    {
        private Word EditingWord { get; set; }
        private bool EditingMode { get; set; } = false;
        
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            WordLibrary.OnRequestWordEdit += RequestEditWord;
            WordLibrary.OnRequestWordEdit += RequestEditWord;
        }
        
        private void RequestEditWord(Word word)
        {
            EditingWord = word;
            Word copy = new Word(word.Glyphs, word.Definitions);
            WordEditor.DefinitionsEditor.Definitions = copy.Definitions;
            WordEditor.WordDisplay.Glyphs = copy.Glyphs;
            EditingMode = true;
        }
        
        private void SaveToLibraryBtn_OnClick(object sender, RoutedEventArgs e)
        {
            SaveWordToLibrary();
        }
        private void SaveWordToLibrary()
        {
            Word word = new Word(WordEditor.WordDisplay.Glyphs, WordEditor.DefinitionsEditor.Definitions);
            if (!EditingMode)
            {
                if (WordLibrary.AddWord(word)) WordEditor.ResetEditor();
                return;
            }

            WordLibrary.EditWord(EditingWord, word);
            WordEditor.ResetEditor();
        }
    }
}