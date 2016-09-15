using PuzzleImageGenerator.Shared;
using PuzzleImageGenerator.Shared.Helpers;
using System;

namespace PuzzleImageGenerator.Sq1.Painter
{
    public class Sq1ImageProp : ImageProp
    {
        public double SideSize;
        public double FaceSize;
        public double XOffset;
        public double YOffset;
        public bool PlaceDOnRight;
        public int FaceSpacer;
        public double AngleUnits = Math.PI * 15 / 180;

        public Sq1ImageProp(Sq1ImageConfiguration configs, bool cubeshape)
            :base(configs)
        {
            FaceSpacer = configs.FaceSpacer;
            
            XOffset = configs.transform == TransformType.horizontal ? FaceSpacer + ImageLength : 0;
            YOffset = configs.transform == TransformType.horizontal ? 0 : FaceSpacer + ImageLength;

            SideSize = cubeshape 
                ? ImageLength
                : MathHelper.GetHypotenuse(ImageLength);

            FaceSize = configs.Stage == "cubeshape"
                ? SideSize
                : SideSize * Math.Min(100, configs.FaceSize) / 100;

            ImageSize = configs.transform == TransformType.horizontal
                ? new Tuple<double, double>(2 * (ImageLength) + FaceSpacer, ImageLength)
                : new Tuple<double, double>(ImageLength, (2 * ImageLength) + FaceSpacer);
                

            var sideWidth = SideSize * 0.05; 

            LongSideDist = MathHelper.GetHypotenuse(SideSize);
            LongFaceDist = FaceSize * Math.Sin(Math.PI * 45 / 180);
            ShortFaceDist = FaceSize / (Math.Cos(Math.PI * 15 / 180) * 2);
            ShortSideDist = SideSize / 2 / Math.Cos(Math.PI * 15 / 180);
        }
    }
}
