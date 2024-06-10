using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using TunicGlyphLibrary.Library;

namespace TunicGlyphLibrary
{
    public partial class LanguageGlyphControl : UserControl
    {
        public bool EditingEnabled { get; private set; } = true;
        public bool IsHighlighted { get; private set; } = false;

        private readonly Glyph glyph = new Glyph();
        private static Brush HighlightColor { get; set; } = Brushes.WhiteSmoke;
        private static Brush ActiveBrush { get; set; } = Brushes.Gainsboro;
        private static Brush InactiveBrush { get; set; } = Brushes.Gray;
        private static Brush GlyphHighlightBrush { get; set; } = Brushes.Cornsilk;
        
        
        public LanguageGlyphControl()
        {
            InitializeComponent();
        }
        public LanguageGlyphControl(Glyph glyph) : this()
        {
            this.glyph = glyph;
        }
        public LanguageGlyphControl(Glyph glyph, bool editingEnabled) : this(glyph)
        {
            EditingEnabled = editingEnabled;
        }

        public void HighlightGlyph()
        {
            IsHighlighted = true;
            GlyphHighLight.Fill = GlyphHighlightBrush;
            GlyphHighLight.Visibility = Visibility.Visible;
        }
        public void UnHighlightGlyph()
        {
            IsHighlighted = false;
            GlyphHighLight.Visibility = Visibility.Hidden;
        }
        
        private void SwitchGlyphLine(int index)
        {
            glyph.SwitchValue(index);
        }
        private void UpdateGlyphPart(Shape part)
        {
            if (glyph.GetValue(TagToIndex(part.Tag)))
            {
                SetPartColor(part, ActiveBrush);

                return;
            }

            SetPartColor(part, InactiveBrush);
        }
        private static void SetPartColor(Shape part, Brush color)
        {
            switch (part)
            {
                case Rectangle _:
                    part.Fill = color;
                    break;
                case Ellipse _:
                    part.Stroke = color;
                    break;
            }
        }
        
        private void GlyphPartClick(object sender, MouseButtonEventArgs e)
        {
            if (!EditingEnabled) return;
            if (!(sender is Shape part)) return;
            SwitchGlyphLine(TagToIndex(part.Tag));
            UpdateGlyphPart(part);
        }
        private void GlyphPartMouseLeave(object sender, MouseEventArgs e)
        {
            if (!(sender is Shape part)) return;
            UpdateGlyphPart(part);
            Panel.SetZIndex(part, 10);
        }
        private void GlyphPartMouseEnter(object sender, MouseEventArgs e)
        {
            if (!(sender is Shape part) || !EditingEnabled) return;
            Panel.SetZIndex(part, 20);
            
            if (glyph.GetValue(TagToIndex(part.Tag)))
            {
                SetPartColor(part, HighlightColor);
                return;
            }

            SetPartColor(part, ActiveBrush);
        }

        private static int TagToIndex(object tag) => int.Parse(tag.ToString());
    }
}
