using PuzzleImageGenerator.Four.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using PuzzleImageGenerator.Four.Simulation.Enums;
using PuzzleImageGenerator.Four.Simulation.Pieces;
using PuzzleImageGenerator.Four.Simulation.Move;

namespace PuzzleImageGenerator.Four.Simulation
{
    public class VirtualCube
    {
        public Edge[] Edges { get; set; }
        public Corner[] Corners { get; set; }
        public Center[] Centers { get; set; }

        public VirtualCube()
        {
            ResetCenters();
            ResetCorners();
            ResetEdges();
        }

        public VirtualCube(FourImageConfiguration configs)
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
            var centers = new List<Center>();
            foreach (CenterPiece piece in Enum.GetValues(typeof(CenterPiece)))
            {
                centers.Add(new Center(piece));
            }
            Centers = centers.ToArray();
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
    }
}