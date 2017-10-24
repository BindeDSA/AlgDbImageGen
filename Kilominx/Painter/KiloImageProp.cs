using System;
using System.Collections.Generic;
using System.Linq;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Kilo.Painter
{
    public class KiloImageProp : ImageProp
    {
        public const double LARGEANGLE = Math.PI * 72 / 180; // Angle between corners

        public string[][] CornerStickerDefs { get; private set; }

        public KiloImageProp(KiloImageConfiguration configs)
            : base(configs)
        {
            SetStickerDefs(configs.Scheme, configs.StickerDefs);

            ImageLength = configs.ImageLength;

            SetDistances();

            ImageSize = new Tuple<double, double>(ImageLength, LongSideDist + ShortSideDist); // Both distance add up to the height of the pentagon
            Center = new CoordPair(ImageLength / 2, LongSideDist); // LongSideDist is the distance from the top of the image to the center of the pentagon




        }

        private void SetStickerDefs(string schemeString, string stickerDefsString)
        {
            var scheme = new ColorScheme();

            if (schemeString != null)
            {
                schemeString = schemeString.Replace(" ", "")
                                           .Replace("%20", "");
                scheme = new ColorScheme(schemeString.Split('-'));
            }

            // default solved cube
            var cornerFaces = Enumerable.Range(1, 5)
                        .Select(faceNum => new[] { ColorScheme.Faces[0], ColorScheme.Faces[faceNum], ColorScheme.Faces[(faceNum + 1) % 5] })
                        .ToArray();

            // sticker formats expected in format: CharCharChar,CharCharChar,... where Char represents a face
            if (stickerDefsString == null)
            {
                stickerDefsString = "uffl,uflbl,ublbr,ubrfr,ufrf";
            }
                stickerDefsString = stickerDefsString.ToLower()
                                                     .Replace("br", "R")
                                                     .Replace("bl", "L")
                                                     .Replace("fr", "r")
                                                     .Replace("fl", "l");

                CornerStickerDefs = stickerDefsString
                    .Split(',')
                    .Select(PieceDef => PieceDef.ToCharArray()
                        .Select(stickerFace => scheme.GetFace(stickerFace))
                        .ToArray())
                    .ToArray();
        }

        private void SetDistances()
        {
            
            LongSideDist = (ImageLength * 0.5) / Math.Cos(LARGEANGLE * 0.25); // length from corner tip to center
            LongFaceDist = LongSideDist * 0.8; // 20% of full pentagon is side stickers, 80% is face.
            
            ShortSideDist = Math.Cos(LARGEANGLE / 2) * LongSideDist; // length from corner edge to center
            ShortFaceDist = ShortSideDist * 0.8;
        }
    }
}
