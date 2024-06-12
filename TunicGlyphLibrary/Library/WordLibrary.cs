using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TunicGlyphLibrary.Library
{
    public static class WordLibrary
    {
        public delegate void WordAdded(Word addedWord);
        public delegate void WordRemoved(Word removedWord);
        public static event WordAdded OnWordAdded;
        public static event WordAdded OnWordRemoved;
        
        public static List<Word> Words { get; private set; } = new List<Word>();

        public static void AddWord(Word word)
        {
            if (Words.Contains(word)) return;
            OnWordAdded?.Invoke(word);
            Words.Add(word);
        }
        public static void RemoveWord(Word word)
        {
            if (!Words.Contains(word)) return;
            Words.Remove(word);   
            OnWordRemoved?.Invoke(word);
        }
    }
}