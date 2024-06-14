using System.Windows.Controls;
using System.Windows.Media;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class StyledTextBox : UserControl
    {
        public delegate void TextChangeHandler(object sender, TextChangedEventArgs e);
        public event TextChangeHandler OnTextChanged;

        public string Text
        {
            get => TextBox.Text;
            set => TextBox.Text = value;
        }
        
        public StyledTextBox()
        {
            InitializeComponent();
            TextBox.Foreground = new SolidColorBrush(Color.FromRgb(61, 51, 51));
        }
        private void TextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            OnTextChanged?.Invoke(sender, e);
        }
    }
}