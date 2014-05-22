using SharpQuadTrees;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace Quads
{
    public partial class QuadForm : Form
    {
        private int iterations = 1;
        private QuadTreeNode<Pixel, ColorAverage> quadTree;

        public QuadForm()
        {
            InitializeComponent();
        }

        private Bitmap drawImage(QuadTreeNode<Pixel, ColorAverage> quadTree)
        {
            Bitmap result = new Bitmap((int)(quadTree.XMax - quadTree.XMin), (int)(quadTree.YMax - quadTree.YMin));

            using (Graphics graphics = Graphics.FromImage(result))
            {
                foreach (var leaf in quadTree.GetLeafs())
                {
                    //Console.WriteLine("(" + leaf.XMin + "/" + leaf.YMin + ") width:" + (leaf.XMax - leaf.XMin) + "; height:" + (leaf.YMax - leaf.YMin) + "; error:" + leaf.Average.Error);
                    graphics.FillRectangle(new SolidBrush(leaf.Average.Color), (int)Math.Floor(leaf.XMin), (int)Math.Floor(leaf.YMin), (int)Math.Ceiling(leaf.XMax - leaf.XMin - double.Epsilon), (int)Math.Ceiling(leaf.YMax - leaf.YMin - double.Epsilon));
                }
            }

            return result;
        }

        private IEnumerable<Pixel> generatePixelEnumerable(Bitmap image)
        {
            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    yield return new Pixel(x, y, image.GetPixel(x, y));
                }
            }
        }

        private void iterationsTextBox_TextChanged(object sender, EventArgs e)
        {
            int iterations;
            if (int.TryParse(iterationsTextBox.Text, out iterations))
            {
                if (iterations > 0)
                    this.iterations = iterations;
            }
        }

        private void openImageButton_Click(object sender, EventArgs e)
        {
            var result = openImageDialog.ShowDialog();

            if (result != System.Windows.Forms.DialogResult.OK)
                return;

            Bitmap image = new Bitmap(openImageDialog.FileName);

            resultImage.Image = image;

            quadTree = new QuadTreeLeaf<Pixel, ColorAverage>(new Controller(), generatePixelEnumerable(image).ToArray());

            Console.WriteLine("done");
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            var result = saveImageDialog.ShowDialog();

            if (result != System.Windows.Forms.DialogResult.OK)
                return;

            resultImage.Image.Save(saveImageDialog.FileName, ImageFormat.Png);
        }

        private void updateResultButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < iterations; i++)
                quadTree = quadTree.Split();

            resultImage.Image = drawImage(quadTree);
        }
    }
}