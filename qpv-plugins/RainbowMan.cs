using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace qpv_plugins
{
	public static class RainbowMan
	{
		public static Bitmap ProcessRainbow(Bitmap bmp, Rectangle selection, int count)
		{
            int raz = bmp.Height / count;
            Bitmap temp = new Bitmap(bmp);
            if (selection.Width == 0) selection.Width = bmp.Width;
            if (selection.Height == 0) selection.Height = bmp.Height;

            BitmapData bmpData = temp.LockBits(new Rectangle(Point.Empty, bmp.Size), ImageLockMode.ReadOnly, temp.PixelFormat);
            int bpp = (temp.PixelFormat == PixelFormat.Format32bppArgb) ? 4 : 3;
            int size = bmpData.Stride * bmpData.Height;
            byte[] data = new byte[size];
            Marshal.Copy(bmpData.Scan0, data, 0, size);

            var options = new ParallelOptions();
            int maxCore = Environment.ProcessorCount - 1;
            options.MaxDegreeOfParallelism = maxCore > 0 ? maxCore : 1;

            Parallel.For(selection.Y, selection.Y + selection.Height, options, y =>
            {
                for (int x = selection.X; x < selection.X + selection.Width; x++)
                {
                    int index = y * bmpData.Stride + x * bpp;

                    if (y < (raz)) data[index + 2] = (byte)(data[index + 2] / 5);
                    else if (y < (raz * 2)) data[index + 1] = (byte)(data[index + 1] / 5);
                    else if (y < (raz * 3)) data[index] = (byte)(data[index] / 5);
                    else if (y < (raz * 4))
                    {
                        data[index + 2] = (byte)(data[index + 2] / 5);
                        data[index] = (byte)(data[index] / 5);
                    }
                    else
                    {
                        data[index + 2] = (byte)(data[index + 2] / 5);
                        data[index + 1] = (byte)(data[index + 1] / 5);
                        data[index] = (byte)(data[index] / 5);
                    }
                };

            });
            Marshal.Copy(data, 0, bmpData.Scan0, data.Length);
            temp.UnlockBits(bmpData);
            return temp;
        }
	}
}
