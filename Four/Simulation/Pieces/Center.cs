using PuzzleImageGenerator.Four.Simulation.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Four.Simulation.Pieces
{
    public class Center
    {
        public CenterPiece[] Cubies { get; set; }

        public Center(CenterPiece piece)
        {
            var cubies = new List<CenterPiece>();
            for (int i = 0; i < 4; i++)
            {
                cubies.Add(piece);
            }
            Cubies = cubies.ToArray();
        }
    }
}
