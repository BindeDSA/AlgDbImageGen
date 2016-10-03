using System;
using System.Collections.Generic;
using PuzzleImageGenerator.Shared;
using PuzzleImageGenerator.Shared.Helpers;

namespace PuzzleImageGenerator.Skewb.Painter
{
    public class SkewbImage
    {
        Face[] Faces;
        SkewbImageProp Properties;

        public SkewbImage(SkewbImageConfiguration configs)
        {
            Properties = new SkewbImageProp(configs);
            CreateFacees(configs);
        }

        private void CreateFacees(SkewbImageConfiguration configs)
        {
            var stickerColors = ParseDefs(configs.StickerDefs);
            if (stickerColors.Length == 6 || (Properties.DFace && stickerColors.Length == 5))
            {
                var tempFaces = new List<Face>();
                for (int i = 0; i < 3; i++)
                {
                    var angle = Math.PI * 120 / 180 * i;
                    tempFaces.Add(new Face(stickerColors[i], angle, Properties.Center, Properties));
                    if (i != 0 || Properties.DFace)
                        tempFaces.Add(new Face(stickerColors[i + 3], (i == 0 ? 0 : Math.PI * 240 / 180)
                            , CoordPair.CartesianFromPolar(Properties.LongFaceDist, angle, Properties.Center), Properties));

                }
                Faces = tempFaces.ToArray();
            }
        }
        private string[][] ParseDefs(string defs)
        {
            var tempStickerColors = new List<string[]>();
            var tempFaceColors = new List<string>();
            int Counter = 1;
            foreach (var character in defs)
            {
                tempFaceColors.Add(ColorHelper.GetColorNameFromCharacter(character));
                if (Counter % 5 == 0)
                {
                    Counter = 0;
                    tempStickerColors.Add(tempFaceColors.ToArray());
                    tempFaceColors.Clear();
                }

                Counter++;
            }
            var Stickers = tempStickerColors.ToArray();
            Stickers.ReverseCycle(0, 1, 2); // Cycle adjusts face order
            return Stickers;
        }

        public string GetSvgText()
        {

            var svgText = "";
            svgText += SvgHelper.GetHeader(Properties);

            foreach (var face in Faces)
            {
                foreach (var sticker in face.Stickers)
                {
                    svgText += SvgHelper.GetPolygonText(sticker.Coordinates, Properties, fill: sticker.Color);
                }
            }

            svgText += SvgHelper.GetFooter();
            return svgText;
        }
    }
}
