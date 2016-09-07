using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Mega.Simulation.Moves
{
    class FrMove : Move
    {
        protected override int[] EdgeCycle1 { get { return new[] { 25, 26, 27, 28, 29 }; } }
        protected override int[] EdgeCycle2 { get { return new[] { 4, 24, 57, 53, 6 }; } }
        protected override int[] CornerCycle1 { get { return new[] { 25, 26, 27, 28, 29 }; } }
        protected override int[] CornerCycle2 { get { return new[] { 3, 23, 56, 52, 5 }; } }
        protected override int[] CornerCycle3 { get { return new[] { 4, 24, 57, 53, 6 }; } }
    }
}
