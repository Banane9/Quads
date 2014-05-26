## Quads

Computer art based on quadtrees.

The program targets an input image. The input image is split into four quadrants. Each quadrant is assigned an averaged color based on the colors in the input image. The quadrant with the largest error is split into its four children quadrants to refine the image. This process is repeated N times.

Uses the CIE Lab color space so that the averages make sense for human vision.

### Web Demo

A web-based version can be seen here:

http://www.michaelfogleman.com/static/quads/

### Still Samples

![Nordic Mountains](http://i.imgur.com/9Szm71Q.png)

![Zebra](http://i.imgur.com/lU1f0Yt.png)

### Animated Samples

![Nordic Mountains](http://puu.sh/91jMp.gif)

![Zebra](http://puu.sh/91jOJ.gif)

![Apple](http://puu.sh/91jHT.gif)

![Mario](http://puu.sh/91jNH.gif)

![Tomatoes](http://puu.sh/91jNH.gif)
