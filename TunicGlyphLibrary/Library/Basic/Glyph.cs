using System.Collections.Generic;

namespace TunicGlyphLibrary.Library
{
    public class Glyph
    {
        private bool[] Values { get; } = new bool[13];

        public void SetValue(int index, bool value) => Values[index] = value;
        public bool GetValue(int index) => Values[index];
        public bool SwitchValue(int index)
        {
            Values[index] = !Values[index];
            return Values[index];
        }


        public static bool operator ==(Glyph a, Glyph b)
        {
            for (int i = 0; i < 13; i++)
            {
                if (a.Values[i] != b.Values[i]) return false;
            }
            return true;
        }
        public static bool operator !=(Glyph a, Glyph b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Glyph other) return Equals(other);
            return base.Equals(obj);
        }
        protected bool Equals(Glyph other)
        {
            return this == other;
        }
        public override int GetHashCode()
        {
            return (Values != null ? Values.GetHashCode() : 0);
        }
    }
}