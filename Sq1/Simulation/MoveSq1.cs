using System.Collections.Generic;
using System.Linq;

namespace PuzzleImageGenerator.Sq1.Simulation
{
    public class MoveSq1
    {
        public static bool ApplyAlg(string moves, VirtualSq1 sq1, bool invert = false)
        {
            var Valid = true;
            var adjustments =
                moves
                .Replace(" ", "")
                .Replace("%20", "")
                .Split('/');

            if (invert)
                adjustments = adjustments.Reverse().ToArray();

            for (int i = 0; i < adjustments.Length; i++)
            {
                string adjustment = adjustments[i];
                if (!adjustment.Equals(""))
                {
                        adjustment = adjustment.Replace("(", "");
                        adjustment = adjustment.Replace(")", "");

                        var adjustStrings = adjustment.Split(',');
                        var adjustInts = new List<int>();

                        foreach (var num in adjustStrings)
                        {
                            var parsedInt = 0;

                            if (int.TryParse(num, out parsedInt))
                                adjustInts.Add(invert ? parsedInt * -1 : parsedInt);
                            else
                                Valid = false;
                        }

                        if (adjustInts.Count == 2)
                            AdjustLayers(adjustInts.ToArray(), sq1);
                        else
                            Valid = false;

                }

                if (i != adjustments.Length - 1 && !Slash(sq1)) // note: Slash() performs action on cube.
                    Valid = false;
            }
            return Valid;
        }

        public static bool Slash(VirtualSq1 sq1)
        {
            if (!sq1.ValidState())
                return false;

            List<Piece>[] swap = { new List<Piece>(), new List<Piece>() };
            for (int i = 0; i < sq1.Faces.Length; i++)
            {
                for (int j = 0; j < sq1.Faces[i].Count; j++)
                {
                    var piece = sq1.Faces[i].ElementAt(j);
                    if (piece.Position > 5)
                    {
                        swap[i].Add(piece);
                        sq1.Faces[i].Remove(piece);
                        j--;
                    }
                }
            }

            sq1.Faces[1] = sq1.Faces[1].Concat(swap[0]).ToList();
            sq1.Faces[0] = sq1.Faces[0].Concat(swap[1]).ToList();
            return true;
        }

        public static void AdjustLayers(int[] adjust, VirtualSq1 sq1)
        {
            for (int i = 0; i < adjust.Length; i++)
                foreach (Piece piece in sq1.Faces[i])
                    piece.Position = (piece.Position + adjust[i] + 12) % 12;
        }

    }
}
