using PuzzleImageGenerator.Three.Simulation.Enums;
using PuzzleImageGenerator.Three.Simulation.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PuzzleImageGenerator.Three.Simulation.Move
{
    class CubeMove
    {
        public CenterPiece[][] CenterCycles { get; set; }
        public Tuple<CornerPiece, int>[][] CornerCycles { get; set; }
        public Tuple<EdgePiece, int>[][] EdgeCycles { get; set; }


        public static void ApplAlg(VirtualCube cube, string alg, bool reverse = false)
        {
            alg = alg.Replace("Uw", "u").Replace("Rw", "r").Replace("Fw", "f").Replace("Dw", "d").Replace("Lw", "l").Replace("Bw", "b");
            var moves = Regex.Matches(alg, @"([uUrRfFdDlLbByxzMES](['23]?)+)").Cast<Match>().Select(m => m.Value).ToArray();
            var moveTuples = ((MoveType[])Enum.GetValues(typeof(MoveType))).Select(i => new Tuple<string, MoveType>(i.ToString(), i)).ToArray();
            if (reverse)
            {
                moves = moves.Reverse().ToArray();
            }
            foreach (String move in moves)
            {
                var moveEnum = moveTuples.Where(i => i.Item1[0] == move[0])
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

        private static void CycleCenters(CenterPiece[] centers, CenterPiece[] cycle)
        {
            var temp = centers[(int)cycle[3]];

            centers[(int)cycle[3]] = centers[(int)cycle[2]];
            centers[(int)cycle[2]] = centers[(int)cycle[1]];
            centers[(int)cycle[1]] = centers[(int)cycle[0]];
            centers[(int)cycle[0]] = temp;
        }
    }
}
