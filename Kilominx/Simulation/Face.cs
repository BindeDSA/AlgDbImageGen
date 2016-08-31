using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Kilo.Simulation
{
    class Face
    {
        StickerType[] Stickers;

        public Face(StickerType faceType)
        {
            Stickers = new[] { faceType, faceType, faceType, faceType, faceType };
        }

        public void CycleSticker(bool clockwise)
        {
            if (clockwise)
                Stickers.Cycle();
            else
                Stickers.ReverseCycle();
        }
    }
}
