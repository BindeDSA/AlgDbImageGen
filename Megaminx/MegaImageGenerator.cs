using System.Collections.Generic;

namespace PuzzleImageGenerator.Mega
{
    public class MegaImageGenerator
    {
        public static string Generate(IDictionary<string, string> input)
        {
            return new Painter.MegaImage(new MegaImageConfiguration(input))
                .GetSvgText();
        }
    }
}

