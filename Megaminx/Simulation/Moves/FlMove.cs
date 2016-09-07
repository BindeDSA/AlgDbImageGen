using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Mega.Simulation.Moves
{
    class FlMove : Move
    {
        protected override int[] EdgeCycle1 { get { return new[] { 10, 11, 12, 13, 14 }; } }
        protected override int[] EdgeCycle2 { get { return new[] { 1, 9, 47, 43, 16 }; } }
        protected override int[] CornerCycle1 { get { return new[] { 10, 11, 12, 13, 14 }; } }
        protected override int[] CornerCycle2 { get { return new[] { 1, 9, 47, 43, 16 }; } }
        protected override int[] CornerCycle3 { get { return new[] { 0, 8, 46, 42, 15 }; } }
    }
}
