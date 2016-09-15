using System;
using System.Collections.Generic;
using System.Linq;
using PuzzleImageGenerator.Shared;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Sq1.Painter.Pieces.Middle
{
    class MiddleSticker : Sticker
    {
        public MiddleSticker(int piecePosition, bool flipped, char color, Sq1ImageProp properties) : base(piecePosition, color, properties)
        {
            double width = properties.ImageLength / 3 * (flipped ? 1 : 2);
            if (properties.PlaceDOnRight)
            {

            }
            else
            {
                _coords.Add(new CoordPair(0, properties.ImageLength));
                _coords.Add(new CoordPair(0, properties.ImageLength + properties.FaceSpacer));
                _coords.Add(new CoordPair(properties.ImageLength / 3, properties.ImageLength + properties.FaceSpacer));
                _coords.Add(new CoordPair(0, properties.ImageLength));
                SetCoordFromPolar(properties.ShortFaceDist, piecePosition);
                SetCoordFromPolar(properties.ShortFaceDist, piecePosition + 2);
            }
        }
    }
}
