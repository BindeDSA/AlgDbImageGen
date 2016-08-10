using PuzzleImageGenerator.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PuzzleImageGenerator.Kilo.Painter.Piece.Sticker
{
    public abstract class Sticker
    {
        public string Color { get; private set; }
        private CoordPair _center;
        public Tuple<double, double>[] PolarInputs { get; protected set; } // <distance, angle>

        public CoordPair[] Coords
        {
            get
            {
                return PolarInputs.Select(polarCoord => CoordPair.CartesianFromPolar(polarCoord.Item1, polarCoord.Item2, _center))
                                  .ToArray();
            }
        }

        public Sticker(KiloImageProp prop, double angle, string color)
        {
            _center = prop.Center;
            Color = color;
        }
    }
}
