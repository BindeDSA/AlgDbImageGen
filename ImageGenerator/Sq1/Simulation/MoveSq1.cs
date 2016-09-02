using System;
using System.Collections.Generic;
using System.Linq;

namespace PuzzleImageGenerator.Sq1.Simulation
{
    public class MoveSq1
    {
        public static bool ApplyAlg(string moves, VirtualSq1 sq1, bool invert = false)
        {
            var isValid = true;
            var faceAdjustments = moves.Replace("%20", "").Replace(" ", "").Split('/');

            if (invert)
                faceAdjustments = faceAdjustments.Reverse().ToArray();

            for (int i = 0; i < faceAdjustments.Length; i++)
            {
                if (i != 0)
                {
                    Slash(sq1);
                }
                var adjustment = CleanAdjustment(faceAdjustments[i]);
                if (adjustment != "")
                {
                    var adjustInts = new List<int>();

                    foreach (var num in adjustment.Split(','))
                    {
                        var parsedInt = 0;

                        if (int.TryParse(num, out parsedInt))
                            adjustInts.Add(invert ? parsedInt * -1 : parsedInt);
                        else
                            isValid = false;
                    }

                    if (adjustInts.Count == 2)
                        AdjustLayers(adjustInts.ToArray(), sq1);
                    else
                        isValid = false;
                }

                if (i != faceAdjustments.Length - 1 && sq1.ValidState())
                    isValid = false;


            }

            return isValid;
        }

        static string CleanAdjustment(string v)
        {
            return v.Replace("(", "").Replace(")", "");
        }

        public static void Slash(VirtualSq1 sq1)
        {
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
        }

        public static void AdjustLayers(int[] adjust, VirtualSq1 sq1)
        {
            for (int i = 0; i < adjust.Length; i++)
                foreach (Piece piece in sq1.Faces[i])
                    piece.Position = (piece.Position + adjust[i] + 12) % 12;
        }
    }
}
