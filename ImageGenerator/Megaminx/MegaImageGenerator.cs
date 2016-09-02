using System.Collections.Generic;

namespace PuzzleImageGenerator.Mega
{
    public class MegaImageGenerator
    {
        public static string Generate(IDictionary<string, string> input)
        {
            var config = new MegaImageConfiguration(input);

            var image = new Painter.MegaImage(config);

            return image.GetSvgText();
        }
    }
}

