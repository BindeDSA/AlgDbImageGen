using PuzzleImageGenerator.Shared;
using PuzzleImageGenerator.Shared.Helpers;
using System;

namespace PuzzleImageGenerator.Sq1.Painter
{
    public class Sq1ImageProp : ImageProp
    {
        public double SideSize { get; set; }
        public double FaceSize { get; private set; }
        public double XOffset { get; private set; }
        public double YOffset { get; private set; }
        public bool PlaceDOnRight { get; private set; }
        public int SliceSpacer { get; private set; }
        public int FaceSpacer { get; private set; }

        public Sq1ImageProp(Sq1ImageConfiguration configs, bool cubeshape)
            :base(configs)
        {
            SliceSpacer = configs.SliceSpacer;
            FaceSpacer = configs.FaceSpacer;
            
            XOffset = configs.PlaceDOnRight ? FaceSpacer + ImageLength : 0;
            YOffset = !configs.PlaceDOnRight ? FaceSpacer + ImageLength : 0;

            SideSize = cubeshape 
                ? ImageLength
                : MathHelper.GetHypotenuse(ImageLength);

            FaceSize = configs.Stage == "cubeshape"
                ? SideSize
                : SideSize * 0.9;

            ImageSize = !configs.PlaceDOnRight       
                ? new Tuple<double, double>(2 * (ImageLength + SliceSpacer) + FaceSpacer, ImageLength)
                : new Tuple<double, double>(ImageLength + SliceSpacer, (2 * ImageLength) + FaceSpacer);

            var sideWidth = SideSize * 0.05; 

            LongSideDist = MathHelper.GetHypotenuse(SideSize);
            LongFaceDist = FaceSize * Math.Sin(Math.PI * 45 / 180);
            ShortFaceDist = FaceSize / (Math.Cos(Math.PI * 15 / 180) * 2);
            ShortSideDist = SideSize / 2 / Math.Cos(Math.PI * 15 / 180);

            PlaceDOnRight = configs.PlaceDOnRight;
        }
    }
}
