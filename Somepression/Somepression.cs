using System;
using System.Collections.Generic;
using System.Linq;

namespace Somepression
{
    public class ColoredRect
    {
        public uint x, y;
        public uint width, height;
        public byte r, g, b, a;
    }
    public class Somepression
    {
        public static ColoredRect[] LineToRects(Pixel[] line)
        {
            List<ColoredRect> rects = new();
            for (uint i = 0; i < line.Length; i++)
            {
                Pixel pixel = line[i];
                if (rects.Count < 1)
                {
                    rects.Add(new ColoredRect { width = 1, a = pixel.a, r = pixel.r, g = pixel.g, b = pixel.b });
                }
                else
                {
                    ColoredRect rect = rects.Last();
                    if (rect.r == pixel.r && rect.g == pixel.g && rect.b == pixel.b)
                    {
                        rect.width++;
                    }
                    else
                    {
                        rect = new ColoredRect { x = rect.x + rect.width, width = 1, a = pixel.a, r = pixel.r, g = pixel.g, b = pixel.b };
                        rects.Add(rect);
                    }
                }
            }
            return rects.ToArray();
        }
    }
}
