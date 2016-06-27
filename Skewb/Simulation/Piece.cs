using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Skewb.Simulation
{
    class Piece
    {
        public string PieceName { get; protected set; }
        public static string PieceNames = "";

        public Piece(string pieceName)
        {
            PieceName = pieceName;            
        }
    }
}
