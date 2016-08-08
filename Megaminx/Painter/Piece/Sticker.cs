using PuzzleImageGenerator.Shared;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Mega.Painter.Piece
{
    public class Sticker
    {
        public CoordPair[] Coords { get; set; }

        public string Color { get; private set; }

        public Sticker(List<CoordPair> coords, string color)
        {
            Coords = coords.ToArray();
            Color = color;
        }
    }
}
