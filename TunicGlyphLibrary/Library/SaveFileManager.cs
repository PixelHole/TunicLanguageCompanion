using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TunicGlyphLibrary.Library
{
    public static class SaveFileManager
    {
        public static string SaveFileName { get; } = "data.json"; 
        
        public static void SaveAllWords()
        {
            string parsed = JsonConvert.SerializeObject(WordLibrary.Words);
            StreamWriter writer = new StreamWriter(SaveFileName);
            
            writer.Write(parsed);
            
            writer.Close();
        }

        public static void LoadAllWords()
        {
            StreamReader reader = new StreamReader(SaveFileName);

            string raw = reader.ReadToEnd();

            List<Word> loadedWords = JsonConvert.DeserializeObject<List<Word>>(raw);
            
            AddLoadedWordsToLibrary(loadedWords);
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