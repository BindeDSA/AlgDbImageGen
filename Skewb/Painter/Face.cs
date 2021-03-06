﻿using System;
using System.Linq;
using System.Collections.Generic;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Skewb.Painter
{
    class Face
    {
        public Sticker[] Stickers { get; set; } // last sticker is the center

        public Face(char[] stickersColors, double angle, CoordPair start, SkewbImageProp properties)
        {
            var tempStickers = new List<Sticker>();

            var large = true;
            foreach (var color in stickersColors.Take(4))
            {
                tempStickers.Add(new Sticker(color, start, angle, large, properties));
                start = CoordPair.CartesianFromPolar(properties.LongFaceDist, angle, start);
                angle -= large ? Math.PI * 120 / 180 : Math.PI * 60 / 180;
                large = !large;
            }

            tempStickers.Add(new Sticker(stickersColors.Last(), tempStickers.ToArray(), properties));
            Stickers = tempStickers.ToArray();
        }
    }
}
