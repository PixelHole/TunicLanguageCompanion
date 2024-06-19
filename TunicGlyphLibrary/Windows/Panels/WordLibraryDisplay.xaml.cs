﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TunicGlyphLibrary.Library;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class WordLibraryDisplay : UserControl
    {
        public WordLibraryDisplay()
        {
            InitializeComponent();
            WordLibrary.OnWordAdded += CreateLibraryDisplayItem;
            WordLibrary.OnWordRemoved += OnLibraryWordRemoved;
            WordLibrary.OnWordEdited += UpdateLibraryDisplayItem;
        }

        private void OnLibraryWordRemoved(int index, Word word)
        {
            RemoveLibraryDisplayItem(index);
        }
        
        public void UpdateLibraryDisplay()
        {
            for (int i = 0; i < WordLibrary.Words.Count; i++)
            {
                if (i < WordLibraryList.Children.Count)
                {
                    UpdateLibraryDisplayItem(i);
                    continue;
                }
                CreateLibraryDisplayItem(WordLibrary.Words[i]);
            }

            for (int i = WordLibraryList.Children.Count; i > WordLibrary.Words.Count ; i--)
            {
                RemoveLibraryDisplayItem(i);
            }
        }
        private void UpdateLibraryDisplayItem(int index)
        {
            ((WordLibraryItem)WordLibraryList.Children[index]).Word = WordLibrary.Words[index];
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
        
        
    }
}