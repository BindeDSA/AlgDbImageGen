using PuzzleImageGenerator.Shared;
using System;

namespace PuzzleImageGenerator.Skewb.Painter
{
    class SkewbImageProp : ImageProp
    {
        public bool DFace { get; protected set; }
        public ColorScheme ColorScheme;

        public SkewbImageProp(SkewbImageConfiguration configs)
            : base(configs)
        {
            DFace = configs.Dface;

            ShortFaceDist = (ImageLength / 8) / Math.Cos(Math.PI * 30 / 180);
            LongFaceDist = ShortFaceDist * 2;

            var yAboveCenter = (ImageLength / 8) * Math.Tan(Math.PI * 30 / 180) * 6;
            var yBelowCenter = LongFaceDist * (DFace ? 2 : 1);
            ImageSize = new Tuple<double, double>(ImageLength, yAboveCenter + yBelowCenter);

            Center = new CoordPair(ImageLength / 2, yAboveCenter);

            AddColorScheme(configs.ColorScheme);
        }

        private void AddColorScheme(string schemeString)
        {
            if (schemeString != null)
            {
                schemeString = schemeString.Replace(" ", "")
                                           .Replace("%20", "");
                ColorScheme = new ColorScheme(schemeString.Split('-'));

            }
            else
            {
                ColorScheme = new ColorScheme();
            }
        }
    }
}
