using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TunicGlyphLibrary.Library
{
    public static class WordLibrary
    {
        public delegate void WordAdded(Word addedWord);
        public delegate void WordRemoved(int index, Word word);
        public delegate void WordEdited(int index);
        public delegate void RequestWordEdit(Word word);
        public static event WordAdded OnWordAdded;
        public static event WordRemoved OnWordRemoved;
        public static event WordEdited OnWordEdited;
        public static event RequestWordEdit OnRequestWordEdit;
        
        public static List<Word> Words { get; private set; } = new List<Word>();

        public static bool AddWord(Word word)
        {
            if (Words.Contains(word)) return false;
            Words.Add(word);
            OnWordAdded?.Invoke(word);
            return true;
        }
        public static void RemoveWord(Word word)
        {
            if (!Words.Contains(word)) return;
            int index = Words.IndexOf(word);
            Words.Remove(word);   
            OnWordRemoved?.Invoke(index, word);
        }
        public static void EditWord(Word word, Word newWord)
        {
            int index = Words.IndexOf(word);
            Words[index] = newWord;
            OnWordEdited?.Invoke(index);
        }

        public static void DeleteWordRequestHandler(Word word)
        {
            RemoveWord(word);
        }
        public static void EditWordRequestHandler(Word word)
        {
            OnRequestWordEdit?.Invoke(word);
        }
    }
}