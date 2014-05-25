using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpColors;
using System;
using System.Drawing;

namespace Quads.Tests
{
    [TestClass]
    public class ColorConversion
    {
        [TestMethod]
        public void RGBAndXYZ()
        {
            for (byte r = 0; r <= 255; r += 10)
            {
                for (byte g = 0; g <= 255; g += 10)
                {
                    for (byte b = 0; b <= 255; b += 10)
                    {
                        Color rgbColor = Color.FromArgb(r, g, b);
                        Assert.AreEqual(rgbColor, XyzColor.FromRGB(rgbColor).ToRGB());
                    }
                }
            }
        }
    }
}