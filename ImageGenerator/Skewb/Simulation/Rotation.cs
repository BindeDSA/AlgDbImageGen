using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Skewb.Simulation
{
    class Rotation : Move
    {
        new public static char[] Set = { 'x', 'y', 'z' };
        public Rotation(char rotationName)
             : base(rotationName)
        {
            switch (rotationName)
            {
                case 'z':
                    Centers = new int[] { (int)CenterIndices.U, (int)CenterIndices.F, (int)CenterIndices.D, (int)CenterIndices.B };
                    Corners = new int[][] { new int[] { (int)CornerIndices.URF, (int)CornerIndices.DFR, (int)CornerIndices.DRB, (int)CornerIndices.UBR },
                                            new int[] { (int)CornerIndices.DLF, (int)CornerIndices.DBL, (int)CornerIndices.ULB, (int)CornerIndices.UFL } };
                    break;
                case 'y':
                    Centers = new int[] { (int)CenterIndices.R, (int)CenterIndices.F, (int)CenterIndices.L, (int)CenterIndices.B };
                    Corners = new int[][] { new int[] { (int)CornerIndices.UBR, (int)CornerIndices.URF, (int)CornerIndices.UFL, (int)CornerIndices.ULB },
                                            new int[] { (int)CornerIndices.DRB, (int)CornerIndices.DFR, (int)CornerIndices.DLF, (int)CornerIndices.DBL } };
                    break;
                case 'x':
                    Centers = new int[] { (int)CenterIndices.U, (int)CenterIndices.L, (int)CenterIndices.D, (int)CenterIndices.R };
                    Corners = new int[][] { new int[] { (int)CornerIndices.UFL, (int)CornerIndices.DLF, (int)CornerIndices.DFR, (int)CornerIndices.URF },
                                            new int[] { (int)CornerIndices.UBR, (int)CornerIndices.ULB, (int)CornerIndices.DBL, (int)CornerIndices.DRB } };
                    break;

            }
        }
    }
}
