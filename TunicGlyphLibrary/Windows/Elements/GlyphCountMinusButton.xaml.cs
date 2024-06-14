using System.Windows;
using System.Windows.Controls;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class GlyphCountMinusButton : UserControl
    {
        public delegate void ClickHandler();
        public event ClickHandler Click;
        
        public GlyphCountMinusButton()
        {
            InitializeComponent();
        }
        
        private void GlyphCountBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Click?.Invoke();
        }
    }
}