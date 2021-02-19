using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace qpv_plugins
{
    public static class BlurMan
    {
        public static unsafe Bitmap ProcessBlur(Bitmap image, Rectangle rectangle, Int32 blurSize) 
        {
            int width = image.Width;
            int height = image.Height;
            Bitmap blurred = new Bitmap(width, height);

            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(
                    image, 
                    new Rectangle(0, 0, width, height),
                    new Rectangle(0, 0, width, height), 
                    GraphicsUnit.Pixel
                );

            BitmapData blurredData = blurred.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite, blurred.PixelFormat);

            int bitsPerPixel = Image.GetPixelFormatSize(blurred.PixelFormat);

            byte* scan0 = (byte*)blurredData.Scan0.ToPointer();

            var options = new ParallelOptions();
            int maxCore = Environment.ProcessorCount - 1;
            options.MaxDegreeOfParallelism = maxCore > 0 ? maxCore : 1;

            Parallel.For(rectangle.X, rectangle.Width, options, xx =>
            {
                for (int yy = rectangle.Y; yy < rectangle.Height; yy++)
                {
                    int avgR = 0, avgG = 0, avgB = 0;
                    int blurPixelCount = 0;

                    for (int x = xx; (x < xx + blurSize && x < width); x++)
                    {
                        for (int y = yy; (y < yy + blurSize && y < height); y++)
                        {
                            byte* data = scan0 + y * blurredData.Stride + x * bitsPerPixel / 8;

                            avgB += data[0]; 
                            avgG += data[1];
                            avgR += data[2]; 

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    for (int x = xx; x < xx + blurSize && x < width && x < rectangle.Width; x++)
                    {
                        for (int y = yy; y < yy + blurSize && y < height && y < rectangle.Height; y++)
                        {
                            byte* data = scan0 + y * blurredData.Stride + x * bitsPerPixel / 8;

                            data[0] = (byte)avgB;
                            data[1] = (byte)avgG;
                            data[2] = (byte)avgR;
                        }
                    }
                };
            });
            blurred.UnlockBits(blurredData);
            return blurred;
        }

        public unsafe static Bitmap ProcessBlurOld(Bitmap image, Rectangle rectangle, Int32 blurSize)
        {
            Bitmap blurred = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = Graphics.FromImage(blurred))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            // Lock the bitmap's bits
            BitmapData blurredData = blurred.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, blurred.PixelFormat);

            // Get bits per pixel for current PixelFormat
            int bitsPerPixel = Image.GetPixelFormatSize(blurred.PixelFormat);

            // Get pointer to first line
            byte* scan0 = (byte*)blurredData.Scan0.ToPointer();

            // look at every pixel in the blur rectangle
            for (int xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (int yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    int avgR = 0, avgG = 0, avgB = 0;
                    int blurPixelCount = 0;

                    // average the color of the red, green and blue for each pixel in the
                    // blur size while making sure you don't go outside the image bounds
                    for (int x = xx; (x < xx + blurSize && x < image.Width); x++)
                    {
                        for (int y = yy; (y < yy + blurSize && y < image.Height); y++)
                        {
                            // Get pointer to RGB
                            byte* data = scan0 + y * blurredData.Stride + x * bitsPerPixel / 8;

                            avgB += data[0]; // Blue
                            avgG += data[1]; // Green
                            avgR += data[2]; // Red

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;

                    // now that we know the average for the blur size, set each pixel to that color
                    for (int x = xx; x < xx + blurSize && x < image.Width && x < rectangle.Width; x++)
                    {
                        for (int y = yy; y < yy + blurSize && y < image.Height && y < rectangle.Height; y++)
                        {
                            // Get pointer to RGB
                            byte* data = scan0 + y * blurredData.Stride + x * bitsPerPixel / 8;

                            // Change values
                            data[0] = (byte)avgB;
                            data[1] = (byte)avgG;
                            data[2] = (byte)avgR;
                        }
                    }
                }
            }

            // Unlock the bits
            blurred.UnlockBits(blurredData);

            return blurred;
        }

        public static Bitmap ProcessPixelateOld(Bitmap image, Rectangle rectangle, Int32 pixelateSize)
        {
            Bitmap pixelated = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = System.Drawing.Graphics.FromImage(pixelated))
                graphics.DrawImage(image, new System.Drawing.Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            // look at every pixel in the rectangle while making sure we're within the image bounds
            for (Int32 xx = rectangle.X; xx < rectangle.X + rectangle.Width && xx < image.Width; xx += pixelateSize)
            {
                for (Int32 yy = rectangle.Y; yy < rectangle.Y + rectangle.Height && yy < image.Height; yy += pixelateSize)
                {
                    Int32 offsetX = pixelateSize / 2;
                    Int32 offsetY = pixelateSize / 2;

                    // make sure that the offset is within the boundry of the image
                    while (xx + offsetX >= image.Width) offsetX--;
                    while (yy + offsetY >= image.Height) offsetY--;

                    // get the pixel color in the center of the soon to be pixelated area
                    Color pixel = pixelated.GetPixel(xx + offsetX, yy + offsetY);

                    // for each pixel in the pixelate size, set it to the center color
                    for (Int32 x = xx; x < xx + pixelateSize && x < image.Width; x++)
                        for (Int32 y = yy; y < yy + pixelateSize && y < image.Height; y++)
                            pixelated.SetPixel(x, y, pixel);
                }
            }

            return pixelated;
        }
    }
}
