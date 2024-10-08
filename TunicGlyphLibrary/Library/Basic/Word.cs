﻿using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace TunicGlyphLibrary.Library
{
    public class Word
    {
        [JsonProperty]
        public List<string> Definitions { get; } = new List<string>();
        [JsonProperty]
        public List<Glyph> Glyphs { get; } = new List<Glyph>();


        public Word()
        {
            
        }
        [JsonConstructor]
        public Word(List<Glyph> glyphs, List<string> definitions) : this()
        {
            SetDefinitions(definitions);
            SetGlyphs(glyphs);
        }

        public void SetDefinitions(List<string> definitions)
        {
            Definitions.Clear();
            definitions.ForEach(definition => Definitions.Add(new string(definition.ToCharArray())));
        }
        public void SetGlyphs(List<Glyph> glyphs)
        {
            Glyphs.Clear();
            glyphs.ForEach(glyph => Glyphs.Add(new Glyph(glyph)));
        }


        public static bool operator ==(Word a, Word b)
        {
            if (a?.Definitions.Count != b?.Definitions.Count) return false;

            if (a?.Definitions != null)
                if ((a?.Definitions).Any(definition => !b.Definitions.Contains(definition)))
                {
                    return false;
                }

            if (a?.Glyphs.Count != b?.Glyphs.Count) return false;

            for (int i = 0; i < a?.Glyphs.Count; i++)
            {
                if (a.Glyphs[i] != b.Glyphs[i]) return false;
            }

            return true;
        }
        public static bool operator !=(Word a, Word b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Word other) return Equals(other);
            return base.Equals(obj);
        }
        protected bool Equals(Word other)
        {
            return this == other;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                return ((Definitions != null ? Definitions.GetHashCode() : 0) * 397) ^ (Glyphs != null ? Glyphs.GetHashCode() : 0);
            }
        }
    }
}