using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;
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
        
        public static List<Word> FilterWordsByDefinitions(List<string> definitions)
        {
            List<ScoredWord> result = new List<ScoredWord>();

            foreach (var word in Words)
            {
                result.Add(new ScoredWord(ScoreWordByDefinition(word, definitions), word));
            }
            
            result.Sort((a, b) => Math.Abs(a.Score) > Math.Abs(b.Score) ? 1 : -1);

            return ConvertScoredWordToWordList(result);
        }
        public static List<Word> FilterWordsByGlyphs(List<Glyph> glyphs)
        {
            List<ScoredWord> result = new List<ScoredWord>();

            foreach (var word in Words)
            {
                result.Add(new ScoredWord(ScoreWordByGlyph(word, glyphs), word));
            }
            
            result.Sort((a, b) => a.Score > b.Score ? -1 : 1);
            
            return ConvertScoredWordToWordList(result);
        }
        private static int ScoreWordByDefinition(Word word, List<string> definitions)
        {
            int score = 0;
            
            foreach (var definition in definitions)
            {
                foreach (var wordDefinition in word.Definitions)
                {
                    score += String.Compare(definition, wordDefinition, StringComparison.Ordinal);
                }
            }

            return score;
        }
        private static int ScoreWordByGlyph(Word word, List<Glyph> glyphs)
        {
            int score = 0;
            
            foreach (var glyph in glyphs)
            {
                foreach (var wordGlyph in word.Glyphs)
                {
                    score += glyph.CompareTo(wordGlyph);
                }
            }

            return score;
        }
        private static List<Word> ConvertScoredWordToWordList(List<ScoredWord> scoredWords)
        {
            List<Word> words = new List<Word>();
            
            scoredWords.ForEach(sw => words.Add(sw.Word));

            return words;
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