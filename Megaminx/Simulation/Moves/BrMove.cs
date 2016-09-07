using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Mega.Simulation.Moves
{
    class BrMove : Move
    {
        protected override int[] EdgeCycle1 { get { return new[] { 20, 21, 22, 23, 24 }; } }
        protected override int[] EdgeCycle2 { get { return new[] { 3, 19, 32, 58, 26}; } }
        protected override int[] CornerCycle1 { get { return new[] { 20, 21, 22, 23, 24 }; } }
        protected override int[] CornerCycle2 { get { return new[] { 3, 19, 32, 58, 26 }; } }
        protected override int[] CornerCycle3 { get { return new[] { 2, 18, 31, 57, 25 }; } }
    }
}
