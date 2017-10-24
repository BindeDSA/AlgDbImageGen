using PuzzleImageGenerator.Three;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Two
{
    public class TwoImageGenerator
    {
        public static string Generate(IDictionary<string, string> input)
        {
            var config = new ThreeImageConfiguration(input);

            new Three.Simulation.VirtualCube(config);

            var image = new Three.Painter.TwoImage(config);

            return image.GetSvgText();
        }
    }
}
