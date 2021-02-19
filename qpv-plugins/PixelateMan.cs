using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace qpv_plugins
{
	public static class PixelateMan
	{
		public unsafe static Bitmap ProcessPixelate(Bitmap src, Size squareSize)
		{
			Bitmap bmp = (Bitmap)src.Clone();
			Bitmap TempBmp = (Bitmap)src.Clone();

			BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData TempBmpData = TempBmp.LockBits(new Rectangle(0, 0, TempBmp.Width, TempBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

			byte* ptr = (byte*)bmpData.Scan0.ToPointer();
			byte* TempPtr = (byte*)TempBmpData.Scan0.ToPointer();

			int stopAddress = (int)ptr + bmpData.Stride * bmpData.Height;

			int Val = 0;
			int i = 0, X = 0, Y = 0;
			int BmpStride = bmpData.Stride;
			int BmpWidth = bmp.Width;
			int BmpHeight = bmp.Height;
			int SqrWidth = squareSize.Width;
			int SqrHeight = squareSize.Height;
			int XVal = 0, YVal = 0;

			while ((int)ptr != stopAddress)
			{
				X = i % BmpWidth;
				Y = i / BmpWidth;

				XVal = X + (SqrWidth - X % SqrWidth);
				YVal = Y + (SqrHeight - Y % SqrHeight);

				if (XVal < 0 && XVal >= BmpWidth)
					XVal = 0;

				if (YVal < 0 && YVal >= BmpHeight)
					YVal = 0;

				if (XVal > 0 && XVal < BmpWidth && YVal > 0 && YVal < BmpHeight)
				{
					Val = (YVal * BmpStride) + (XVal * 3);

					ptr[0] = TempPtr[Val];
					ptr[1] = TempPtr[Val + 1];
					ptr[2] = TempPtr[Val + 2];
				}

				ptr += 3;
				i++;
			}

			bmp.UnlockBits(bmpData);
			TempBmp.UnlockBits(TempBmpData);

			return bmp;
		}
	}
}
