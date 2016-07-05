using System.Collections.Generic;

namespace PuzzleImageGenerator.Sq1.Simulation
{
    public class VirtualSq1
    {
        public List<Piece>[] Faces = { new List<Piece>(), new List<Piece>() };

        public VirtualSq1(Sq1ImageConfiguration configs)
        {
            CleanSq1();
            InitializePieceDefinitions(configs);
        }

        private void InitializePieceDefinitions(Sq1ImageConfiguration configs)
        {
            var isValid = true;

            if (configs.Moves != null)
                isValid = MoveSq1.ApplyAlg(configs.Moves, this);
            else if (configs.Case != null)
                isValid = MoveSq1.ApplyAlg(configs.Case, this, invert: true);

            if (configs.StickerDefs == null)
                configs.StickerDefs = GetPieceDefs();

            if (!isValid)
                CleanSq1();
        }
        
        public void CleanSq1()
        {
            foreach (var face in Faces)
                face.Clear();

            var currPositon = 0;
            for (int i = 0; i < 16; i++)
            {
                var currPiece = new Piece(i, currPositon % 12);
                Faces[i / 8].Add(currPiece);
                currPositon += currPiece.GetWidth();
            }
        }

        public bool ValidState()
        {
            var tempList = new List<int>();
            foreach (var face in Faces)
            {
                foreach (Piece piece in face)
                    tempList.Add(piece.Position);

                if (!(tempList.Contains(0) && tempList.Contains(6)))
                    return false;

                tempList.Clear();
            }
            return true;
        }

        public string GetPieceDefs()
        {
            if (!ValidState())
                CleanSq1();

            MoveSq1.AdjustLayers(new int[] { 0, -1 }, this);
            var PieceDefs = "";

            foreach (var face in Faces)
            {
                for (int i = 0; i < 12; i++)
                    foreach (var piece in face)
                        if (piece.Position == i)
                            PieceDefs += piece.GetDefs() + ",";

                PieceDefs = PieceDefs.Trim(',') + ";";
            }

            return PieceDefs.Trim(';');
        }
    }

}
