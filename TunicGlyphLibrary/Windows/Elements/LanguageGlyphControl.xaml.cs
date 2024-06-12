using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using TunicGlyphLibrary.Library;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class LanguageGlyphControl : UserControl
    {
        public bool EditingEnabled { get; set; } = true;
        public bool IsHighlighted { get; private set; } = false;

        private Glyph _glyph = new Glyph();

        public Glyph Glyph
        {
            get => _glyph;
            
            set
            {
                _glyph = value;
                UpdateAllGlyphLines();
            }
        }
        public Brush HighlightBrush { get; set; } = Brushes.WhiteSmoke;
        public Brush ActiveBrush { get; set; } = Brushes.Gainsboro;
        public Brush InactiveBrush { get; set; } = Brushes.Gray;
        public Brush BackgroundBrush { get; set; } = Brushes.Cornsilk;


        public LanguageGlyphControl(Glyph glyph, bool editingEnabled, Brush activeBrush, Brush inactiveBrush,
            Brush highlightBrush, Brush backgroundBrush)
        {
            DataContext = this;
            InitializeComponent();
            
            EditingEnabled = editingEnabled;
            SetLineColorPreset(activeBrush, inactiveBrush, highlightBrush, backgroundBrush);
            Glyph = glyph;
            UnHighlightGlyph();
        }
        public LanguageGlyphControl(Glyph glyph, bool editingEnabled, Brush activeBrush, Brush inactiveBrush) : 
            this(glyph, editingEnabled, activeBrush, inactiveBrush, Brushes.WhiteSmoke, Brushes.Cornsilk)
        {
            
        }
        public LanguageGlyphControl(Glyph glyph, bool editingEnabled = false) : this(glyph, editingEnabled, Brushes.Gainsboro, Brushes.Gray)
        {
            
        }
        public LanguageGlyphControl() : this(new Glyph())
        {
            
        }

        
        public void SetLineColorPreset(Brush activeBrush, Brush inactiveBrush, Brush highlightBrush,
            Brush backgroundBrush)
        {
            ActiveBrush = activeBrush;
            InactiveBrush = inactiveBrush;
            HighlightBrush = highlightBrush;
            BackgroundBrush = backgroundBrush;
        }

        public void HighlightGlyph()
        {
            IsHighlighted = true;
            GlyphHighLight.Fill = BackgroundBrush;
            GlyphHighLight.Visibility = Visibility.Visible;
        }
        public void UnHighlightGlyph()
        {
            IsHighlighted = false;
            GlyphHighLight.Visibility = Visibility.Hidden;
        }

        private void UpdateAllGlyphLines()
        {
            // you gotta do this manually every time.
            UpdateGlyphLine(TopTopLeft);
            UpdateGlyphLine(TopMiddle);
            UpdateGlyphLine(TopTopRight);
            
            UpdateGlyphLine(TopLeft);
            UpdateGlyphLine(TopBottomLeft);
            UpdateGlyphLine(TopBottomRight);
            
            UpdateGlyphLine(BottomTopLeft);
            UpdateGlyphLine(BottomMiddle);
            UpdateGlyphLine(BottomTopRight);
            
            UpdateGlyphLine(BottomLeft);
            UpdateGlyphLine(BottomBottomLeft);
            UpdateGlyphLine(BottomBottomRight);
            UpdateGlyphLine(Circle);
        }
        private void SwitchGlyphLine(int index)
        {
            Glyph.SwitchValue(index);
        }
        private void UpdateGlyphLine(Shape line)
        {
            if (Glyph.GetValue(TagToIndex(line.Tag)))
            {
                SetGlyphLineColor(line, ActiveBrush);

                return;
            }

            SetGlyphLineColor(line, InactiveBrush);
        }
        private static void SetGlyphLineColor(Shape line, Brush color)
        {
            switch (line)
            {
                case Rectangle _:
                    line.Fill = color;
                    break;
                case Ellipse _:
                    line.Stroke = color;
                    break;
            }
        }
        
        private void GlyphPartClick(object sender, MouseButtonEventArgs e)
        {
            if (!EditingEnabled) return;
            if (!(sender is Shape part)) return;
            SwitchGlyphLine(TagToIndex(part.Tag));
            UpdateGlyphLine(part);
        }
        private void GlyphPartMouseLeave(object sender, MouseEventArgs e)
        {
            if (!(sender is Shape part)) return;
            UpdateGlyphLine(part);
            Panel.SetZIndex(part, 10);
        }
        private void GlyphPartMouseEnter(object sender, MouseEventArgs e)
        {
            if (!(sender is Shape part) || !EditingEnabled) return;
            Panel.SetZIndex(part, 20);
            
            if (Glyph.GetValue(TagToIndex(part.Tag)))
            {
                SetGlyphLineColor(part, HighlightBrush);
                return;
            }

            SetGlyphLineColor(part, ActiveBrush);
        }

        private static int TagToIndex(object tag) => int.Parse(tag.ToString());
    }
}
