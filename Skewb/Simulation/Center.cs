using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Skewb.Simulation
{
    class Center : Piece
    {
        new public static string[] PieceNames = { "u", "r", "f", "d", "l", "b" };


        public Center(string PieceName)
            : base(PieceName)
        {
        }
    }
}
