using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Sq1.Painter.Pieces.Corner
{
    class CornerSide : Sticker
    {
        public CornerSide(int piecePosition, char color, CornerSideType type, Sq1ImageProp properties) : base(piecePosition, color, properties)
        {
           SetCoordFromPolar(properties.LongFaceDist, piecePosition + 2);
           SetCoordFromPolar(properties.LongSideDist, piecePosition + 2);
           var shortOffest = type == CornerSideType.First ? 0 : 4; 
           SetCoordFromPolar(properties.ShortSideDist, piecePosition + shortOffest);
           SetCoordFromPolar(properties.ShortFaceDist, piecePosition + shortOffest);
        }
        public enum CornerSideType { First, Second }
    }
}
