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
        }

        // Main Window Event Handlers
        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            SaveFileManager.LoadAllWords();
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
    }
}