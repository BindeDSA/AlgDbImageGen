using System.Collections.Generic;

namespace PuzzleImageGenerator.Sq1
{
    public static class Sq1ImageGenerator
    {
        public static string Generate(IDictionary<string, string> input)
        {
            var config = new Sq1ImageConfiguration(input);

            new Simulation.VirtualSq1(config);

            var image = new Painter.Sq1Image(config);

            return image.GetSvgText();
        }
    }
}
