using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Quads
{
    public struct Pixel
    {
        public Color Color { get; private set; }

        public double X { get; private set; }

        public double Y { get; private set; }

        public Pixel(double x, double y, Color color)
            : this()
        {
            X = x;
            Y = y;
            Color = color;
        }
    }
}