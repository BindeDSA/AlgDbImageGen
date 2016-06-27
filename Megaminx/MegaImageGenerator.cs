using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

