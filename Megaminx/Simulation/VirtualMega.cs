using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Mega.Simulation
{
    public class VirtualMega
    {
        string[] CornerStickers;
        string[] EdgeStickers;
        string[] CenterStickers;

        public VirtualMega(MegaImageConfiguration configs)
        {
            CleanMega();
            if (configs.Moves != null)
            {
                PreformAlg(configs.Moves, false);
                configs.StickerDefs = getDefs();
            } else if (configs.Case != null)
            {

                PreformAlg(configs.Case, true);
                configs.StickerDefs = getDefs();
            }
        }

        public string getDefs()
        {
            return CenterStickers[0] + ";" + EdgeStickers[0] + EdgeStickers[5] + "," + EdgeStickers[1] + EdgeStickers[10] + "," + EdgeStickers[2] +
                       EdgeStickers[15] + "," + EdgeStickers[3] + EdgeStickers[20] + "," + EdgeStickers[4] + EdgeStickers[25] + ";" + CornerStickers[0] +
                       CornerStickers[9] + CornerStickers[10] + "," + CornerStickers[1] + CornerStickers[14] + CornerStickers[15] + "," + CornerStickers[2] +
                       CornerStickers[19] + CornerStickers[20] + "," + CornerStickers[3] + CornerStickers[24] + CornerStickers[25] + "," + CornerStickers[4] +
                       CornerStickers[29] + CornerStickers[5];

        }

        private void PreformAlg(string algString, bool invert)
        {
            var moves = ParseAlg(algString);
            foreach (var move in invert ? moves.Reverse() : moves)
            {
                var turnAmount = (move.Contains('2') ? 2 : 1 ) * (move.Contains('\'') ? -1 : 1) * (invert ? -1 : 1);
                var moveType = move.Replace("\'", "").Replace("2", "");
                switch (moveType)
                {
                    case "r":
                        PreformMove(new Moves.FrMove(), turnAmount);
                        break;
                    case "fr":
                        PreformMove(new Moves.FrMove(), turnAmount);
                        break;
                    case "br":
                        PreformMove(new Moves.BrMove(), turnAmount);
                        break;
                    case "l":
                        PreformMove(new Moves.FlMove(), turnAmount);
                        break;
                    case "fl":
                        PreformMove(new Moves.FlMove(), turnAmount);
                        break;
                    case "bl":
                        PreformMove(new Moves.BlMove(), turnAmount);
                        break;
                    case "u":
                        PreformMove(new Moves.UMove(), turnAmount);
                        break;
                    case "f":
                        PreformMove(new Moves.FMove(), turnAmount);
                        break;
                    default:
                        break;
                }
            }

        }

        private string[] ParseAlg(string alg)
        {
            var moves = new List<string>();
            alg = alg.Replace(" ", "");
            alg = alg.ToLower();
            var charsAllowed = new[] { 'u', 'f', 'r', 'l', 'b' };
            var appendAllowed = new[] { 'r', 'l' };

            var move = "";
            foreach (var algChar in alg.ToCharArray())
            {
                if(move.Length > 0 && charsAllowed.Contains(algChar) && !(appendAllowed.Contains(algChar) && move.Last() == 'b'))
                {
                    moves.Add(move);
                    move = "";
                }
                move += algChar;
            }
            moves.Add(move);
            return moves.ToArray();
        }

        private void CleanMega()
        {
            var faceTypes = new[] { "u", "f", "fl", "bl", "br", "fr", "k", "k", "k", "k", "k", "k" }; // k is a place holder value for future definition of bottom faces, currently they will apear black
            CornerStickers = faceTypes.SelectMany(i => new[] { i, i, i, i, i }).ToArray();
            EdgeStickers = (string[]) CornerStickers.Clone();
            CenterStickers = (string[]) faceTypes.Clone();
        }

        private void PreformMove(Moves.Move move, int turnAmount)
        {
            foreach (var cycle in move.CornerCycles)
            {
                CornerStickers = CycleStickers(cycle, CornerStickers, turnAmount);
            }

            foreach (var cycle in move.EdgeCycles)
            {
                EdgeStickers = CycleStickers(cycle, EdgeStickers, turnAmount);
            }
        }

        private string[] CycleStickers(int[] cycle, string[] stickers, int turnAmount)
        {
            var CycledStickers = (string[]) stickers.Clone();
            for (int cycleIndex = 0; cycleIndex < cycle.Length; cycleIndex++)
            {
                CycledStickers[cycle[(cycleIndex + 5 + turnAmount) % 5]] = stickers[cycle[cycleIndex]];
            }
            return CycledStickers;
        }
    }
}
