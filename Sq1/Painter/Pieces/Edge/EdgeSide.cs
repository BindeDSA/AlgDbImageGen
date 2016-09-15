using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Sq1.Painter.Pieces.Edge
{
    class EdgeSide : Sticker
    {
        public EdgeSide(int piecePosition, char color, Sq1ImageProp properties) : base(piecePosition, color, properties)
        {
           SetCoordFromPolar(properties.ShortFaceDist, piecePosition);
           SetCoordFromPolar(properties.ShortSideDist, piecePosition);
           SetCoordFromPolar(properties.ShortSideDist, piecePosition + 2);
           SetCoordFromPolar(properties.ShortFaceDist, piecePosition + 2);
        }
    }
}
