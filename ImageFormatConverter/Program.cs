using System.Drawing;
using System.Drawing.Imaging;

namespace ImageFormatConverter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Load the image.
            Image image1 = Image.FromFile("test-image.png");

            // Save the image in JPEG format.
            image1.Save("test-image.jpg", ImageFormat.Jpeg);

            // Save the image in GIF format.
            image1.Save("test-image.gif", ImageFormat.Gif);
        }
    }
}