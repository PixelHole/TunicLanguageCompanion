using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class StyledButton : UserControl
    {
        public delegate void ClickHandler(object sender, RoutedEventArgs e);
        public event ClickHandler Click;

        public Brush DefaultColor { get; set; } = new SolidColorBrush(Color.FromRgb(204, 213, 209));
        public Brush HighlightColor { get; set; } = new SolidColorBrush(Color.FromRgb(220, 222, 221));

        private string _text;

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                UpdateButtonText();
            }
        }

        private Thickness initialMargin;

        public StyledButton()
        {
            DataContext = this;
            InitializeComponent();
            ButtonText.Foreground = new SolidColorBrush(Color.FromRgb(61, 51, 51));
            initialMargin = new Thickness(MainBody.Margin.Left, MainBody.Margin.Top, MainBody.Margin.Right,
                MainBody.Margin.Bottom);
        }

        private void UpdateButtonText()
        {
            ButtonText.Text = Text;
        }
        
        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            Click?.Invoke(sender, e);
        }
        private void BackGround_OnMouseEnter(object sender, MouseEventArgs e)
        {
            BackGround.Fill = HighlightColor;
            MainBody.Margin = new Thickness(MainBody.Margin.Left, initialMargin.Top - 5, MainBody.Margin.Right, initialMargin.Bottom + 5);
        }
        private void BackGround_OnMouseLeave(object sender, MouseEventArgs e)
        {
            BackGround.Fill = DefaultColor;
            MainBody.Margin = new Thickness(MainBody.Margin.Left, initialMargin.Top, MainBody.Margin.Right, initialMargin.Bottom);
        }
        private void BackGround_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            throw new System.NotImplementedException();
        }
        private void BackGround_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}