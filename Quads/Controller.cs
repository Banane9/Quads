using SharpQuadTrees;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Quads
{
    public class Controller : IQuadTreeController<Pixel, ColorAverage>
    {
        public ColorAverage NoContentAverage
        {
            get { return new ColorAverage(Color.Empty, 0); }
        }

        public ColorAverage AggregateAverages(ColorAverage itemAverage, ColorAverage aggregator)
        {
            return new ColorAverage(itemAverage, aggregator);
        }

        public ColorAverage GetAverage(Pixel item)
        {
            return new ColorAverage(item.Color, 0);
        }

        public double GetContentX(Pixel item)
        {
            return item.X;
        }

        public double GetContentY(Pixel item)
        {
            return item.Y;
        }

        public IEnumerable<QuadTreeNode<Pixel, ColorAverage>> GetNodesToSplit(IEnumerable<QuadTreeNode<Pixel, ColorAverage>> leafs)
        {
            if (leafs.Count() == 0)
                return Enumerable.Empty<QuadTreeNode<Pixel, ColorAverage>>();

            QuadTreeNode<Pixel, ColorAverage> highestErrorLeaf = leafs.ElementAt(0);

            foreach (var leaf in leafs.Skip(1))
            {
                if (leaf.Average.Error > highestErrorLeaf.Average.Error)
                    highestErrorLeaf = leaf;
            }

            return Enumerable.Repeat(highestErrorLeaf, 1);
        }

        public double GetSplitX(QuadTreeNode<Pixel, ColorAverage> leaf)
        {
            return leaf.XCenter;
        }

        public double GetSplitY(QuadTreeNode<Pixel, ColorAverage> leaf)
        {
            return leaf.YCenter;
        }
    }
}