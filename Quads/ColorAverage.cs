using SharpColors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quads
{
    public struct ColorAverage
    {
        private const double bWeight = 0.0722;

        private const double gWeight = 0.7152;

        private const double rWeight = 0.2126;

        public CieLabColor Color { get; private set; }

        public double Error { get; private set; }

        public ColorAverage(IEnumerable<Pixel> pixels)
            : this()
        {
            var colors = pixels.Select(pixel => pixel.Color).ToArray();

            Color = getAverageColor(colors);
            Error = getColorError(Color, colors);
        }

        public ColorAverage(IEnumerable<ColorAverage> contributors)
            : this()
        {
            var colors = contributors.Select(contributor => contributor.Color);

            Color = getAverageColor(colors);
            Error = getColorError(Color, colors) + contributors.Sum(contributor => contributor.Error);
        }

        public ColorAverage(CieLabColor color, double error)
            : this()
        {
            Color = color;
            Error = error;
        }

        private static CieLabColor getAverageColor(IEnumerable<CieLabColor> colors)
        {
            double colorCount = colors.Count();
            double l = colors.Sum(color => color.L) / colorCount;
            double a = colors.Sum(color => color.A) / colorCount;
            double b = colors.Sum(color => color.B) / colorCount;

            return new CieLabColor((float)l, (float)a, (float)b);
        }

        private static double getColorError(CieLabColor average, IEnumerable<CieLabColor> contributors)
        {
            double error = 0d;

            foreach (CieLabColor contributor in contributors)
            {
                // sqrt( (l1 - l2)² + (a1 - a2)² + (b1 - b2)² )
                error += Math.Pow(average.L - contributor.L, 2) + Math.Pow(average.A - contributor.A, 2) + Math.Pow(average.B - contributor.B, 2);
            }

            return error;
        }

        private static double getColorPartError(double average, IEnumerable<double> contributors)
        {
            double error = 0;
            foreach (var contributor in contributors)
            {
                error += Math.Pow(average - contributor, 2);
            }

            return Math.Sqrt(error);
        }
    }
}