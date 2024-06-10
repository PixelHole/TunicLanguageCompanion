using System.Windows.Controls;
using System.Windows.Input;
using TunicGlyphLibrary.Library;

namespace TunicGlyphLibrary
{
    public partial class LanguageWordControl : UserControl
    {
        private bool KeyboardEditingEnabled;
        private int SelectedGlyphIndex { get; set; } = 0;
        private Word Word { get; set; } = new Word();
        public LanguageWordControl()
        {
            InitializeComponent();
        }
        public LanguageWordControl(Word word) : this()
        {
            Word = word;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            e.Handled = true;
            
            
        }
    }
}