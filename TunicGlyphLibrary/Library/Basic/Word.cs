using System.Collections.Generic;

namespace TunicGlyphLibrary.Library
{
    public class Word
    {
        public List<string> Definitions { get; private set; } = new List<string>();
        public List<Glyph> Glyphs { get; private set; } = new List<Glyph>();
    }
}