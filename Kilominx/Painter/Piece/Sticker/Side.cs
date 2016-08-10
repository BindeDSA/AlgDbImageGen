using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Kilo.Painter.Piece.Sticker
{
    class Side : Sticker
    {
        public Side(KiloImageProp prop, double pieceAngle, string color, int position) :
            base(prop, pieceAngle, color)
        {
            PolarInputs = new Tuple<double, double>[] { new Tuple<double, double>(prop.LongFaceDist, pieceAngle),
                                                            new Tuple<double, double>(prop.LongSideDist, pieceAngle),
                                                            new Tuple<double, double>(prop.ShortSideDist, pieceAngle + ( position *  KiloImageProp.LARGEANGLE / 2)),
                                                            new Tuple<double, double>(prop.ShortFaceDist, pieceAngle + ( position *  KiloImageProp.LARGEANGLE / 2))
                };
        }
    }
}
