using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Sq1.Painter.Pieces.Corner
{
    public class CornerFace : Sticker
    {
        public CornerFace(int piecePosition, char color, Sq1ImageProp properties) : base(piecePosition, color, properties)
        {
            SetCoord(0, piecePosition);
            SetCoord(properties.ShortFaceDist, piecePosition);
            SetCoord(properties.LongFaceDist, piecePosition + 2);
            SetCoord(properties.ShortFaceDist, piecePosition + 4);
        }
    }
}
