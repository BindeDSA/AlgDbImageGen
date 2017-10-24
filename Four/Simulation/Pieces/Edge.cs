using PuzzleImageGenerator.Four.Simulation.Enums;
using System;
using System.Linq;

namespace PuzzleImageGenerator.Four.Simulation.Pieces
{
    public class Edge
    {
        public EdgeCubie[] Cubies { get; set; }

        public Edge(EdgePiece piece, int orientation = 0)
        {
            Cubies = new EdgeCubie[] { new  EdgeCubie(piece), new EdgeCubie(piece) };
        }

        public void ChangeOrientation(int orientationChange)
        {
            foreach (var cubie in Cubies)
            {
                cubie.ChangeOrientation(orientationChange);
            }
            if(orientationChange % 2 == 1)
            {
                var temp = Cubies[0];
                Cubies[0] = Cubies[1];
                Cubies[1] = temp;
            }
        }

        public FaceType GetStickerFace(int pieceNum, int stickerNum)
        {
            var faceTypeStrings = ((FaceType[])Enum.GetValues(typeof(FaceType))).Select(i => new Tuple<string, FaceType>(i.ToString(), i)).ToArray();
            return faceTypeStrings.Where(i => i.Item1[0] == Cubies[pieceNum].Piece.ToString()[(stickerNum - Cubies[pieceNum].Orientation + 2) % 2])
                                            .Select(i => i.Item2)
                                            .First();
        }
    }
}
