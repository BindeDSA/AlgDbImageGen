using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Mega.Simulation.Moves
{
    class BlMove : Move
    {
        protected override int[] EdgeCycle1 { get { return new[] { 15, 16, 17, 18, 19 }; } }
        protected override int[] EdgeCycle2 { get { return new[] { 2, 14, 42, 48, 21 }; } }
        protected override int[] CornerCycle1 { get { return new[] { 15, 16, 17, 18, 19 }; } }
        protected override int[] CornerCycle2 { get { return new[] { 2, 14, 42, 48, 21 }; } }
        protected override int[] CornerCycle3 { get { return new[] { 1, 13, 41, 47, 20 }; } }
    }
}
