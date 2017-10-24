using PuzzleImageGenerator.Four.Simulation.Enums;
using System;
using System.Linq;

namespace PuzzleImageGenerator.Four.Simulation.Pieces
{
    public class Corner
    {
        public CornerPiece Piece { get; set; }
        public int PieceNum { get { return (int)Piece; } }
        public int Orientation { get; set; }

        public Corner(CornerPiece piece, int orientation = 0)
        {
            Piece = piece;
            Orientation = orientation;
        }

        public void ChangeOrientation(int orientationChane)
        {
            Orientation = (Orientation + orientationChane + 3) % 3;
        }

        public FaceType GetStickerFace(int stickerNum)
        {
            var faceTypeStrings = ((FaceType[])Enum.GetValues(typeof(FaceType))).Select(i => new Tuple<string, FaceType>(i.ToString(), i)).ToArray();
            return faceTypeStrings.Where(i => i.Item1[0] == Piece.ToString()[(stickerNum - Orientation + 3) % 3])
                                            .Select(i => i.Item2)
                                            .First();
        }
    }
}