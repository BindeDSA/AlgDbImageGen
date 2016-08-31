using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Mega.Simulation
{
    class Megaminx
    {
        char[] CornerStickers;
        char[] EdgeStickers;

        public Megaminx()
        {

        }

        private void PreformMove(Moves.Move move)
        {

        }

        static private void CycleStickers(int[] cycle, char[] stickers)
        {
            var CycledStickers = stickers.Clone()
                
                ;
            for (int stickerIndex = 0; stickerIndex < cycle.Length; stickerIndex++)
            {
                CycledStickers = 
            }
        }
    }
}
