using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Four
{
    public class FourImageGenerator
    {
        public static string Generate(IDictionary<string, string> input)
        {
            var config = new FourImageConfiguration(input);

            new Simulation.VirtualCube(config);

            var image = new Painter.FourImage(config);

            return image.GetSvgText();
        }
    }
}
