using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TunicGlyphLibrary.Library;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class WordLibraryDisplay : UserControl
    {
        private bool isFiltered { get; set; } = false;
        private List<Word> FilteredWordList { get; set; } = new List<Word>();
        
        
        public WordLibraryDisplay()
        {
            InitializeComponent();
            WordLibrary.OnWordAdded += CreateLibraryDisplayItem;
            WordLibrary.OnWordRemoved += OnLibraryWordRemoved;
            WordLibrary.OnWordEdited += UpdateLibraryDisplayItem;
        }
        
        
        // Word Filtering
        private void ClearFilter()
        {
            isFiltered = false;
            FilteredWordList.Clear();
            SetDisplayToRegularMode();
            UpdateLibraryDisplay();
        }
        public void FilterWordsByGlyphs(List<Glyph> glyphs)
        {
            isFiltered = true;
            FilteredWordList = WordLibrary.FilterWordsByGlyphs(glyphs);
            
            SetDisplayToFilterMode();
            UpdateLibraryDisplay();
        }
        public void FilterWordsByDefinitions(List<string> definitions)
        {
            isFiltered = true;
            FilteredWordList = WordLibrary.FilterWordsByDefinitions(definitions);
            
            SetDisplayToFilterMode();
            UpdateLibraryDisplay();
        }
        
        // Display Updating
        private void SetDisplayToFilterMode()
        {
            Grid.SetColumnSpan(WordLibraryList, 1);
            ClearFilterByn.Visibility = Visibility.Visible;
        }
        private void SetDisplayToRegularMode()
        {
            Grid.SetColumnSpan(WordLibraryList, 2);
            ClearFilterByn.Visibility = Visibility.Hidden;
        }

        // static event handlers
        private void OnLibraryWordRemoved(int index, Word word)
        {
            RemoveLibraryDisplayItem(index);
        }

        // Update List from Library
        private void UpdateLibraryDisplay()
        {
            for (int i = 0; i < GetSource().Count; i++)
            {
                if (i < WordLibraryList.Children.Count)
                {
                    UpdateLibraryDisplayItem(i);
                    continue;
                }
                CreateLibraryDisplayItem(GetSource()[i]);
            }

            for (int i = WordLibraryList.Children.Count; i > WordLibrary.Words.Count ; i--)
            {
                RemoveLibraryDisplayItem(i);
            }
        }
        private void UpdateLibraryDisplayItem(int index)
        {
            ((WordLibraryItem)WordLibraryList.Children[index]).Word = GetSource()[index];
        }
        private void CreateLibraryDisplayItem(Word word)
        {
            WordLibraryItem libraryItem = new WordLibraryItem(word)
            {
                Margin = new Thickness(5, 0, 0, 0),
            };
            libraryItem.OnDeleteRequest += WordLibrary.DeleteWordRequestHandler;
            libraryItem.OnEditRequest += WordLibrary.EditWordRequestHandler;
            
            WordLibraryList.Children.Add(libraryItem);
        }
        private void RemoveLibraryDisplayItem(int index)
        {
            var item = (WordLibraryItem)WordLibraryList.Children[index];
            item.OnEditRequest -= WordLibrary.EditWordRequestHandler;
            item.OnDeleteRequest -= WordLibrary.DeleteWordRequestHandler;
            WordLibraryList.Children.Remove(item);
        }
        
        // UI event Handlers
        private void ClearFilterByn_OnClick()
        {
            ClearFilter();
        }

        private List<Word> GetSource() => isFiltered ? FilteredWordList : WordLibrary.Words;
        
    }
}