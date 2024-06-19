using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using Newtonsoft.Json;

namespace TunicGlyphLibrary.Library
{
    public static class SaveFileManager
    {
        public static string SaveFileName { get; } = "data.json"; 
        
        public static void SaveAllWords()
        {
            string parsed = JsonConvert.SerializeObject(WordLibrary.Words);

            StreamWriter writer;

            try
            {
                writer = new StreamWriter(SaveFileName);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK);
                return;
            }
            
            writer.Write(parsed);
            
            writer.Close();
        }

        public static void LoadAllWords()
        {
            StreamReader reader;
            try
            {
                reader = new StreamReader(SaveFileName);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK);
                return;
            }

            string raw = reader.ReadToEnd();

            List<Word> loadedWords = JsonConvert.DeserializeObject<List<Word>>(raw);
            
            AddLoadedWordsToLibrary(loadedWords);
            
            reader.Close();
        }

        private static void AddLoadedWordsToLibrary(List<Word> loadedWords)
        {
            foreach (var word in loadedWords)
            {
                WordLibrary.AddWord(word);
            }
        }
    }
}