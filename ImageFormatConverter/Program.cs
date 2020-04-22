

using System.Drawing;


namespace ImageFormatConverter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Load the image.
            using (Image png = Image.FromFile("test-image.png"))
            {
                var withBackground = SetWhiteBackground(png);
                // Save the image in JPEG format.
                withBackground.Save("test-image.jpg");

                // Save the image in GIF format.
                withBackground.Save("test-image.gif");
                withBackground.Dispose();
            }
        }
        
        private static Image SetWhiteBackground(Image img)
        {
            Bitmap imgWithBackground = new Bitmap(img.Width, img.Height);
            Rectangle rect = new Rectangle(Point.Empty, img.Size);
            using (Graphics g = Graphics.FromImage(imgWithBackground))
            {
                g.Clear(Color.White);
                g.DrawImageUnscaledAndClipped(img, rect);
            }

            return imgWithBackground;
        }
    }
}