using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace qpv_plugins
{
	public static class InvertMan
	{
        public static Bitmap ProcessInvert(Bitmap bmp, Rectangle selection)
        {
            Bitmap temp = new Bitmap(bmp);
            if (selection.Width == 0) selection.Width = bmp.Width;
            if (selection.Height == 0) selection.Height = bmp.Height;

            BitmapData bmpData = temp.LockBits(new Rectangle(Point.Empty, bmp.Size), ImageLockMode.ReadOnly, temp.PixelFormat);
            int bpp = (temp.PixelFormat == PixelFormat.Format32bppArgb) ? 4 : 3;
            int size = bmpData.Stride * bmpData.Height;
            byte[] data = new byte[size];
            Marshal.Copy(bmpData.Scan0, data, 0, size);

            Parallel.For(selection.Y, selection.Y + selection.Height, y =>
            {
                for (int x = selection.X; x < selection.X + selection.Width; x++)
                {
                    int index = y * bmpData.Stride + x * bpp;
                    data[index + 0] = (byte)(255 - data[index + 0]);
                    data[index + 1] = (byte)(255 - data[index + 1]);
                    data[index + 2] = (byte)(255 - data[index + 2]);
                };
            });
            Marshal.Copy(data, 0, bmpData.Scan0, data.Length);
            temp.UnlockBits(bmpData);
            return temp;
        }
    }
}
