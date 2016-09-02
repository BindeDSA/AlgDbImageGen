using PuzzleImageGenerator.Mega.Painter.Piece;
using PuzzleImageGenerator.Shared;
using PuzzleImageGenerator.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Mega.Painter
{
    class MegaImage
    {
        private List<Piece.Piece> Pieces = new List<Piece.Piece>();
        private MegaImageProp Properties;
        public MegaImage(MegaImageConfiguration configs)
        {
            Properties = new MegaImageProp(configs);
            CreatePieces();
        }

        public void CreatePieces()
        {
            Pieces.Add(new Center(Properties));
            Enumerable.Range(0, 5).ToList().ForEach(i => Pieces.AddMany(new Corner(Properties, i), new Edge(Properties, i)))    ;
        }

        public string GetSvgText()
        {
            var svgText = "";
            svgText += SvgHelper.GetHeader(Properties);
            foreach (var piece in Pieces)
            {
                foreach(var sticker in piece.Stickers)
                {

                    svgText += SvgHelper.GetPolygonText(sticker.Coords, Properties, fill: sticker.Color);
                }

            }
            svgText += SvgHelper.GetFooter();
            return svgText;
        }
    }
}
