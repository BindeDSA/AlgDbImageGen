using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Mega.Simulation.Moves
{
    class FMove : Move
    {
        protected override int[] EdgeCycle1 { get { return new[] { 5, 6, 7, 8, 9 }; } }
        protected override int[] EdgeCycle2 { get { return new[] { 0, 29, 52, 48, 11 }; } }
        protected override int[] CornerCycle1 { get { return new[] { 5, 6, 7, 8, 9 }; } }
        protected override int[] CornerCycle2 { get { return new[] { 0, 29, 52, 48, 11 }; } }
        protected override int[] CornerCycle3 { get { return new[] { 4, 28, 51, 47, 10 }; } }
    }
}
