using System;
using System.Collections.Generic;
using System.Linq;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Mega.Painter
{
    public class MegaImageProp : ImageProp
    {
        public const double LARGEANGLE = Math.PI * 72 / 180;
        public const double SMALLANGLE = Math.PI * 30.533 / 180;

        public double CenterDist { get; private set; }
        public string CenterColor { get; private set; }
        public string[][] EdgeStickerDefs { get; private set; }
        public string[][] CornerStickerDefs { get; private set; }
        public double SideAngle { get; private set; }

        public MegaImageProp(MegaImageConfiguration configs)
            : base(configs)
        {
            SetStickerDefs(configs.Scheme, configs.StickerDefs);

            ImageLength = configs.ImageLength;

            var centerX = ImageLength / 2;

            LongSideDist = centerX / Math.Cos(LARGEANGLE / 4);
            LongFaceDist = 0.8 * LongSideDist;
            CenterDist = LongFaceDist * 0.4;
            var belowCenterY = Math.Cos(LARGEANGLE / 2) * LongSideDist;

            Center = new CoordPair(centerX, LongSideDist);
            ImageSize = new Tuple<double, double>(ImageLength, Center.Y + belowCenterY);

            ShortFaceDist = Math.Sin(Math.PI * 54 / 180) * LongFaceDist / Math.Sin(Math.PI * 126 / 180 - SMALLANGLE);

            var edgeHalfWidth = Math.Sin(LARGEANGLE / 2) * CenterDist * 0.75;
            ShortSideDist = Math.Sqrt(Math.Pow(edgeHalfWidth, 2) + Math.Pow(belowCenterY, 2));
            SideAngle = Math.Acos(belowCenterY / ShortSideDist);
        }


        private void SetStickerDefs(string schemeString, string stickerDefsString)
        {
            var scheme = new ColorScheme();


            if (schemeString != null)
            {
                schemeString = schemeString.Replace(" ",  "")
                                           .Replace("%20",  "");
                scheme = new ColorScheme(schemeString.Split(','));

            }
            

            // default solved cube
            if (stickerDefsString == null)
                stickerDefsString = "u;uf,ufl,ubl,ubr,ufr;uffl,uflbl,ublbr,ubrfr,ufrf";


            CenterColor = scheme.GetFace(char.Parse(stickerDefsString.Split(';')[0]));

            stickerDefsString = stickerDefsString.ToLower()
                                                     .Replace("br", "R")
                                                     .Replace("bl", "L")
                                                     .Replace("fr", "r")
                                                     .Replace("fl", "l");

            EdgeStickerDefs = stickerDefsString
                .Split(';')[1]
                .Split(',')
                .Select(PieceDef => PieceDef.ToCharArray()
                    .Select(stickerFace => scheme.GetFace(stickerFace))
                    .ToArray())
                .ToArray();

            CornerStickerDefs = stickerDefsString
                .Split(';')[2]
                .Split(',')
                .Select(PieceDef => PieceDef.ToCharArray()
                    .Select(stickerFace => scheme.GetFace(stickerFace))
                    .ToArray())
                .ToArray();

        }

    }

}
