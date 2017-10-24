using PuzzleImageGenerator.Shared.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace PuzzleImageGenerator.Kilo.Painter
{
    public class KiloImage
    {
        List<Piece.Corner> Pieces = new List<Piece.Corner>();
        KiloImageProp Properties;

        public KiloImage(KiloImageConfiguration configs)
        {
            Properties = new KiloImageProp(configs);
            CreatePieces();
        }

        public void CreatePieces()
        {
            Enumerable.Range(0, 5)
                .ToList()
                .ForEach(pieceNum =>   
                    Pieces.Add(new Piece.Corner(Properties, pieceNum))
                );
        }

        public string GetSvgText()
        {
            var svgText = SvgHelper.GetHeader(Properties);

            foreach (var piece in Pieces)
            {
                foreach (var sticker in piece.Stickers)
                {
                    svgText += SvgHelper.GetPolygonText(sticker.Coords, fill: sticker.Color);
                }
            }

            svgText += SvgHelper.GetFooter();
            return svgText;
        }
    }
}
