using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class DefinitionPanelCloseButton : UserControl
    {
        public delegate void ClickHandler();
        public event ClickHandler Click;
        
        private bool isMouseOver = false;
        
        public DefinitionPanelCloseButton()
        {
            InitializeComponent();
        }

        private void ShowHighlight()
        {
            highlight.Visibility = Visibility.Visible;
        }
        private void HideHighlight()
        {
            highlight.Visibility = Visibility.Hidden;
        }
        
        private void MainBody_OnMouseEnter(object sender, MouseEventArgs e)
        {
            isMouseOver = true;
            ShowHighlight();
        }
        private void MainBody_OnMouseLeave(object sender, MouseEventArgs e)
        {
            isMouseOver = false;
            HideHighlight();
        }
        private void MainBody_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            Click?.Invoke();
        }
    }
}