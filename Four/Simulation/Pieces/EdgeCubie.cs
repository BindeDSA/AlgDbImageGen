using PuzzleImageGenerator.Four.Simulation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Four.Simulation.Pieces
{
    public class EdgeCubie
    {
        public EdgePiece Piece { get; set; }
        public int Orientation { get; set; }

        public EdgeCubie(EdgePiece piece, int orientation = 0)
        {
            Piece = piece;
            Orientation = orientation;
        }

        public void ChangeOrientation(int orientationChane)
        {
            Orientation = (Orientation + orientationChane + 2) % 2;
        }
    }
}
