﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using TunicGlyphLibrary.Library;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class LanguageWordControl : UserControl
    {
        private bool _mouseEditingEnabled = true;
        public bool MouseEditingEnabled
        {
            get => _mouseEditingEnabled;
            set
            {
                SetMouseEditingForGlyphControls();
                _mouseEditingEnabled = value;
            }
        }
        public bool KeyboardEditingEnabled { get; set; } = false;

        private List<Glyph> _glyphs = new List<Glyph>();
        public List<Glyph> Glyphs
        {
            get => _glyphs;
            set
            {
                _glyphs = value;
                UpdateGlyphControls();
            }
        }
        
        public Brush GlyphHighlightBrush { get; set; } = Brushes.WhiteSmoke;
        public Brush GlyphActiveBrush { get; set; } = Brushes.Gainsboro;
        public Brush GlyphInactiveBrush { get; set; } = Brushes.Gray;
        public Brush GlyphBackgroundBrush { get; set; } = Brushes.Cornsilk;
        
        public LanguageWordControl(List<Glyph> glyphs, Brush activeBrush, Brush inactiveBrush, Brush highlightBrush, Brush backgroundBrush)
        {
            GlyphActiveBrush = activeBrush;
            GlyphInactiveBrush = inactiveBrush;
            GlyphHighlightBrush = highlightBrush;
            GlyphBackgroundBrush = backgroundBrush;
            
            InitializeComponent();
            Glyphs = glyphs;
        }
        public LanguageWordControl(List<Glyph> glyphs, Brush ActiveBrush, Brush InactiveBrush) : this(glyphs,
            ActiveBrush, InactiveBrush, Brushes.White, Brushes.Cornsilk)
        {
            
        }
        public LanguageWordControl(List<Glyph> glyphs) : this(glyphs, Brushes.Gainsboro, Brushes.Gray)
        {
            
        }
        public LanguageWordControl() : this(new List<Glyph>())
        {
            
        }


        public void Clear()
        {
            Glyphs = new List<Glyph>(new[] { new Glyph() });
        }
        public void AddEmptyGlyph()
        {
            Glyph empty = new Glyph();
            Glyphs.Add(empty);
            CreateGlyphControl(empty);
        }
        public void RemoveLastGlyph()
        {
            if (Glyphs.Count < 2) return;
            RemoveLastGlyphControl();
            Glyphs.RemoveAt(Glyphs.Count - 1);
        }
        
        private void UpdateGlyphControls()
        {
            for (int i = 0; i < Glyphs.Count; i++)
            {
                if (glyphStack.Children.Count > i)
                {
                    UpdateGlyphControlContent(i);
                    continue;
                }
                CreateGlyphControl(Glyphs[i]);
            }

            for (int i = glyphStack.Children.Count - 1; i > Glyphs.Count - 1; i--)
            {
                RemoveGlyphControl(i);
            }
        }
        private void UpdateGlyphControlContent(int index)
        {
            if (!(glyphStack.Children[index] is LanguageGlyphControl glyphControl)) return;
            glyphControl.Glyph = Glyphs[index];
            glyphControl.EditingEnabled = MouseEditingEnabled;
        }
        private void CreateGlyphControl(Glyph glyph)
        {
            LanguageGlyphControl newControl = new LanguageGlyphControl(glyph, MouseEditingEnabled, GlyphActiveBrush,
                GlyphInactiveBrush, GlyphHighlightBrush, GlyphBackgroundBrush);
            
            if (glyphStack.Children.Count > 0)
            {
                // this is to make the glyphs look neater when arranged in a word.
                // the the -8 value is chosen it looked good this way
                newControl.Margin = new Thickness(-8, 0, 0, 0);
            }

            newControl.EditingEnabled = MouseEditingEnabled;

            glyphStack.Children.Add(newControl);
        }
        private void RemoveGlyphControl(int index)
        {
            glyphStack.Children.RemoveAt(index);
        }
        private void RemoveLastGlyphControl()
        {
            RemoveGlyphControl(Glyphs.Count - 1);
        }

        private void SetMouseEditingForGlyphControls()
        {
            foreach (var control in glyphStack.Children)
            {
                ((LanguageGlyphControl)control).EditingEnabled = MouseEditingEnabled;
            }
        }
    }
}