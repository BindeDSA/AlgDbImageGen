using PuzzleImageGenerator.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Mega.Painter.Piece
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
