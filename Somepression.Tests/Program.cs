using System;

namespace Somepression.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            BitmapBGRA bitmap = new BitmapBGRA(2, 2);
            bitmap.WriteToFile("test.bmp");
        }
    }
}
