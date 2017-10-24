using PuzzleImageGenerator.Four.Simulation.Enums;
using PuzzleImageGenerator.Four.Simulation.Pieces;
using System;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Four.Simulation.Move
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
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 0), new Tuple<CenterPiece, int>(CenterPiece.U, 1), new Tuple<CenterPiece, int>(CenterPiece.U, 2), new Tuple<CenterPiece, int>(CenterPiece.U, 3) }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>().ToArray()
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
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 0), new Tuple<CenterPiece, int>(CenterPiece.R, 1), new Tuple<CenterPiece, int>(CenterPiece.R, 2), new Tuple<CenterPiece, int>(CenterPiece.R, 3) }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>().ToArray()
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
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.F, 0), new Tuple<CenterPiece, int>(CenterPiece.F, 1), new Tuple<CenterPiece, int>(CenterPiece.F, 2), new Tuple<CenterPiece, int>(CenterPiece.F, 3) }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>().ToArray()
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
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.D, 0), new Tuple<CenterPiece, int>(CenterPiece.D, 1), new Tuple<CenterPiece, int>(CenterPiece.D, 2), new Tuple<CenterPiece, int>(CenterPiece.D, 3) }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>().ToArray()
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
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.L, 0), new Tuple<CenterPiece, int>(CenterPiece.L, 1), new Tuple<CenterPiece, int>(CenterPiece.L, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 3) }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>().ToArray()
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
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.B, 0), new Tuple<CenterPiece, int>(CenterPiece.B, 1), new Tuple<CenterPiece, int>(CenterPiece.B, 2), new Tuple<CenterPiece, int>(CenterPiece.B, 3) }
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>().ToArray()
                };
            }
        }

        public static CubeMove uMove
        {
            get
            {
                var edgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>
                {
                    new Tuple<EdgeCubie, int>[] { new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.FR, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.FL, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.BL, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.BR, 1), 1) }
                };
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 2), new Tuple<CenterPiece, int>(CenterPiece.F, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 2), new Tuple<CenterPiece, int>(CenterPiece.B, 0) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 3), new Tuple<CenterPiece, int>(CenterPiece.F, 3), new Tuple<CenterPiece, int>(CenterPiece.L, 3), new Tuple<CenterPiece, int>(CenterPiece.B, 1) },
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = new List<Tuple<CornerPiece, int>[]>().ToArray(),
                    EdgeCycles = new List<Tuple<EdgePiece, int>[]>().ToArray(),
                    EdgeCubieCycles = edgeCubieCycles.ToArray()
                };
            }
        }

        public static CubeMove rMove
        {
            get
            {
                var edgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>
                {
                    new Tuple<EdgeCubie, int>[] { new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UF, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UB, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DB, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DF, 1), 1) }
                };
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 0), new Tuple<CenterPiece, int>(CenterPiece.B, 0), new Tuple<CenterPiece, int>(CenterPiece.D, 0), new Tuple<CenterPiece, int>(CenterPiece.F, 0) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 3), new Tuple<CenterPiece, int>(CenterPiece.B, 3), new Tuple<CenterPiece, int>(CenterPiece.D, 3), new Tuple<CenterPiece, int>(CenterPiece.F, 3) },
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = new List<Tuple<CornerPiece, int>[]>().ToArray(),
                    EdgeCycles = new List<Tuple<EdgePiece, int>[]>().ToArray(),
                    EdgeCubieCycles = edgeCubieCycles.ToArray()
                };
            }
        }

        public static CubeMove fMove
        {
            get
            {
                var edgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>
                {
                    new Tuple<EdgeCubie, int>[] { new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UR, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DR, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DL, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UL, 1), 0) }
                };
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 0), new Tuple<CenterPiece, int>(CenterPiece.R, 1), new Tuple<CenterPiece, int>(CenterPiece.D, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 3) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 1), new Tuple<CenterPiece, int>(CenterPiece.R, 2), new Tuple<CenterPiece, int>(CenterPiece.D, 3), new Tuple<CenterPiece, int>(CenterPiece.L, 0) },
               };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = new List<Tuple<CornerPiece, int>[]>().ToArray(),
                    EdgeCycles = new List<Tuple<EdgePiece, int>[]>().ToArray(),
                    EdgeCubieCycles = edgeCubieCycles.ToArray()
                };
            }
        }

        public static CubeMove dMove
        {
            get
            {
                var edgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>
                {
                    new Tuple<EdgeCubie, int>[] { new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.FR, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.BR, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.BL, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.FL, 1), 0) }
                };
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.F, 0), new Tuple<CenterPiece, int>(CenterPiece.R, 0), new Tuple<CenterPiece, int>(CenterPiece.B, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 1) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.F, 1), new Tuple<CenterPiece, int>(CenterPiece.R, 1), new Tuple<CenterPiece, int>(CenterPiece.B, 3), new Tuple<CenterPiece, int>(CenterPiece.L, 0) },
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = new List<Tuple<CornerPiece, int>[]>().ToArray(),
                    EdgeCycles = new List<Tuple<EdgePiece, int>[]>().ToArray(),
                    EdgeCubieCycles = edgeCubieCycles.ToArray()
                };
            }
        }

        public static CubeMove lMove
        {
            get
            {
                var edgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>
                {
                    new Tuple<EdgeCubie, int>[] { new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UF, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DF, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DB, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UB, 1), 0) }
                };
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.F, 1), new Tuple<CenterPiece, int>(CenterPiece.D, 1), new Tuple<CenterPiece, int>(CenterPiece.B, 1), new Tuple<CenterPiece, int>(CenterPiece.U, 1) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.F, 2), new Tuple<CenterPiece, int>(CenterPiece.D, 2), new Tuple<CenterPiece, int>(CenterPiece.B, 2), new Tuple<CenterPiece, int>(CenterPiece.U, 2) },

                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = new List<Tuple<CornerPiece, int>[]>().ToArray(),
                    EdgeCycles = new List<Tuple<EdgePiece, int>[]>().ToArray(),
                    EdgeCubieCycles = edgeCubieCycles.ToArray()
                };
            }
        }

        public static CubeMove bMove
        {
            get
            {
                var edgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>
                {
                    new Tuple<EdgeCubie, int>[] { new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UR, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UL, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DL, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DR, 1), 1) }
                };
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 0), new Tuple<CenterPiece, int>(CenterPiece.U, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 1), new Tuple<CenterPiece, int>(CenterPiece.D, 0) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 3), new Tuple<CenterPiece, int>(CenterPiece.U, 3), new Tuple<CenterPiece, int>(CenterPiece.L, 2), new Tuple<CenterPiece, int>(CenterPiece.D, 1) },
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = new List<Tuple<CornerPiece, int>[]>().ToArray(),
                    EdgeCycles = new List<Tuple<EdgePiece, int>[]>().ToArray(),
                    EdgeCubieCycles = edgeCubieCycles.ToArray()
                };
            }
        }

        public static CubeMove UwMove
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
                };
                var edgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>
                {
                    new Tuple<EdgeCubie, int>[] { new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.FR, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.FL, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.BL, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.BR, 1), 1) }
                };
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 0), new Tuple<CenterPiece, int>(CenterPiece.U, 1), new Tuple<CenterPiece, int>(CenterPiece.U, 2), new Tuple<CenterPiece, int>(CenterPiece.U, 3) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 2), new Tuple<CenterPiece, int>(CenterPiece.F, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 2), new Tuple<CenterPiece, int>(CenterPiece.B, 0) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 3), new Tuple<CenterPiece, int>(CenterPiece.F, 3), new Tuple<CenterPiece, int>(CenterPiece.L, 3), new Tuple<CenterPiece, int>(CenterPiece.B, 1) },
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = edgeCubieCycles.ToArray()
                };
            }
        }

        public static CubeMove RwMove
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
                };
                var edgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>
                {
                    new Tuple<EdgeCubie, int>[] { new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UF, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UB, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DB, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DF, 1), 1) }
                };
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 0), new Tuple<CenterPiece, int>(CenterPiece.R, 1), new Tuple<CenterPiece, int>(CenterPiece.R, 2), new Tuple<CenterPiece, int>(CenterPiece.R, 3) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 0), new Tuple<CenterPiece, int>(CenterPiece.B, 0), new Tuple<CenterPiece, int>(CenterPiece.D, 0), new Tuple<CenterPiece, int>(CenterPiece.F, 0) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 3), new Tuple<CenterPiece, int>(CenterPiece.B, 3), new Tuple<CenterPiece, int>(CenterPiece.D, 3), new Tuple<CenterPiece, int>(CenterPiece.F, 3) },
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = edgeCubieCycles.ToArray()
                };
            }
        }

        public static CubeMove FwMove
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
                };
                var edgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>
                {
                    new Tuple<EdgeCubie, int>[] { new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UR, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DR, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DL, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UL, 1), 0) }
                };
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.F, 0), new Tuple<CenterPiece, int>(CenterPiece.F, 1), new Tuple<CenterPiece, int>(CenterPiece.F, 2), new Tuple<CenterPiece, int>(CenterPiece.F, 3) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 0), new Tuple<CenterPiece, int>(CenterPiece.R, 1), new Tuple<CenterPiece, int>(CenterPiece.D, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 3) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 1), new Tuple<CenterPiece, int>(CenterPiece.R, 2), new Tuple<CenterPiece, int>(CenterPiece.D, 3), new Tuple<CenterPiece, int>(CenterPiece.L, 0) },
               };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = edgeCubieCycles.ToArray()
                };
            }
        }

        public static CubeMove DwMove
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
                };
                var edgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>
                {
                    new Tuple<EdgeCubie, int>[] { new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.FR, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.BR, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.BL, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.FL, 1), 0) }
                };
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.D, 0), new Tuple<CenterPiece, int>(CenterPiece.D, 1), new Tuple<CenterPiece, int>(CenterPiece.D, 2), new Tuple<CenterPiece, int>(CenterPiece.D, 3) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.F, 0), new Tuple<CenterPiece, int>(CenterPiece.R, 0), new Tuple<CenterPiece, int>(CenterPiece.B, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 1) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.F, 1), new Tuple<CenterPiece, int>(CenterPiece.R, 1), new Tuple<CenterPiece, int>(CenterPiece.B, 3), new Tuple<CenterPiece, int>(CenterPiece.L, 0) },
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = edgeCubieCycles.ToArray()
                };
            }
        }

        public static CubeMove LwMove
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
                };
                var edgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>
                {
                    new Tuple<EdgeCubie, int>[] { new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UF, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DF, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DB, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UB, 1), 0) }
                };
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.L, 0), new Tuple<CenterPiece, int>(CenterPiece.L, 1), new Tuple<CenterPiece, int>(CenterPiece.L, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 3) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.F, 1), new Tuple<CenterPiece, int>(CenterPiece.D, 1), new Tuple<CenterPiece, int>(CenterPiece.B, 1), new Tuple<CenterPiece, int>(CenterPiece.U, 1) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.F, 2), new Tuple<CenterPiece, int>(CenterPiece.D, 2), new Tuple<CenterPiece, int>(CenterPiece.B, 2), new Tuple<CenterPiece, int>(CenterPiece.U, 2) },

                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = edgeCubieCycles.ToArray()
                };
            }
        }

        public static CubeMove BwMove
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
                };
                var edgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>
                {
                    new Tuple<EdgeCubie, int>[] { new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UR, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.UL, 1), 1), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DL, 1), 0), new Tuple<EdgeCubie, int>(new EdgeCubie(EdgePiece.DR, 1), 1) }
                };
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.B, 0), new Tuple<CenterPiece, int>(CenterPiece.B, 1), new Tuple<CenterPiece, int>(CenterPiece.B, 2), new Tuple<CenterPiece, int>(CenterPiece.B, 3) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 0), new Tuple<CenterPiece, int>(CenterPiece.U, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 1), new Tuple<CenterPiece, int>(CenterPiece.D, 0) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 3), new Tuple<CenterPiece, int>(CenterPiece.U, 3), new Tuple<CenterPiece, int>(CenterPiece.L, 2), new Tuple<CenterPiece, int>(CenterPiece.D, 1) },
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = edgeCubieCycles.ToArray()
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
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 2), new Tuple<CenterPiece, int>(CenterPiece.B, 0), new Tuple<CenterPiece, int>(CenterPiece.L, 2), new Tuple<CenterPiece, int>(CenterPiece.F, 2) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 3), new Tuple<CenterPiece, int>(CenterPiece.B, 1), new Tuple<CenterPiece, int>(CenterPiece.L, 3), new Tuple<CenterPiece, int>(CenterPiece.F, 3) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 0), new Tuple<CenterPiece, int>(CenterPiece.B, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 0), new Tuple<CenterPiece, int>(CenterPiece.F, 0) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 1), new Tuple<CenterPiece, int>(CenterPiece.B, 3), new Tuple<CenterPiece, int>(CenterPiece.L, 1), new Tuple<CenterPiece, int>(CenterPiece.F, 1) },
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = new List<Tuple<CornerPiece, int>[]>().ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>().ToArray()
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
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 0), new Tuple<CenterPiece, int>(CenterPiece.F, 0), new Tuple<CenterPiece, int>(CenterPiece.D, 0), new Tuple<CenterPiece, int>(CenterPiece.B, 0) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 3), new Tuple<CenterPiece, int>(CenterPiece.F, 3), new Tuple<CenterPiece, int>(CenterPiece.D, 3), new Tuple<CenterPiece, int>(CenterPiece.B, 3) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 1), new Tuple<CenterPiece, int>(CenterPiece.F, 1), new Tuple<CenterPiece, int>(CenterPiece.D, 1), new Tuple<CenterPiece, int>(CenterPiece.B, 1) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 2), new Tuple<CenterPiece, int>(CenterPiece.F, 2), new Tuple<CenterPiece, int>(CenterPiece.D, 2), new Tuple<CenterPiece, int>(CenterPiece.B, 2) },
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = new List<Tuple<CornerPiece, int>[]>().ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>().ToArray()
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
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 0), new Tuple<CenterPiece, int>(CenterPiece.R, 1), new Tuple<CenterPiece, int>(CenterPiece.D, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 3) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 1), new Tuple<CenterPiece, int>(CenterPiece.R, 2), new Tuple<CenterPiece, int>(CenterPiece.D, 3), new Tuple<CenterPiece, int>(CenterPiece.L, 0) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 2), new Tuple<CenterPiece, int>(CenterPiece.R, 3), new Tuple<CenterPiece, int>(CenterPiece.D, 0), new Tuple<CenterPiece, int>(CenterPiece.L, 1) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 3), new Tuple<CenterPiece, int>(CenterPiece.R, 0), new Tuple<CenterPiece, int>(CenterPiece.D, 1), new Tuple<CenterPiece, int>(CenterPiece.L, 2) },
               };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = new List<Tuple<CornerPiece, int>[]>().ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>().ToArray()
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
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 0), new Tuple<CenterPiece, int>(CenterPiece.U, 1), new Tuple<CenterPiece, int>(CenterPiece.U, 2), new Tuple<CenterPiece, int>(CenterPiece.U, 3) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 2), new Tuple<CenterPiece, int>(CenterPiece.F, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 2), new Tuple<CenterPiece, int>(CenterPiece.B, 0) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 3), new Tuple<CenterPiece, int>(CenterPiece.F, 3), new Tuple<CenterPiece, int>(CenterPiece.L, 3), new Tuple<CenterPiece, int>(CenterPiece.B, 1) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 0), new Tuple<CenterPiece, int>(CenterPiece.F, 0), new Tuple<CenterPiece, int>(CenterPiece.L, 0), new Tuple<CenterPiece, int>(CenterPiece.B, 2) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 1), new Tuple<CenterPiece, int>(CenterPiece.F, 1), new Tuple<CenterPiece, int>(CenterPiece.L, 1), new Tuple<CenterPiece, int>(CenterPiece.B, 3) },
                   new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.D, 0), new Tuple<CenterPiece, int>(CenterPiece.D, 3), new Tuple<CenterPiece, int>(CenterPiece.D, 2), new Tuple<CenterPiece, int>(CenterPiece.D, 1) },
                };

                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>().ToArray()
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
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.R, 0), new Tuple<CenterPiece, int>(CenterPiece.R, 1), new Tuple<CenterPiece, int>(CenterPiece.R, 2), new Tuple<CenterPiece, int>(CenterPiece.R, 3) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 0), new Tuple<CenterPiece, int>(CenterPiece.B, 0), new Tuple<CenterPiece, int>(CenterPiece.D, 0), new Tuple<CenterPiece, int>(CenterPiece.F, 0) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 3), new Tuple<CenterPiece, int>(CenterPiece.B, 3), new Tuple<CenterPiece, int>(CenterPiece.D, 3), new Tuple<CenterPiece, int>(CenterPiece.F, 3) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 1), new Tuple<CenterPiece, int>(CenterPiece.B, 1), new Tuple<CenterPiece, int>(CenterPiece.D, 1), new Tuple<CenterPiece, int>(CenterPiece.F, 1) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 2), new Tuple<CenterPiece, int>(CenterPiece.B, 2), new Tuple<CenterPiece, int>(CenterPiece.D, 2), new Tuple<CenterPiece, int>(CenterPiece.F, 2) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.L, 0), new Tuple<CenterPiece, int>(CenterPiece.L, 3), new Tuple<CenterPiece, int>(CenterPiece.L, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 1) },
                };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>().ToArray()
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
                var centerCycles = new List<Tuple<CenterPiece, int>[]>
                {
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.F, 0), new Tuple<CenterPiece, int>(CenterPiece.F, 1), new Tuple<CenterPiece, int>(CenterPiece.F, 2), new Tuple<CenterPiece, int>(CenterPiece.F, 3) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 0), new Tuple<CenterPiece, int>(CenterPiece.R, 1), new Tuple<CenterPiece, int>(CenterPiece.D, 2), new Tuple<CenterPiece, int>(CenterPiece.L, 3) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 1), new Tuple<CenterPiece, int>(CenterPiece.R, 2), new Tuple<CenterPiece, int>(CenterPiece.D, 3), new Tuple<CenterPiece, int>(CenterPiece.L, 0) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 2), new Tuple<CenterPiece, int>(CenterPiece.R, 3), new Tuple<CenterPiece, int>(CenterPiece.D, 0), new Tuple<CenterPiece, int>(CenterPiece.L, 1) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.U, 3), new Tuple<CenterPiece, int>(CenterPiece.R, 0), new Tuple<CenterPiece, int>(CenterPiece.D, 1), new Tuple<CenterPiece, int>(CenterPiece.L, 2) },
                     new Tuple<CenterPiece, int>[] {new Tuple<CenterPiece, int>(CenterPiece.B, 0), new Tuple<CenterPiece, int>(CenterPiece.B, 3), new Tuple<CenterPiece, int>(CenterPiece.B, 2), new Tuple<CenterPiece, int>(CenterPiece.B, 1) },
               };
                return new CubeMove()
                {
                    CenterCycles = centerCycles.ToArray(),
                    CornerCycles = cornerCycles.ToArray(),
                    EdgeCycles = edgeCycles.ToArray(),
                    EdgeCubieCycles = new List<Tuple<EdgeCubie, int>[]>().ToArray()
                };
            }
        }
    }
}
