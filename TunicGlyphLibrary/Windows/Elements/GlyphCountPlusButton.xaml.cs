using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class GlyphCountPlusButton : UserControl
    {
        public delegate void ClickHandler();
        public event ClickHandler Click;
         
        public GlyphCountPlusButton()
        {
            InitializeComponent();
        }
        private void GlyphCountBtn_OnClick(object sender, RoutedEventArgs e)
        {
            Click?.Invoke();
        }
    }
}