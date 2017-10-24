using PuzzleImageGenerator.Three.Simulation.Enums;
using System;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Three.Simulation.Move
{
    class MoveDefs
    {
        public static CubeMove UMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.URF, 0), new Tuple<CornerPiece, int>(CornerPiece.UFL, 0), new Tuple<CornerPiece, int>(CornerPiece.ULB, 0), new Tuple<CornerPiece, int>(CornerPiece.UBR, 0) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UR, 0), new Tuple<EdgePiece, int>(EdgePiece.UF, 0), new Tuple<EdgePiece, int>(EdgePiece.UL, 0), new Tuple<EdgePiece, int>(EdgePiece.UB, 0) }
                };
                return new CubeMove()
                {
                    CenterCycles = new List<CenterPiece[]>().ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove RMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.URF, 1), new Tuple<CornerPiece, int>(CornerPiece.UBR, -1), new Tuple<CornerPiece, int>(CornerPiece.DRB, 1), new Tuple<CornerPiece, int>(CornerPiece.DFR, -1) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UR, 0), new Tuple<EdgePiece, int>(EdgePiece.BR, 0), new Tuple<EdgePiece, int>(EdgePiece.DR, 0), new Tuple<EdgePiece, int>(EdgePiece.FR, 0) }
                };
                return new CubeMove()
                {
                    CenterCycles = new List<CenterPiece[]>().ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove FMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.URF, -1), new Tuple<CornerPiece, int>(CornerPiece.DFR, 1), new Tuple<CornerPiece, int>(CornerPiece.DLF, -1), new Tuple<CornerPiece, int>(CornerPiece.UFL, 1) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UF, 1), new Tuple<EdgePiece, int>(EdgePiece.FR, 1), new Tuple<EdgePiece, int>(EdgePiece.DF, 1), new Tuple<EdgePiece, int>(EdgePiece.FL, 1) }
                };
                return new CubeMove()
                {
                    CenterCycles = new List<CenterPiece[]>().ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }
        public static CubeMove DMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.DFR, 0), new Tuple<CornerPiece, int>(CornerPiece.DRB, 0), new Tuple<CornerPiece, int>(CornerPiece.DBL, 0), new Tuple<CornerPiece, int>(CornerPiece.DLF, 0) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.DR, 0), new Tuple<EdgePiece, int>(EdgePiece.DB, 0), new Tuple<EdgePiece, int>(EdgePiece.DL, 0), new Tuple<EdgePiece, int>(EdgePiece.DF, 0) }
                };
                return new CubeMove()
                {
                    CenterCycles = new List<CenterPiece[]>().ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove LMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.UFL, -1), new Tuple<CornerPiece, int>(CornerPiece.DLF, 1), new Tuple<CornerPiece, int>(CornerPiece.DBL, -1), new Tuple<CornerPiece, int>(CornerPiece.ULB, 1) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UL, 0), new Tuple<EdgePiece, int>(EdgePiece.FL, 0), new Tuple<EdgePiece, int>(EdgePiece.DL, 0), new Tuple<EdgePiece, int>(EdgePiece.BL, 0) }
                };
                return new CubeMove()
                {
                    CenterCycles = new List<CenterPiece[]>().ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove BMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.UBR, 1), new Tuple<CornerPiece, int>(CornerPiece.ULB, -1), new Tuple<CornerPiece, int>(CornerPiece.DBL, 1), new Tuple<CornerPiece, int>(CornerPiece.DRB, -1) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UB, 1), new Tuple<EdgePiece, int>(EdgePiece.BL, 1), new Tuple<EdgePiece, int>(EdgePiece.DB, 1), new Tuple<EdgePiece, int>(EdgePiece.BR, 1) }
                };
                return new CubeMove()
                {
                    CenterCycles = new List<CenterPiece[]>().ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove uMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.URF, 0), new Tuple<CornerPiece, int>(CornerPiece.UFL, 0), new Tuple<CornerPiece, int>(CornerPiece.ULB, 0), new Tuple<CornerPiece, int>(CornerPiece.UBR, 0) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UR, 0), new Tuple<EdgePiece, int>(EdgePiece.UF, 0), new Tuple<EdgePiece, int>(EdgePiece.UL, 0), new Tuple<EdgePiece, int>(EdgePiece.UB, 0) },
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.FR, 1), new Tuple<EdgePiece, int>(EdgePiece.FL, 1), new Tuple<EdgePiece, int>(EdgePiece.BL, 1), new Tuple<EdgePiece, int>(EdgePiece.BR, 1) }
                };
                var centerCycles = new List<CenterPiece[]>
                {
                    new CenterPiece[] { CenterPiece.R, CenterPiece.F, CenterPiece.L, CenterPiece.B }
                };

                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove rMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.URF, 1), new Tuple<CornerPiece, int>(CornerPiece.UBR, -1), new Tuple<CornerPiece, int>(CornerPiece.DRB, 1), new Tuple<CornerPiece, int>(CornerPiece.DFR, -1) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UR, 0), new Tuple<EdgePiece, int>(EdgePiece.BR, 0), new Tuple<EdgePiece, int>(EdgePiece.DR, 0), new Tuple<EdgePiece, int>(EdgePiece.FR, 0) },
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UF, 1), new Tuple<EdgePiece, int>(EdgePiece.UB, 1), new Tuple<EdgePiece, int>(EdgePiece.DB, 1), new Tuple<EdgePiece, int>(EdgePiece.DF, 1) }
                };
                var centerCycles = new List<CenterPiece[]>
                {
                    new CenterPiece[] { CenterPiece.U, CenterPiece.B, CenterPiece.D, CenterPiece.F }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove fMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.URF, -1), new Tuple<CornerPiece, int>(CornerPiece.DFR, 1), new Tuple<CornerPiece, int>(CornerPiece.DLF, -1), new Tuple<CornerPiece, int>(CornerPiece.UFL, 1) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UF, 1), new Tuple<EdgePiece, int>(EdgePiece.FR, 1), new Tuple<EdgePiece, int>(EdgePiece.DF, 1), new Tuple<EdgePiece, int>(EdgePiece.FL, 1) },
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UR, 1), new Tuple<EdgePiece, int>(EdgePiece.DR, 1), new Tuple<EdgePiece, int>(EdgePiece.DL, 1), new Tuple<EdgePiece, int>(EdgePiece.UL, 1) }
                };
                var centerCycles = new List<CenterPiece[]>
                {
                    new CenterPiece[] { CenterPiece.U, CenterPiece.R, CenterPiece.D, CenterPiece.L }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove dMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.DFR, 0), new Tuple<CornerPiece, int>(CornerPiece.DRB, 0), new Tuple<CornerPiece, int>(CornerPiece.DBL, 0), new Tuple<CornerPiece, int>(CornerPiece.DLF, 0) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.DR, 0), new Tuple<EdgePiece, int>(EdgePiece.DB, 0), new Tuple<EdgePiece, int>(EdgePiece.DL, 0), new Tuple<EdgePiece, int>(EdgePiece.DF, 0) },
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.FR, 1), new Tuple<EdgePiece, int>(EdgePiece.BR, 1), new Tuple<EdgePiece, int>(EdgePiece.BL, 1), new Tuple<EdgePiece, int>(EdgePiece.FL, 1) }
                };
                var centerCycles = new List<CenterPiece[]>
                {
                    new CenterPiece[] { CenterPiece.F, CenterPiece.R, CenterPiece.B, CenterPiece.L }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove lMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.UFL, -1), new Tuple<CornerPiece, int>(CornerPiece.DLF, 1), new Tuple<CornerPiece, int>(CornerPiece.DBL, -1), new Tuple<CornerPiece, int>(CornerPiece.ULB, 1) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UL, 0), new Tuple<EdgePiece, int>(EdgePiece.FL, 0), new Tuple<EdgePiece, int>(EdgePiece.DL, 0), new Tuple<EdgePiece, int>(EdgePiece.BL, 0) },
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UF, 1), new Tuple<EdgePiece, int>(EdgePiece.DF, 1), new Tuple<EdgePiece, int>(EdgePiece.DB, 1), new Tuple<EdgePiece, int>(EdgePiece.UB, 1) }
                };
                var centerCycles = new List<CenterPiece[]>
                {
                    new CenterPiece[] { CenterPiece.U, CenterPiece.F, CenterPiece.D, CenterPiece.B }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove bMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.UBR, 1), new Tuple<CornerPiece, int>(CornerPiece.ULB, -1), new Tuple<CornerPiece, int>(CornerPiece.DBL, 1), new Tuple<CornerPiece, int>(CornerPiece.DRB, -1) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UB, 1), new Tuple<EdgePiece, int>(EdgePiece.BL, 1), new Tuple<EdgePiece, int>(EdgePiece.DB, 1), new Tuple<EdgePiece, int>(EdgePiece.BR, 1) },
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UR, 1), new Tuple<EdgePiece, int>(EdgePiece.UL, 1), new Tuple<EdgePiece, int>(EdgePiece.DL, 1), new Tuple<EdgePiece, int>(EdgePiece.DR, 1) }
                };
                var centerCycles = new List<CenterPiece[]>
                {
                    new CenterPiece[] { CenterPiece.U, CenterPiece.L, CenterPiece.D, CenterPiece.R }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove EMove
        {
            get
            {
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.FR, 1), new Tuple<EdgePiece, int>(EdgePiece.BR, 1), new Tuple<EdgePiece, int>(EdgePiece.BL, 1), new Tuple<EdgePiece, int>(EdgePiece.FL, 1) }
                };
                var centerCycles = new List<CenterPiece[]>
                {
                    new CenterPiece[] { CenterPiece.F, CenterPiece.R, CenterPiece.B, CenterPiece.L }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = new List<Tuple<CornerPiece, int>[]>().ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove MMove
        {
            get
            {
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UF, 1), new Tuple<EdgePiece, int>(EdgePiece.DF, 1), new Tuple<EdgePiece, int>(EdgePiece.DB, 1), new Tuple<EdgePiece, int>(EdgePiece.UB, 1) }
                };
                var centerCycles = new List<CenterPiece[]>
                {
                    new CenterPiece[] { CenterPiece.U, CenterPiece.F, CenterPiece.D, CenterPiece.B }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = new List<Tuple<CornerPiece, int>[]>().ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove SMove
        {
            get
            {
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UR, 1), new Tuple<EdgePiece, int>(EdgePiece.DR, 1), new Tuple<EdgePiece, int>(EdgePiece.DL, 1), new Tuple<EdgePiece, int>(EdgePiece.UL, 1) }
                };
                var centerCycles = new List<CenterPiece[]>
                {
                    new CenterPiece[] { CenterPiece.U, CenterPiece.R, CenterPiece.D, CenterPiece.L }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = new List<Tuple<CornerPiece, int>[]>().ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove yMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.URF, 0), new Tuple<CornerPiece, int>(CornerPiece.UFL, 0), new Tuple<CornerPiece, int>(CornerPiece.ULB, 0), new Tuple<CornerPiece, int>(CornerPiece.UBR, 0) },
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.DFR, 0), new Tuple<CornerPiece, int>(CornerPiece.DLF, 0), new Tuple<CornerPiece, int>(CornerPiece.DBL, 0), new Tuple<CornerPiece, int>(CornerPiece.DRB, 0) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UR, 0), new Tuple<EdgePiece, int>(EdgePiece.UF, 0), new Tuple<EdgePiece, int>(EdgePiece.UL, 0), new Tuple<EdgePiece, int>(EdgePiece.UB, 0) },
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.DR, 0), new Tuple<EdgePiece, int>(EdgePiece.DF, 0), new Tuple<EdgePiece, int>(EdgePiece.DL, 0), new Tuple<EdgePiece, int>(EdgePiece.DB, 0) },
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.FR, 1), new Tuple<EdgePiece, int>(EdgePiece.FL, 1), new Tuple<EdgePiece, int>(EdgePiece.BL, 1), new Tuple<EdgePiece, int>(EdgePiece.BR, 1) }
                };
                var centerCycles = new List<CenterPiece[]>
                {
                    new CenterPiece[] { CenterPiece.R, CenterPiece.F, CenterPiece.L, CenterPiece.B }
                };

                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove xMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.URF, 1), new Tuple<CornerPiece, int>(CornerPiece.UBR, -1), new Tuple<CornerPiece, int>(CornerPiece.DRB, 1), new Tuple<CornerPiece, int>(CornerPiece.DFR, -1) },
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.UFL, -1), new Tuple<CornerPiece, int>(CornerPiece.ULB, 1), new Tuple<CornerPiece, int>(CornerPiece.DBL, -1), new Tuple<CornerPiece, int>(CornerPiece.DLF, 1) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UR, 0), new Tuple<EdgePiece, int>(EdgePiece.BR, 0), new Tuple<EdgePiece, int>(EdgePiece.DR, 0), new Tuple<EdgePiece, int>(EdgePiece.FR, 0) },
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UL, 0), new Tuple<EdgePiece, int>(EdgePiece.BL, 0), new Tuple<EdgePiece, int>(EdgePiece.DL, 0), new Tuple<EdgePiece, int>(EdgePiece.FL, 0) },
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UF, 1), new Tuple<EdgePiece, int>(EdgePiece.UB, 1), new Tuple<EdgePiece, int>(EdgePiece.DB, 1), new Tuple<EdgePiece, int>(EdgePiece.DF, 1) }
                };
                var centerCycles = new List<CenterPiece[]>
                {
                    new CenterPiece[] { CenterPiece.U, CenterPiece.B, CenterPiece.D, CenterPiece.F }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }

        public static CubeMove zMove
        {
            get
            {
                var cornerCycles = new List<Tuple<CornerPiece, int>[]>
                {
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.URF, -1), new Tuple<CornerPiece, int>(CornerPiece.DFR, 1), new Tuple<CornerPiece, int>(CornerPiece.DLF, -1), new Tuple<CornerPiece, int>(CornerPiece.UFL, 1) },
                    new Tuple<CornerPiece, int>[] { new Tuple<CornerPiece, int>(CornerPiece.UBR, 1), new Tuple<CornerPiece, int>(CornerPiece.DRB, -1), new Tuple<CornerPiece, int>(CornerPiece.DBL, 1), new Tuple<CornerPiece, int>(CornerPiece.ULB, -1) }
                };
                var edgeCycles = new List<Tuple<EdgePiece, int>[]>
                {
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UF, 1), new Tuple<EdgePiece, int>(EdgePiece.FR, 1), new Tuple<EdgePiece, int>(EdgePiece.DF, 1), new Tuple<EdgePiece, int>(EdgePiece.FL, 1) },
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UB, 1), new Tuple<EdgePiece, int>(EdgePiece.BR, 1), new Tuple<EdgePiece, int>(EdgePiece.DB, 1), new Tuple<EdgePiece, int>(EdgePiece.BL, 1) },
                    new Tuple<EdgePiece, int>[] { new Tuple<EdgePiece, int>(EdgePiece.UR, 1), new Tuple<EdgePiece, int>(EdgePiece.DR, 1), new Tuple<EdgePiece, int>(EdgePiece.DL, 1), new Tuple<EdgePiece, int>(EdgePiece.UL, 1) }
                };
                var centerCycles = new List<CenterPiece[]>
                {
                    new CenterPiece[] { CenterPiece.U, CenterPiece.R, CenterPiece.D, CenterPiece.L }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray()
                };
            }
        }
    }
}
