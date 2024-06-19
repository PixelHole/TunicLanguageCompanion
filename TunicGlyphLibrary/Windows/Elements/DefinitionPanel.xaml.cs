using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TunicGlyphLibrary.Windows.Elements
{
    public partial class DefinitionPanel : UserControl
    {
        public delegate void DeleteRequest(string definition);
        public event DeleteRequest OnDeleteRequest;
        
        private string _definition;
        public string Definition
        {
            get => _definition;
            set
            {
                _definition = value;
                UpdateDefinitionText();
                UpdatePanelLength();
            }
        }

        private Uri MidPanelUri = new Uri(@"../../Resources/DefBoxMid.png", UriKind.Relative);

        public DefinitionPanel()
        {
            DataContext = this;
            InitializeComponent();
        }
        public DefinitionPanel(string definition) : this()
        {
            Definition = definition;
        }

        private void UpdateDefinitionText()
        {
            DefinitionText.Text = Definition;
        }
        private void UpdatePanelLength()
        {
            int backgroundCount = (int)Math.Ceiling(MeasureString(DefinitionText).Width / 25d);
            int iterationCount = backgroundCount - BackgroundStack.Children.Count;
            
            for (int i = 0; i <  iterationCount; i++)
            {
                var panel = new Image
                {
                    Source = new BitmapImage(MidPanelUri),
                };
                BackgroundStack.Children.Add(panel);
            }
            
            for (int i = 0; i < BackgroundStack.Children.Count - backgroundCount; i++)
            {
                BackgroundStack.Children.RemoveAt(i);
            }
        }

        private void CloseBtn_OnClick()
        {
            OnDeleteRequest?.Invoke(Definition);
        }
        
        private Size MeasureString(TextBlock textBox)
        {
            var formattedText = new FormattedText(
                textBox.Text,
                CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                new Typeface(textBox.FontFamily, textBox.FontStyle, textBox.FontWeight, textBox.FontStretch),
                textBox.FontSize,
                Brushes.Black,
                new NumberSubstitution(),
                VisualTreeHelper.GetDpi(textBox).PixelsPerDip);

            return new Size(formattedText.Width, formattedText.Height);
        }
    }
}