using PuzzleImageGenerator.Shared;
using System;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Kilo.Painter.Piece

{
    public class Corner
    {
        public Sticker.Sticker[] Stickers { get; protected set; }
        private double _centerAngle;
        private KiloImageProp _properties;

        public Corner(KiloImageProp properties, int pieceNum)
        {
            _properties = properties;
            _centerAngle = KiloImageProp.LARGEANGLE * (pieceNum + 0.5);
            SetStickers(pieceNum);
        }

        private void SetStickers(int pieceNum)
        {
            var stickerColors = _properties.CornerStickersDefs[pieceNum];

            Stickers = new Sticker.Sticker[] { new Sticker.Face(_properties, _centerAngle, stickerColors[0]),
                                               new Sticker.Side (_properties, _centerAngle, stickerColors[1], -1),
                                               new Sticker.Side (_properties, _centerAngle, stickerColors[2], 1)
            };
        }


    }
}
