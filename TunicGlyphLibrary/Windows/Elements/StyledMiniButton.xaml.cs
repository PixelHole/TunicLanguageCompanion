using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class StyledMiniButton : UserControl
    {
        public delegate void ClickHandler();
        public event ClickHandler Click;
        
        private Brush _defaultColor = new SolidColorBrush(Color.FromRgb(204, 213, 209));
        private Brush _HighlightColor = new SolidColorBrush(Color.FromRgb(220, 222, 221));

        public Brush DefaultColor
        {
            get => _defaultColor;
            set
            {
                
            }
        }

        public Brush HighlightColor
        {
            get => _HighlightColor;
            set
            {
                
            }
        }

        private Uri _iconUri;
        public Uri IconUri
        {
            get => _iconUri;
            set
            {
                _iconUri = value;
                UpdateIcon();
            }
        }
        
        private Thickness initialMargin;
        
        public StyledMiniButton()
        {
            InitializeComponent();
            SaveInitialMargin();
            SetColorToDefault();
        }

        private void UpdateIcon()
        {
            Icon.Source = new BitmapImage(IconUri);
        }
        private void SetColorToDefault()
        {
            ButtonBackground.Fill = DefaultColor;
        }
        private void SetColorToHighlight()
        {
            ButtonBackground.Fill = HighlightColor;
        }
        
        private void SaveInitialMargin()
        {
            initialMargin = new Thickness(Body.Margin.Left, Body.Margin.Top, Body.Margin.Right,
                Body.Margin.Bottom);
        }
        private void MoveUp()
        {
            Body.Margin = new Thickness(Body.Margin.Left, initialMargin.Top - 5, Body.Margin.Right, 
                initialMargin.Bottom + 5);
        }
        private void MoveDown()
        {
            Body.Margin = new Thickness(Body.Margin.Left, initialMargin.Top, Body.Margin.Right, initialMargin.Bottom);
        }
        private void BodyBase_OnMouseEnter(object sender, MouseEventArgs e)
        {
            SetColorToHighlight();
            MoveUp();
        }
        private void BodyBase_OnMouseLeave(object sender, MouseEventArgs e)
        {
            SetColorToDefault();
            MoveDown();
        }
        private void BodyBase_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MoveDown();
        }
        private void BodyBase_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            Click?.Invoke();
            MoveUp();
        }
    }
}