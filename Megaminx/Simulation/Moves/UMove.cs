using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Mega.Simulation.Moves
{
    class UMove : Move
    {
        readonly int[] EdgeCycle1 = new[] { 1, 2, 3, 4, 5 };
        readonly int[] EdgeCycle2 = new[] { 6, 7, 8, 9, 10 };
        readonly int[] CornerCycle1 = new[] { 1, 2, 3, 4, 5 };
        readonly int[] CornerCycle2 = new[] { 6, 7, 8, 9, 10 };
        readonly int[] CornerCycle3 = new[] { 11, 12, 13, 14, 15 };
    }
}
