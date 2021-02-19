using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace qpv_plugins
{
	public static class GrayscaleMan
	{
		public static Bitmap ProcessGrayscale(Bitmap bmp)
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

            var options = new ParallelOptions();
            int maxCore = Environment.ProcessorCount - 1;
            options.MaxDegreeOfParallelism = maxCore > 0 ? maxCore : 1;

            Parallel.For(0, height, options, y =>
            {
                for (int x = 0; x < width; x++)
                {
                    int index = y * bmpData.Stride + x * bpp;

                    int avg = (data[index + 0] + data[index + 1] + data[index + 2]) / 3;
                    data[index + 0] = (byte)(avg);
                    data[index + 1] = (byte)(avg);
                    data[index + 2] = (byte)(avg);
                };
            });
            System.Runtime.InteropServices.Marshal.Copy(data, 0, bmpData.Scan0, data.Length);
            temp.UnlockBits(bmpData);
            return temp;
        }
	}
}
