using System.Collections.Generic;

namespace PuzzleImageGenerator.Kilo
{
    public class KiloImageGenerator
    {
        public static string Generate(IDictionary<string, string> input)
        {
            var config = new KiloImageConfiguration(input);

            new Simulation.VirtualKilo(config);

            return new Painter.KiloImage(config)
                .GetSvgText();
        }
    }
}

