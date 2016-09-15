using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Sq1.Painter.Pieces.Edge
{
    class EdgeFace : Sticker
    {
        public EdgeFace(int piecePosition, char color, Sq1ImageProp properties) : base(piecePosition, color, properties)
        {
           SetCoordFromPolar(0, piecePosition);
           SetCoordFromPolar(properties.ShortFaceDist, piecePosition);
           SetCoordFromPolar(properties.ShortFaceDist, piecePosition + 2);
        }
    }
}
