using PuzzleImageGenerator.Three.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using PuzzleImageGenerator.Three.Simulation.Enums;
using PuzzleImageGenerator.Three.Simulation.Pieces;
using PuzzleImageGenerator.Three.Simulation.Move;

namespace PuzzleImageGenerator.Three.Simulation
{
    public class VirtualCube
    {
        public Edge[] Edges { get; set; }
        public Corner[] Corners { get; set; }
        public CenterPiece[] Centers { get; set; }
        public int CenterCoord { get { return Corners[0].PieceNum * 6 + Corners[1].PieceNum; } }
        public int CornerOriCoord
        {
            get
            {
                return Corners.Take(7)
                              .Select((corner, i) => corner.Orientation * (int)Math.Pow(3, i))
                              .Sum();
            }
        }
        public int CornerPermCoord
        {
            get
            {
                var coordTotal = 0;
                for (int i = 1; i < 8; i++)
                {
                    coordTotal += MathFunc.Factorial(i) * Corners.Take(i)
                                                                 .Count(corner => corner.PieceNum > Corners[i].PieceNum);
                }
                return coordTotal;
            }
        }
        public int EdgeOriCoord
        {
            get

            {
                return Edges.Take(11)
                            .Select((edge, i) => edge.Orientation * (int)Math.Pow(2, i))
                            .Sum();
            }
        }
        public int EdgePermCoord
        {
            get
            {
                var coordTotal = 0;
                for (int i = 1; i < 12; i++)
                {
                    coordTotal += MathFunc.Factorial(i) * Edges.Take(i)
                                                               .Count(edges => edges.PieceNum > Edges[i].PieceNum);
                }
                return coordTotal;
            }
        }

        public VirtualCube()
        {
            ResetCenters();
            ResetCorners();
            ResetEdges();
        }

        public VirtualCube(ThreeImageConfiguration configs)
        {
            ResetCenters();
            ResetCorners();
            ResetEdges();

            if (configs.Moves != null)
            {
                CubeMove.ApplAlg(this, configs.Moves);
            }

            if (configs.Case != null)
            {
                CubeMove.ApplAlg(this, configs.Case, true);
            }

            configs.Cube = this;
        }

        public void ResetCenters()
        {
            Centers = (CenterPiece[])Enum.GetValues(typeof(CenterPiece));
        }

        public void ResetCorners()
        {
            var corners = new List<Corner>();
            foreach (CornerPiece piece in Enum.GetValues(typeof(CornerPiece)))
            {
                corners.Add(new Corner(piece));
            }
            Corners = corners.ToArray();
        }

        public void ResetEdges()
        {
            var edges = new List<Edge>();
            foreach (EdgePiece piece in Enum.GetValues(typeof(EdgePiece)))
            {
                edges.Add(new Edge(piece));
            }
            Edges = edges.ToArray();
        }

        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var compareCube = (VirtualCube)obj;

            if (CenterCoord != compareCube.CenterCoord)
            {
                return false;
            }
            else if (CornerOriCoord != compareCube.CornerOriCoord)
            {
                return false;
            }
            else if (CornerPermCoord != compareCube.CornerPermCoord)
            {
                return false;
            }
            else if (EdgeOriCoord != compareCube.EdgeOriCoord)
            {
                return false;
            }
            else if (EdgePermCoord != compareCube.EdgePermCoord)
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(VirtualCube a, VirtualCube b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return a.Equals(b);
        }

        public static bool operator !=(VirtualCube a, VirtualCube b)
        {
            return !(a == b);
        }

    }
}