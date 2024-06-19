using System.Windows;

namespace TunicGlyphLibrary
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            MessageBox.Show("ye");
        }
    }
}