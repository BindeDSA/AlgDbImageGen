using System;

namespace PuzzleImageGenerator.Shared
{
    public abstract class ImageProp
    {
        public double ImageLength { get; set; }
        public double LongFaceDist { get; set; }
        public double ShortFaceDist { get; set; }
        public double LongSideDist { get; set; }
        public double ShortSideDist { get; set; }
        public string Stage { get; set; }
        public CoordPair Center { get; set; }
        public ImageConfiguration Configs;
        public Tuple<double, double> ImageSize { get; set; }

        public ImageProp(ImageConfiguration configs)
        {
            ImageLength = configs.ImageLength;
            Stage = configs.Stage;
            Configs = configs;
        }
    }
}
