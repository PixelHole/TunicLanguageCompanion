using System.Windows;
using System.Windows.Controls;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class StyledButton : UserControl
    {
        public delegate void ClickHandler(object sender, RoutedEventArgs e);
        public event ClickHandler Click;
        public StyledButton()
        {
            InitializeComponent();
        }
        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            Click?.Invoke(sender, e);
        }
    }
}