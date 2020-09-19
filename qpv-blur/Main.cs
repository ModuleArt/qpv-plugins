using System.Drawing;

namespace qpv_blur
{
	class Main
	{
		public Bitmap blur(Bitmap bmp, string path, bool darkMode, string language)
		{
			Bitmap newBmp = new Bitmap(bmp.Width, bmp.Height);

			using (var graphics = Graphics.FromImage(newBmp))
			{
				graphics.Clear(Color.Red);
			}

			return newBmp;
		}
	}
}
