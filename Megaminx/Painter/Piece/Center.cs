using PuzzleImageGenerator.Shared;
using System;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Mega.Painter.Piece
{
    public class Center : Piece
    {
        public Center(MegaImageProp properties)
        {
            GetSticker(properties);
        }
        public void GetSticker(MegaImageProp properties)
        {
            var tempCoords = new List<CoordPair>();
            var angle = MegaImageProp.LARGEANGLE / 2;
            while (angle < (Math.PI * 2))
            {
                tempCoords.Add(CoordPair.CartesianFromPolar(properties.CenterDist, angle, properties.Center));
                angle += MegaImageProp.LARGEANGLE;
            }
            Stickers = new[] { new Sticker(tempCoords, properties.CenterColor)};
        }
    }
}
