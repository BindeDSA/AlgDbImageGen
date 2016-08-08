using System;

namespace PuzzleImageGenerator.Shared
{
    public abstract class ImageProp
    {
        public double ImageLength { get; protected set; }
        public double LongFaceDist { get; protected set; }
        public double ShortFaceDist { get; protected set; }
        public double LongSideDist { get; protected set; }
        public double ShortSideDist { get; protected set; }
        public string Stage { get; protected set; }
        public CoordPair Center { get; protected set; }
        public Tuple<double, double> ImageSize { get; protected set; }

        protected ImageProp(ImageConfiguration configs)
        {
            ImageLength = configs.ImageLength;
            Stage = configs.Stage;
        }
    }
}
