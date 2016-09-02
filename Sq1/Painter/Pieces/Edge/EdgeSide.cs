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
           SetCoord(properties.ShortFaceDist, piecePosition);
           SetCoord(properties.ShortSideDist, piecePosition);
           SetCoord(properties.ShortSideDist, piecePosition + 2);
           SetCoord(properties.ShortFaceDist, piecePosition + 2);
        }
    }
}
