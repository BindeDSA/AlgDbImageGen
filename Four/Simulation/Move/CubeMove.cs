using PuzzleImageGenerator.Four.Simulation.Enums;
using PuzzleImageGenerator.Four.Simulation.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PuzzleImageGenerator.Four.Simulation.Move
{
    class CubeMove
    {
        public Tuple<CenterPiece, int>[][] CenterCycles { get; set; }
        public Tuple<CornerPiece, int>[][] CornerCycles { get; set; }
        public Tuple<EdgePiece, int>[][] EdgeCycles { get; set; }
        public Tuple<EdgeCubie, int>[][] EdgeCubieCycles { get; set; }


        public static void ApplAlg(VirtualCube cube, string alg, bool reverse = false)
        {
            var moves = Regex.Matches(alg, @"([uUrRfFdDlLbByxzMES][w]?(['23]?)+)").Cast<Match>().Select(m => m.Value).ToArray();
            var moveTuples = ((MoveType[])Enum.GetValues(typeof(MoveType))).Select(i => new Tuple<string, MoveType>(i.ToString(), i)).ToArray();
            if (reverse)
            {
                moves = moves.Reverse().ToArray();
            }
            foreach (String move in moves)
            {
                var moveEnum = moveTuples.Where(i => i.Item1 == Regex.Match(move, @"[uUrRfFdDlLbByxzMES][w]?").Value)
                          .Select(i => i.Item2);
                if (moveEnum.Count() != 0)
                {
                    if (move.Contains("2"))
                    {
                        Move(cube, moveEnum.First(), 2);
                    }
                    else if (((move.Contains('\'') || move.Contains('3')) && !reverse) ^ (reverse && !(move.Contains('\'') || move.Contains('3'))))
                    {
                        Move(cube, moveEnum.First(), 3);
                    }
                    else if(((move.Contains('\'') || move.Contains('3')) && reverse) ^ (!reverse && !(move.Contains('\'') || move.Contains('3'))))
                    {
                        Move(cube, moveEnum.First(), 1);
                    }
                }
            }
        }

        private static void Move(VirtualCube cube, MoveType moveType, int direction)
        {
            switch (moveType)
            {
                case MoveType.U:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.UMove);
                    }
                    break;
                case MoveType.R:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.RMove);
                    }
                    break;
                case MoveType.F:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.FMove);
                    }
                    break;
                case MoveType.D:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.DMove);
                    }
                    break;
                case MoveType.L:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.LMove);
                    }
                    break;
                case MoveType.B:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.BMove);
                    }
                    break;
                case MoveType.Uw:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.UwMove);
                    }
                    break;
                case MoveType.Rw:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.RwMove);
                    }
                    break;
                case MoveType.Fw:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.FwMove);
                    }
                    break;
                case MoveType.Dw:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.DwMove);
                    }
                    break;
                case MoveType.Lw:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.LwMove);
                    }
                    break;
                case MoveType.Bw:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.BwMove);
                    }
                    break;
                case MoveType.u:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.uMove);
                    }
                    break;
                case MoveType.r:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.rMove);
                    }
                    break;
                case MoveType.f:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.fMove);
                    }
                    break;
                case MoveType.d:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.dMove);
                    }
                    break;
                case MoveType.l:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.lMove);
                    }
                    break;
                case MoveType.b:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.bMove);
                    }
                    break;
                case MoveType.E:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.EMove);
                    }
                    break;
                case MoveType.M:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.MMove);
                    }
                    break;
                case MoveType.S:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.SMove);
                    }
                    break;
                case MoveType.x:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.xMove);
                    }
                    break;
                case MoveType.y:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.yMove);
                    }
                    break;
                case MoveType.z:
                    for (int i = 0; i < direction; i++)
                    {
                        SingleMove(cube, MoveDefs.zMove);
                    }
                    break;
            }
        }

        private static void SingleMove(VirtualCube cube, CubeMove move)
        {
            foreach (var cycle in move.CornerCycles)
            {
                CycleCorners(cube.Corners, cycle);
            }
            foreach (var cycle in move.EdgeCycles)
            {
                CycleEdges(cube.Edges, cycle);
            }
            foreach (var cycle in move.EdgeCubieCycles)
            {
                CycleEdgeCubies(cube.Edges, cycle);
            }
            foreach (var cycle in move.CenterCycles)
            {
                CycleCenters(cube.Centers, cycle);
            }
        }

        private static void CycleCorners(Corner[] corners, Tuple<CornerPiece, int>[] cycle)
        {
            var temp = corners[(int)cycle[3].Item1];

            corners[(int)cycle[2].Item1].ChangeOrientation(cycle[2].Item2);
            corners[(int)cycle[3].Item1] = corners[(int)cycle[2].Item1];

            corners[(int)cycle[1].Item1].ChangeOrientation(cycle[1].Item2);
            corners[(int)cycle[2].Item1] = corners[(int)cycle[1].Item1];

            corners[(int)cycle[0].Item1].ChangeOrientation(cycle[0].Item2);
            corners[(int)cycle[1].Item1] = corners[(int)cycle[0].Item1];

            temp.ChangeOrientation(cycle[3].Item2);
            corners[(int)cycle[0].Item1] = temp;
        }

        private static void CycleEdges(Edge[] edges, Tuple<EdgePiece, int>[] cycle)
        {
            var temp = edges[(int)cycle[3].Item1];

            edges[(int)cycle[2].Item1].ChangeOrientation(cycle[2].Item2);
            edges[(int)cycle[3].Item1] = edges[(int)cycle[2].Item1];

            edges[(int)cycle[1].Item1].ChangeOrientation(cycle[1].Item2);
            edges[(int)cycle[2].Item1] = edges[(int)cycle[1].Item1];

            edges[(int)cycle[0].Item1].ChangeOrientation(cycle[0].Item2);
            edges[(int)cycle[1].Item1] = edges[(int)cycle[0].Item1];

            temp.ChangeOrientation(cycle[3].Item2);
            edges[(int)cycle[0].Item1] = temp;
        }

        private static void CycleEdgeCubies(Edge[] edges, Tuple<EdgeCubie, int>[] cycle)
        {
            var temp = edges[(int)cycle[3].Item1.Piece].Cubies[cycle[3].Item2];

            edges[(int)cycle[2].Item1.Piece].Cubies[cycle[2].Item2].ChangeOrientation(cycle[2].Item1.Orientation);
            edges[(int)cycle[3].Item1.Piece].Cubies[cycle[3].Item2] = edges[(int)cycle[2].Item1.Piece].Cubies[cycle[2].Item2];

            edges[(int)cycle[1].Item1.Piece].Cubies[cycle[1].Item2].ChangeOrientation(cycle[1].Item1.Orientation);
            edges[(int)cycle[2].Item1.Piece].Cubies[cycle[2].Item2] = edges[(int)cycle[1].Item1.Piece].Cubies[cycle[1].Item2];

            edges[(int)cycle[0].Item1.Piece].Cubies[cycle[0].Item2].ChangeOrientation(cycle[0].Item1.Orientation);
            edges[(int)cycle[1].Item1.Piece].Cubies[cycle[1].Item2] = edges[(int)cycle[0].Item1.Piece].Cubies[cycle[0].Item2];

            temp.ChangeOrientation(cycle[3].Item1.Orientation);
            edges[(int)cycle[0].Item1.Piece].Cubies[cycle[0].Item2] = temp;
        }

        private static void CycleCenters(Center[] centers, Tuple<CenterPiece, int>[] cycle)
        {
            var temp = centers[(int)cycle[3].Item1].Cubies[cycle[3].Item2];

            centers[(int)cycle[3].Item1].Cubies[cycle[3].Item2] = centers[(int)cycle[2].Item1].Cubies[cycle[2].Item2];
            centers[(int)cycle[2].Item1].Cubies[cycle[2].Item2] = centers[(int)cycle[1].Item1].Cubies[cycle[1].Item2];
            centers[(int)cycle[1].Item1].Cubies[cycle[1].Item2] = centers[(int)cycle[0].Item1].Cubies[cycle[0].Item2];
            centers[(int)cycle[0].Item1].Cubies[cycle[0].Item2] = temp;
        }
    }
}
