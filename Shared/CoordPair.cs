using System;

namespace PuzzleImageGenerator.Shared
{
    public struct CoordPair
    {
        double _x;
        double _y;

        public double X  {  get { return _x; }  }

        public double Y { get { return _y; } }

        public CoordPair(double x, double y, double xOffset = 0, double yOffset = 0)
        {
            _x = x + xOffset;
            _y = y + yOffset;
        }

        public override string ToString()
        {
            return String.Format("{0},{1} ", this.X, this.Y);
        }

        public static CoordPair CartesianFromPolar(double dist, double angle, CoordPair center)
        {

            var coordX = center.X - Math.Sin(angle) * dist;
            var coordY = center.Y + Math.Cos(angle) * dist;

            return new CoordPair(coordX, coordY);
        }
    }
}
