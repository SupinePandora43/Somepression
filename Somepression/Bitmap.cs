using System.IO;

namespace Somepression
{
    public class BitmapBGRA
    {
        public struct Pixel
        {
            public byte b;
            public byte g;
            public byte r;
            public byte a;
        }

        public uint width { get; }
        public uint height { get; }

        // for future
        //public int iwidth { get => (int)width; set { width = (uint)value; } }
        //public int iheight { get => (int)height; set { height = (uint)value; } }

        public byte[] pixels;

        public BitmapBGRA(uint width, uint height)
        {
            this.width = width;
            this.height = height;

            InitializePixels();
        }

        public void InitializePixels()
        {
            pixels = new byte[width * height];
        }
        public unsafe byte* ToBytePointer()
        {
            fixed (byte* pixelPtr = pixels)
            {
                return pixelPtr;
            }
        }

        public Pixel GetPixel(uint x, uint y)
        {
            return new Pixel
            {
                b = pixels[width * y * 4 + x * 4],
                g = pixels[width * y * 4 + x * 4 + 1],
                r = pixels[width * y * 4 + x * 4 + 2],
                a = pixels[width * y * 4 + x * 4 + 3]
            };
        }
        public void SetPixel(uint x, uint y, Pixel pixel)
        {
            pixels[width * y * 4 + x * 4] = pixel.b;
            pixels[width * y * 4 + x * 4 + 1] = pixel.g;
            pixels[width * y * 4 + x * 4 + 2] = pixel.r;
            pixels[width * y * 4 + x * 4 + 3] = pixel.a;
        }
    }
}
