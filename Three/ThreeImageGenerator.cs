using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Three
{
    public class ThreeImageGenerator
    {
        public static string Generate(IDictionary<string, string> input)
        {
            var config = new ThreeImageConfiguration(input);

            new Simulation.VirtualCube(config);

            var image = new Painter.ThreeImage(config);

            return image.GetSvgText();
        }
    }
}
