using System;

namespace PuzzleImageGenerator.Shared
{
    public struct CoordPair
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public CoordPair(
            double x, double y, 
            double xOffset = 0, double yOffset = 0)
        {
            X = x + xOffset;
            Y = y + yOffset;
        }

        public override string ToString()
        {
            return $"{X},{Y} ";
        }

        public static CoordPair CartesianFromPolar(double dist, double angle, CoordPair center)
        {
            var coordX = center.X - Math.Sin(angle) * dist;
            var coordY = center.Y + Math.Cos(angle) * dist;

            return new CoordPair(coordX, coordY);
        }
    }
}
