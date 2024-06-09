using System.Collections.Generic;

namespace TunicGlyphLibrary.Library
{
    public class Glyph
    {
        private bool[] Values { get; set; } = new bool[13];
        public List<string> AssociatedWords = new List<string>();

        public void SetValue(int index, bool value) => Values[index] = value;
        public bool GetValue(int index) => Values[index];
        public bool SwitchValue(int index)
        {
            Values[index] = !Values[index];
            return Values[index];
        }
    }
}