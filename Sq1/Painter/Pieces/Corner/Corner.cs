using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Sq1.Painter.Pieces.Corner
{
    public class Corner : Piece
    {
        private CornerFace Face;
        private CornerSide[] Sides = { };
        public override PieceType Type { get { return PieceType.Corner; } }
        public override Sticker[] Stickers
        {
            get { return new Sticker[] { Face, Sides[0], Sides[1] }; }
        }

        public Corner(string stickerDef, int position, Sq1ImageProp properties)
        {
            Face = new CornerFace(position, stickerDef[0], properties);
            Sides = new[] { new CornerSide(position, stickerDef[1], CornerSide.CornerSideType.First, properties),
                             new CornerSide(position, stickerDef[2], CornerSide.CornerSideType.Second, properties) };
        }
    }
}
