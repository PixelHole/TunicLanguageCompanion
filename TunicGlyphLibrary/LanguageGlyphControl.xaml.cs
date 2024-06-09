using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using TunicGlyphLibrary.Library;

namespace TunicGlyphLibrary
{
    public partial class LanguageGlyphControl : UserControl
    {
        private readonly Glyph glyph = new Glyph();
        private static readonly Brush HighlightColor = Brushes.WhiteSmoke;
        private static readonly Brush ActiveBrush = Brushes.Gainsboro;
        private static readonly Brush InactiveBrush = Brushes.Gray;
        public LanguageGlyphControl()
        {
            InitializeComponent();
        }
        public LanguageGlyphControl(Glyph glyph) : this()
        {
            this.glyph = glyph;
        }
        
        private void SwitchGlyphLine(int index)
        {
            glyph.SwitchValue(index);
        }
        private void UpdateGlyphPart(Rectangle part)
        {
            if (glyph.GetValue(TagToIndex(part.Tag)))
            {
                part.Fill = ActiveBrush;
                return;
            }

            part.Fill = InactiveBrush;
        }
        private void GlyphPartClick(object sender, MouseButtonEventArgs e)
        {
            if (!(sender is Rectangle part)) return;
            SwitchGlyphLine(TagToIndex(part.Tag));
            UpdateGlyphPart(part);
        }
        private void GlyphPartMouseLeave(object sender, MouseEventArgs e)
        {
            if (!(sender is Rectangle part)) return;
            UpdateGlyphPart(part);
            Panel.SetZIndex(part, 0);
        }
        private void GlyphPartMouseEnter(object sender, MouseEventArgs e)
        {
            if (!(sender is Rectangle part)) return;
            Panel.SetZIndex(part, 20);
            if (glyph.GetValue(TagToIndex(part.Tag)))
            {
                part.Fill = HighlightColor;
                return;
            }

            part.Fill = ActiveBrush;
        }

        private int TagToIndex(object tag) => int.Parse(tag.ToString());
    }
}
