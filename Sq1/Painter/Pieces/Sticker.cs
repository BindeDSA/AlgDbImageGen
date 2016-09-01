using System.Collections.Generic;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Sq1.Painter.Pieces
{
    class Sticker
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
