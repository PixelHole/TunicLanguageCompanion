using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class StyledTextBox : UserControl
    {
        public delegate void TextChangeHandler(object sender, TextChangedEventArgs e);
        public event TextChangeHandler OnTextChanged;
        
        public Brush DefaultColor { get; set; } = new SolidColorBrush(Color.FromRgb(204, 213, 209));
        public Brush HighlightColor { get; set; } = new SolidColorBrush(Color.FromRgb(220, 222, 221));

        public string Text
        {
            get => TextBox.Text;
            set => TextBox.Text = value;
        }
        
        public StyledTextBox()
        {
            InitializeComponent();
            TextBox.Foreground = new SolidColorBrush(Color.FromRgb(61, 51, 51));
            SetColorToDefault();
        }

        private void SetColorToDefault()
        {
            TextBoxBackground.Fill = DefaultColor;
        }
        private void SetColorToHighlighted()
        {
            TextBoxBackground.Fill = HighlightColor;
        }
        
        private void TextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            OnTextChanged?.Invoke(sender, e);
        }
        private void TextBox_OnGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            SetColorToHighlighted();
        }
        private void TextBox_OnLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            SetColorToDefault();
        }
    }
}