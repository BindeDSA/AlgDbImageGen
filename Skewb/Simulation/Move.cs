namespace PuzzleImageGenerator.Skewb.Simulation
{
    class Move
    {
        public static char[] Set = { 'R', 'r', 'F', 'f', 'L', 'l', 'B', 'b' };
        protected enum CornerIndices { URF, UFL, ULB, UBR, DFR, DLF, DBL, DRB }
        protected enum CenterIndices { U, R, F, D, L, B }
        public int[] Centers { get; protected set; }
        public int[][] Corners { get; protected set; } 
        public Move(char moveName)
        {
            switch (moveName)
            {
                // final corner does not move
                case 'R':
                    Centers = new int[] { (int)CenterIndices.U, (int)CenterIndices.R, (int)CenterIndices.F };
                    Corners = new int[][] { new int[] { (int)CornerIndices.DFR, (int)CornerIndices.UFL, (int)CornerIndices.UBR, (int)CornerIndices.URF } };
                    break;
                case 'r':
                    Centers = new int[] { (int)CenterIndices.D, (int)CenterIndices.F, (int)CenterIndices.R };
                    Corners = new int[][] { new int[] { (int)CornerIndices.URF, (int)CornerIndices.DRB, (int)CornerIndices.DLF, (int)CornerIndices.DFR } };
                    break;
                case 'F':
                    Centers = new int[] { (int)CenterIndices.U, (int)CenterIndices.F, (int)CenterIndices.L };
                    Corners = new int[][] { new int[] { (int)CornerIndices.DLF, (int)CornerIndices.ULB, (int)CornerIndices.URF, (int)CornerIndices.UFL } };
                    break;
                case 'f':
                    Centers = new int[] { (int)CenterIndices.D, (int)CenterIndices.L, (int)CenterIndices.F };
                    Corners = new int[][] { new int[] { (int)CornerIndices.UFL, (int)CornerIndices.DFR, (int)CornerIndices.DBL, (int)CornerIndices.DLF } };
                    break;
                case 'L':
                    Centers = new int[] { (int)CenterIndices.U, (int)CenterIndices.L, (int)CenterIndices.B };
                    Corners = new int[][] { new int[] { (int)CornerIndices.DBL, (int)CornerIndices.UBR, (int)CornerIndices.UFL, (int)CornerIndices.ULB } };
                    break;
                case 'l':
                    Centers = new int[] { (int)CenterIndices.D, (int)CenterIndices.B, (int)CenterIndices.L };
                    Corners = new int[][] { new int[] { (int)CornerIndices.ULB, (int)CornerIndices.DLF, (int)CornerIndices.DRB, (int)CornerIndices.DBL } };
                    break;
                case 'B':
                    Centers = new int[] { (int)CenterIndices.U, (int)CenterIndices.B, (int)CenterIndices.R };
                    Corners = new int[][] { new int[] { (int)CornerIndices.DRB, (int)CornerIndices.URF, (int)CornerIndices.ULB, (int)CornerIndices.UBR } };
                    break;
                case 'b':
                    Centers = new int[] { (int)CenterIndices.D, (int)CenterIndices.R, (int)CenterIndices.B };
                    Corners = new int[][] { new int[] { (int)CornerIndices.UBR, (int)CornerIndices.DBL, (int)CornerIndices.DFR, (int)CornerIndices.DRB } };
                    break;
            }
        }
    }
}
