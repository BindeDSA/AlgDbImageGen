using System.Collections.Generic;

namespace PuzzleImageGenerator.Mega
{
    public class MegaImageGenerator
    {
        public static string Generate(IDictionary<string, string> input)
        {
            var config = new MegaImageConfiguration(input);

            new Simulation.VirtualMega(config);
            
            return new Painter.MegaImage(config)
                .GetSvgText();
        }
    }
}

