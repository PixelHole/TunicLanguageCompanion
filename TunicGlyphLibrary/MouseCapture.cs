using System.Windows.Input;

namespace TunicGlyphLibrary
{
    public static class MouseCapture
    {
        public delegate void MouseMoveHandler(MouseEventArgs e);
        public delegate void MouseUpHandler(object sender, MouseEventArgs e);

        public static event MouseMoveHandler MouseMove;
        public static event MouseUpHandler MouseUp;

        public static void CaptureMovement(object sender, MouseEventArgs e)
        {
            MouseMove?.Invoke(e);
        }
        public static void CaptureMouseUp(object sender, MouseEventArgs e)
        {
            MouseUp?.Invoke(sender, e);
        }
    }
}