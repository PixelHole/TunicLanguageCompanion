using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using TunicGlyphLibrary.Library;
using TunicGlyphLibrary.Windows.Elements;

namespace TunicGlyphLibrary.Windows
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            // this bit should be changed later
            WordEditor.OnGlyphSearchRequest += glyphs => WordLibraryList.FilterWordsByGlyphs(glyphs);
            WordEditor.OnDefinitionSearchRequest += words => WordLibraryList.FilterWordsByDefinitions(words);
        }

        // Main Window Event Handlers
        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            LoadingLayer.Visibility = Visibility.Visible;
            SaveFileManager.LoadAllWords();
            LoadingLayer.Visibility = Visibility.Hidden;
        }

        
        // Ribbon Event handlers
        private void MinimizeBtn_OnClick()
        {
            WindowState = WindowState.Minimized;
        }
        private void CloseBtn_OnClick()
        {
            SaveFileManager.SaveAllWords();
            Application.Current.Shutdown();
        }
        private void DragAreaMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}