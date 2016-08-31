using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Mega.Simulation.Moves
{
    abstract class Move
    {
        readonly int[] EdgeCycle1;
        readonly int[] EdgeCycle2;
        readonly int[] CornerCycle1;
        readonly int[] CornerCycle2;
        readonly int[] CornerCycle3;
    }
}
