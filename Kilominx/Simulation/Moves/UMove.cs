using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Kilo.Simulation.Moves
{
    class UMove : Move
    {
        protected override int[] CornerCycle1 { get { return new[] { 0, 1, 2, 3, 4 }; } }
        protected override int[] CornerCycle2 { get { return new[] { 5, 10, 15, 20, 25 }; } }
        protected override int[] CornerCycle3 { get { return new[] { 9, 14, 19, 24, 29 }; } }
    }
}
