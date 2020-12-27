using System;

namespace Somepression.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Pixel[] pixels = new Pixel[] { new Pixel { r = 255 }, new Pixel { r = 255 }, new Pixel { }, new Pixel { g = 255 } };
            ColoredRect[] rects = Somepression.LineToRects(pixels);
            Console.WriteLine(rects);
        }
    }
}
