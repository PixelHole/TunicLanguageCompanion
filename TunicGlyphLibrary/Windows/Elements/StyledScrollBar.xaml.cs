using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class StyledScrollBar : UserControl
    {
        private bool AllowDrag = false;

        private double MaxY, MinY;
        
        public StyledScrollBar()
        {
            InitializeComponent();
            MouseCapture.MouseMove += OnMouseMovement;
            MouseCapture.MouseUp += OnMouseLeftUp;
            CalculateSlideLimits();
        }

        private void CalculateSlideLimits()
        {
            Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            Arrange(new Rect(0, 0, DesiredSize.Width, DesiredSize.Height));
            MaxY = ActualHeight * 2 - 20;
            MinY = 5;
            Canvas.SetTop(SliderKnob, MinY);
        }

        private void MoveSlider(double mouseY)
        {
            double destination = mouseY - 20d;
            if (!AllowDrag || destination > MaxY || destination < MinY)
            {
                return;
            }

            Canvas.SetTop(SliderKnob, destination);
        }

        private void OnMouseMovement(MouseEventArgs e)
        {
            var mousePos = e.GetPosition(this);
            MoveSlider(mousePos.Y);
        }
        private void OnMouseLeftUp(object sender, MouseEventArgs e)
        {
            AllowDrag = false;
        }
        
        private void SliderKnob_OnMouseEnter(object sender, MouseEventArgs e)
        {
            
        }
        private void SliderKnob_OnMouseLeave(object sender, MouseEventArgs e)
        {
            
        }
        private void SliderKnob_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            AllowDrag = true;
        }
        private void SliderKnob_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            AllowDrag = false;
        }
    }
}