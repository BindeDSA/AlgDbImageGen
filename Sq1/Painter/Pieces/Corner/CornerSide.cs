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
           SetCoord(properties.LongFaceDist, piecePosition + 2);
           SetCoord(properties.LongSideDist, piecePosition + 2);
           var shortOffest = type == CornerSideType.First ? 0 : 4; 
           SetCoord(properties.ShortSideDist, piecePosition + shortOffest);
           SetCoord(properties.ShortFaceDist, piecePosition + shortOffest);
        }
        public enum CornerSideType { First, Second }
    }
}
