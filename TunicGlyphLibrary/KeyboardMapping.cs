using System.Windows.Input;

namespace TunicGlyphLibrary
{
    public static class KeyboardMapping
    {
        public static Key TopTopLeft { get; private set; } = Key.Q;
        public static Key TopMiddle { get; private set; } = Key.W;
        public static Key TopTopRight { get; private set; } = Key.E;
        public static Key TopLeft { get; private set; } = Key.A;
        public static Key TopBottomLeft { get; private set; } = Key.S;
        public static Key TopBottomRight { get; private set; } = Key.D;

        public static Key BottomLeft { get; private set; } = Key.O;
        public static Key BottomTopLeft { get; private set; } = Key.P;
        public static Key BottomTopRight { get; private set; } = Key.OemOpenBrackets;
        public static Key BottomBottomLeft { get; private set; } = Key.L;
        public static Key BottomMiddle { get; private set; } = Key.OemSemicolon;
        public static Key BottomBottomRight { get; private set; } = Key.OemQuotes;

        public static Key Circle1 { get; private set; } = Key.OemComma;
        public static Key Circle2 { get; private set; } = Key.C;

        public static Key CreateGlyph { get; private set; } = Key.Space;
        public static Key RemoveGlyph { get; private set; } = Key.OemBackslash;
        
        public static Key NextGlyph { get; private set; } = Key.LeftShift;
        public static Key PreviousGlyph { get; private set; } = Key.RightShift;
    }
}