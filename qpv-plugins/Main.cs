using System.Drawing;
using System.Windows.Forms;

namespace qpv_plugins
{
	public class Main
	{
		BlurRegionForm brf;

        public Bitmap blur(Bitmap bmp, string path, bool darkMode, string language, bool alwaysOnTop)
        {
            if (brf == null || brf.IsDisposed)
            {
                brf = new BlurRegionForm(bmp);
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

        public Bitmap screenshot(Bitmap bmp, string path, bool darkMode, string language, bool alwaysOnTop)
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
