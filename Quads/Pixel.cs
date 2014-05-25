using SharpColors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quads
{
    public struct Pixel
    {
        public CieLabColor Color { get; private set; }

        public double X { get; private set; }

        public double Y { get; private set; }

        public Pixel(double x, double y, CieLabColor color)
            : this()
        {
            X = x;
            Y = y;
            Color = color;
        }
    }
}