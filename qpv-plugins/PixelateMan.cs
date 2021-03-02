using System;
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

			for (int x = selection.X; x < selection.X + selection.Width; x += pixelateSize)	
			{
				for (int y = selection.Y; y < selection.Y + selection.Height; y += pixelateSize)
				{
					Int32 offsetX = pixelateSize / 2;
					Int32 offsetY = pixelateSize / 2;

					while (x + offsetX >= width) offsetX--;
					while (y + offsetY >= height) offsetY--;

					int index = (y + offsetY) * bmpData.Stride + (x + offsetX) * bpp;
					for (Int32 x2 = x; x < x + pixelateSize && x2 < width; x2++)
					{
						for (Int32 y2 = y; y2 < y + pixelateSize && y2 < height; y2++)
						{
							int index2 = y2 * bmpData.Stride + x2 * bpp;
							data[index2 + 0] = (byte)data[index + 0];
							data[index2 + 1] = (byte)data[index + 1];
							data[index2 + 2] = (byte)data[index + 2];
						}
					}
				}
			}
			Marshal.Copy(data, 0, bmpData.Scan0, data.Length);
			temp.UnlockBits(bmpData);
			return temp;
		}


		//public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T>
		//{
		//	if (val.CompareTo(min) < 0) return min;
		//	else if (val.CompareTo(max) > 0) return max;
		//	else return val;
		//}

		//public static Bitmap ProcessPixelate(Bitmap bmp, int pixelSize, Rectangle selection)
		//{
		//	Bitmap temp = null;
		//	temp = new Bitmap(bmp);

		//	if (selection.Width == 0) selection.Width = bmp.Width;
		//	if (selection.Height == 0) selection.Height = bmp.Height;

		//	BitmapData bmpData = temp.LockBits(new Rectangle(Point.Empty, bmp.Size), ImageLockMode.ReadOnly, temp.PixelFormat);
		//	int bpp = (temp.PixelFormat == PixelFormat.Format32bppArgb) ? 4 : 3;
		//	int size = bmpData.Stride * bmpData.Height;
		//	byte[] data = new byte[size];
		//	Marshal.Copy(bmpData.Scan0, data, 0, size);

		//	int forEnd = selection.Width / (pixelSize / 2);
		//	Parallel.For(selection.X, selection.X + forEnd, x =>
		//	{
		//		int MinX = Clamp(x - (pixelSize / 2), selection.X + selection.Width, 0);
		//		int MaxX = Clamp(x + (pixelSize / 2), selection.Y + selection.Width, 0);
		//		for (int x = selection.X; x < selection.X + selection.Width; x += (pixelSize / 2))
		//		{
		//			int RValue = 0;
		//			int GValue = 0;
		//			int BValue = 0;
		//			int MinY = Clamp(y - (pixelSize / 2), selection.X + selection.Width, 0);
		//			int MaxY = Clamp(y + (pixelSize / 2), selection.X + selection.Width, 0);
		//			for (int x2 = MinX; x2 < MaxX; ++x2)
		//			{
		//				for (int y2 = MinY; y2 < MaxY; ++y2)
		//				{
		//					int index2 = y2 * bmpData.Stride + x2 * bpp;
		//					RValue += data[index2 + 0];
		//					GValue += data[index2 + 1];
		//					BValue += data[index2 + 2];
		//				}
		//			}
		//			RValue = RValue / (pixelSize * pixelSize);
		//			GValue = GValue / (pixelSize * pixelSize);
		//			BValue = BValue / (pixelSize * pixelSize);
		//			for (int x2 = MinX; x2 < MaxX; ++x2)
		//			{
		//				for (int y2 = MinY; y2 < MaxY; ++y2)
		//				{
		//					Console.WriteLine(2);
		//					int index2 = y2 * bmpData.Stride + x2 * bpp;
		//					data[index2 + 0] = (byte)(RValue);
		//					data[index2 + 1] = (byte)(GValue);
		//					data[index2 + 2] = (byte)(BValue);
		//				}
		//			}
		//		};
		//	});
		//	Marshal.Copy(data, 0, bmpData.Scan0, data.Length);
		//	temp.UnlockBits(bmpData);
		//	return temp;
		//}
	}
}
