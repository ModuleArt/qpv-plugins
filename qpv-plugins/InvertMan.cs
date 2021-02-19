using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace qpv_plugins
{
	public static class InvertMan
	{
        public static Bitmap ProcessInvert(Bitmap bmp)
        {
            Bitmap temp = null;
            temp = new Bitmap(bmp);
            int height = bmp.Height;
            int width = bmp.Width;
            Rectangle rect = new Rectangle(Point.Empty, bmp.Size);

            BitmapData bmpData = temp.LockBits(rect, ImageLockMode.ReadOnly, temp.PixelFormat);
            int bpp = (temp.PixelFormat == PixelFormat.Format32bppArgb) ? 4 : 3;
            int size = bmpData.Stride * bmpData.Height;
            byte[] data = new byte[size];
            System.Runtime.InteropServices.Marshal.Copy(bmpData.Scan0, data, 0, size);

            Parallel.For(0, height, y =>
            {
                for (int x = 0; x < width; x++)
                {
                    int index = y * bmpData.Stride + x * bpp;

                    data[index + 0] = (byte)(255 - data[index + 0]);
                    data[index + 1] = (byte)(255 - data[index + 1]);
                    data[index + 2] = (byte)(255 - data[index + 2]);
                };

            });
            System.Runtime.InteropServices.Marshal.Copy(data, 0, bmpData.Scan0, data.Length);
            temp.UnlockBits(bmpData);
            return temp;
        }
    }
}
