using System.Collections.Generic;

namespace PuzzleImageGenerator.Kilo
{
    public class KiloImageGenerator
    {
        public static string Generate(IDictionary<string, string> input)
        {
            return new Painter.KiloImage(new KiloImageConfiguration(input))
                .GetSvgText();
        }
    }
}

