using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Skewb.Simulation
{
    class Corner : Piece
    {
        new public static string[] PieceNames = { "urf", "ufl", "ulb", "ubr", "dfr", "dlf", "dbl", "drb" }; 
        public int Orientation { get; private set; }
        public Corner(string pieceName)
            : base(pieceName)
        {
            Orientation = 0;
        }
        public static int[] GetStickerOrder(char face)
        {
            switch (face)
            {
                case 'u':
                    return new int[] { 0, 3, 2, 1 };
                case 'd':
                    return new int[] { 4, 5, 6, 7 };
                case 'r':
                    return new int[] { 0, 4, 7, 3 };
                case 'f':
                    return new int[] { 0, 1, 5, 4 };
                case 'l':
                    return new int[] { 1, 2, 6, 5 };
                case 'b':
                    return new int[] { 3, 7, 6, 2 };
            }
            return null;
        }
        public char GetFace(int Position)
        {
            return PieceName[(Position + Orientation) % 3];
        }
        public void Rotate(bool clockwise)
        {
            Orientation = (Orientation + (clockwise ? -1 : 1) + 3) % 3;
        }
    }
}
