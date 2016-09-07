using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Kilo.Simulation.Moves
{
    abstract class Move
    {
        protected virtual int[] CornerCycle1 { get; set; }
        protected virtual int[] CornerCycle2 { get; set; }
        protected virtual int[] CornerCycle3 { get; set; }
        public int[][] Cycles
        {
            get
            {
                return new[] { CornerCycle1, CornerCycle2, CornerCycle3 };
            }
        }
    }
}
