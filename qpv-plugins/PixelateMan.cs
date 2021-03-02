using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace qpv_plugins
{
	public static class PixelateMan
	{
		public static Bitmap ProcessPixelate(Bitmap bmp, int pixelateSize, Rectangle selection)
		{
			Bitmap temp = new Bitmap(bmp);
			int width = bmp.Width;
			int height = bmp.Height;
			if (selection.Width == 0) selection.Width = width;
			if (selection.Height == 0) selection.Height = height;

			BitmapData bmpData = temp.LockBits(new Rectangle(Point.Empty, bmp.Size), ImageLockMode.ReadOnly, temp.PixelFormat);
			int bpp = (temp.PixelFormat == PixelFormat.Format32bppArgb) ? 4 : 3;
			int size = bmpData.Stride * bmpData.Height;
			byte[] data = new byte[size];
			Marshal.Copy(bmpData.Scan0, data, 0, size);

			for (int x = selection.X; x < selection.X + selection.Width && x < width; x += pixelateSize)	
			{
				for (int y = selection.Y; y < selection.Y + selection.Height && y < height; y += pixelateSize)
				{
					int offsetX = pixelateSize / 2;
					int offsetY = pixelateSize / 2;

					while (x + offsetX >= width) offsetX--;
					while (y + offsetY >= height) offsetY--;

					int index = (y + offsetY) * bmpData.Stride + (x + offsetX) * bpp;
					Parallel.For(x, x + pixelateSize, x2 =>
					{
						if (x2 < width)
						{
							Parallel.For(y, y + pixelateSize, y2 =>
							{
								if (y2 < height)
								{
									int index2 = y2 * bmpData.Stride + x2 * bpp;
									data[index2 + 0] = (byte)data[index + 0];
									data[index2 + 1] = (byte)data[index + 1];
									data[index2 + 2] = (byte)data[index + 2];
								}
							});
						}
					});
				}
			}
			Marshal.Copy(data, 0, bmpData.Scan0, data.Length);
			temp.UnlockBits(bmpData);
			return temp;
		}
	}
}
