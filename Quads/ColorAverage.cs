using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Quads
{
    public struct ColorAverage
    {
        private const double bWeight = 0.0722;

        private const double gWeight = 0.7152;

        private const double rWeight = 0.2126;

        public Color Color { get; private set; }

        public double Error { get; private set; }

        public ColorAverage(Color color, double error)
            : this()
        {
            Color = color;
            Error = error;
        }

        public ColorAverage(params ColorAverage[] contributors)
            : this()
        {
            var colors = contributors.Select(contributor => contributor.Color);

            byte a = (byte)(colors.Sum(color => color.A) / contributors.Length);
            byte r = (byte)(colors.Sum(color => color.R) / contributors.Length);
            byte g = (byte)(colors.Sum(color => color.G) / contributors.Length);
            byte b = (byte)(colors.Sum(color => color.B) / contributors.Length);

            Color = Color.FromArgb(a, r, g, b);
            Error = (getColorError(Color, colors.ToArray()) + contributors.Sum(contributor => contributor.Error));
        }

        private static double getColorError(Color average, params Color[] contributors)
        {
            //double aError = getColorPartError(average.A, contributors.Select(color => color.A).ToArray());
            double rError = getColorPartError(average.R, contributors.Select(color => color.R).ToArray());
            double gError = getColorPartError(average.G, contributors.Select(color => color.G).ToArray());
            double bError = getColorPartError(average.B, contributors.Select(color => color.B).ToArray());

            return (rError * rWeight) + (gError * gWeight) + (bError * bWeight);
        }

        private static double getColorPartError(byte average, byte[] contributors)
        {
            double error = 0;
            foreach (var contributor in contributors)
            {
                error += Math.Pow((double)average - (double)contributor, 2);
            }

            return Math.Sqrt(error);
        }
    }
}