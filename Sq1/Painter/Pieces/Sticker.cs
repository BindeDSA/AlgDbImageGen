using System.Collections.Generic;
using PuzzleImageGenerator.Shared;
using PuzzleImageGenerator.Shared.Helpers;

namespace PuzzleImageGenerator.Sq1.Painter.Pieces
{
    public abstract class Sticker
    {
        protected List<CoordPair> _coords = new List<CoordPair>();
        public CoordPair[] Coords { get { return _coords.ToArray(); } }
        public string Color;
        public double PiecePosition;
        public Sq1ImageProp Properties;

        public Sticker(int piecePosition, char color, Sq1ImageProp properties)
        {
            Color = ColorHelper.GetColorNameFromCharacter(color);
            PiecePosition = piecePosition;
            Properties = properties;
        }

        public void SetCoordFromPolar(double dist, double coordAngle) {
            CoordPair center = new CoordPair();
            double angle = 0;

            if (PiecePosition < 24)
            {
                center =  new CoordPair(Properties.ImageLength / 2, Properties.ImageLength / 2);
                angle = ((coordAngle + 1) % 24) * Properties.AngleUnits;
            } else
            {
                center = new CoordPair(Properties.ImageLength / 2, Properties.ImageLength / 2, Properties.XOffset, Properties.YOffset);
                var configs = (Sq1ImageConfiguration) Properties.Configs;
                angle = (coordAngle + 11) % 24 * Properties.AngleUnits * -1;
            }

            _coords.Add(CoordPair.CartesianFromPolar(dist, angle, center));
        }
    }
}
