using System.Drawing;
using System.Windows.Forms;

namespace qpv_plugins
{
    public class Main
    {
        BlurRegionForm brf;

        public Bitmap blur(Bitmap bmp, string path, bool darkMode, string language, bool alwaysOnTop, Rectangle selection)
        {
            if (brf == null || brf.IsDisposed)
            {
                brf = new BlurRegionForm(bmp, selection);
            }
            brf.TopMost = alwaysOnTop;

            if (brf.ShowDialog() == DialogResult.OK)
            {
                return brf.Result;
            }
            else
            {
                return null;
            }
        }

        public Bitmap invert(Bitmap bmp, string path, bool darkMode, string language, bool alwaysOnTop, Rectangle selection)
        {
            return InvertMan.ProcessInvert(bmp, selection);
        }

        public Bitmap grayscale(Bitmap bmp, string path, bool darkMode, string language, bool alwaysOnTop, Rectangle selection)
        {
            return GrayscaleMan.ProcessGrayscale(bmp, selection);
        }

        public static Bitmap rainbow(Bitmap bmp, string path, bool darkMode, string language, bool alwaysOnTop, Rectangle selection)
        {
            return RainbowMan.ProcessRainbow(bmp, selection, 5);
        }

        public Bitmap screenshot(Bitmap bmp, string path, bool darkMode, string language, bool alwaysOnTop, Rectangle selection)
        {
            System.Threading.Thread.Sleep(250);

            Bitmap screenshot = new Bitmap(Screen.FromPoint(Cursor.Position).Bounds.Width, Screen.FromPoint(Cursor.Position).Bounds.Height);
            using (Graphics g = Graphics.FromImage(screenshot))
            {
                g.CopyFromScreen(
                    Screen.FromPoint(Cursor.Position).Bounds.X,
                    Screen.FromPoint(Cursor.Position).Bounds.Y,
                    0, 0,
                    Screen.FromPoint(Cursor.Position).Bounds.Size
                );
            }
            return screenshot;
        }
    }
}
