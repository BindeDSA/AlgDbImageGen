using System.Collections.Generic;

namespace PuzzleImageGenerator.Skewb
{
    public static class SkewbImageGenerator
    {
        public static string Generate(IDictionary<string, string> input)
        {
            var config = new SkewbImageConfiguration(input);

            new Simulation.VirtualSkewb(config);

            var image = new Painter.SkewbImage(config);

            return image.GetSvgText();
        }
    }
}