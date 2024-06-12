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
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }
        private void SaveToLibraryBtn_OnClick(object sender, RoutedEventArgs e)
        {
            AddWordToLibrary();
        }
        private void AddWordToLibrary()
        {
            Word word = new Word(WordEditor.WordDisplay.Glyphs, WordEditor.DefinitionsEditor.Definitions);
            WordLibrary.AddWord(word);
        }
    }
}