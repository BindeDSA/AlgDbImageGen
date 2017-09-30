using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Sq1.Painter.Pieces
{
    public abstract class Piece
    {
        public abstract Sticker[] Stickers { get; }
        public abstract PieceType Type { get; }
    }

    public enum PieceType { Corner, Edge }
}
