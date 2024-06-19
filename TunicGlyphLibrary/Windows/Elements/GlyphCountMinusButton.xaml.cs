using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class GlyphCountMinusButton : UserControl
    {
        public delegate void ClickHandler();
        public event ClickHandler Click;
        
        private Thickness initialMargin;
        
        public GlyphCountMinusButton()
        {
            InitializeComponent();
            SaveInitialMargin();
        }
        
        private void SaveInitialMargin()
        {
            initialMargin = new Thickness(GlyphCountBtn.Margin.Left, GlyphCountBtn.Margin.Top, GlyphCountBtn.Margin.Right,
                GlyphCountBtn.Margin.Bottom);
        }
        private void MoveUp()
        {
            GlyphCountBtn.Margin = new Thickness(GlyphCountBtn.Margin.Left, initialMargin.Top - 5, GlyphCountBtn.Margin.Right, 
                initialMargin.Bottom + 5);
        }
        private void MoveDown()
        {
            GlyphCountBtn.Margin = new Thickness(GlyphCountBtn.Margin.Left, initialMargin.Top, GlyphCountBtn.Margin.Right, initialMargin.Bottom);
        }
        
        private void GlyphCountBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Click?.Invoke();
        }
        
        private void MainBody_OnMouseEnter(object sender, MouseEventArgs e)
        {
            MoveUp();
        }
        private void MainBody_OnMouseLeave(object sender, MouseEventArgs e)
        {
            MoveDown();
        }
        private void GlyphCountBtn_OnPreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MoveUp();
        }
        private void GlyphCountBtn_OnPreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MoveDown();
        }
    }
}