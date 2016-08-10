using PuzzleImageGenerator.Shared;
using System;
using System.Linq;

namespace PuzzleImageGenerator.Kilo.Painter.Piece.Sticker
{
    class Face : Sticker
    {
        public Face(KiloImageProp prop, double pieceAngle, string color) :
            base(prop, pieceAngle, color)
        {
            PolarInputs = new Tuple<double, double>[] { new Tuple<double, double>(prop.LongFaceDist, pieceAngle),
                                                            new Tuple<double, double>(prop.ShortFaceDist, pieceAngle - KiloImageProp.LARGEANGLE / 2),
                                                            new Tuple<double, double>(0,0),
                                                            new Tuple<double, double>(prop.ShortFaceDist, pieceAngle + KiloImageProp.LARGEANGLE / 2)
                };
        }
    }
}
