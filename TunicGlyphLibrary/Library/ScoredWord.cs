namespace TunicGlyphLibrary.Library
{
    public struct ScoredWord
    {
        public int Score { get; set; }
        public Word Word { get; set; }

        public ScoredWord(int score, Word word)
        {
            Score = score;
            Word = word;
        }
    }
}