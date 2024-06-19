using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class StyledButton : UserControl
    {
        public delegate void ClickHandler();
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

        private bool MouseIsOn = false;

        private Thickness initialMargin;

        public StyledButton()
        {
            DataContext = this;
            InitializeComponent();
            InitialSetup();
            SaveInitialMargin();
        }

        // Data Setters
        public void SetColors(Color defaultColor, Color highlightedColor)
        {
            DefaultColor = new SolidColorBrush(defaultColor);
            HighlightColor = new SolidColorBrush(highlightedColor);
            SetColorToDefault();
        }
        
        // UI content Updaters
        private void InitialSetup()
        {
            ButtonText.Foreground = new SolidColorBrush(Color.FromRgb(61, 51, 51));
            SetColorToDefault();
        }
        private void UpdateButtonText()
        {
            ButtonText.Text = Text;
        }
        private void SetColorToDefault()
        {
            ButtonBackground.Fill = DefaultColor;
        }
        private void SetColorToHighlighted()
        {
            ButtonBackground.Fill = HighlightColor;
        }
        
        // Animations
        private void SaveInitialMargin()
        {
            initialMargin = new Thickness(MainBody.Margin.Left, MainBody.Margin.Top, MainBody.Margin.Right,
                MainBody.Margin.Bottom);
        }
        private void MoveUp()
        {
            MainBody.Margin = new Thickness(MainBody.Margin.Left, initialMargin.Top - 5, MainBody.Margin.Right, 
                initialMargin.Bottom + 5);
        }
        private void MoveDown()
        {
            MainBody.Margin = new Thickness(MainBody.Margin.Left, initialMargin.Top, MainBody.Margin.Right, initialMargin.Bottom);
        }

        // UI event handlers
        private void BackGround_OnMouseEnter(object sender, MouseEventArgs e)
        {
            SetColorToHighlighted();
            MoveUp();
            MouseIsOn = true;
        }
        private void BackGround_OnMouseLeave(object sender, MouseEventArgs e)
        {
            SetColorToDefault();
            MoveDown();
            MouseIsOn = false;
        }
        private void BackGround_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MoveDown();
        }
        private void BackGround_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            if (!MouseIsOn) return;
            
            Click?.Invoke();
            MoveUp();
        }
    }
}