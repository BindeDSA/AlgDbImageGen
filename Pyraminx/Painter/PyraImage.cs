using PuzzleImageGenerator.Pyra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Pyra.Painter
{
    class PyraImage
    {
        PyraImageProp Properties;

        public PyraImage(PyraImageConfiguration configs)
        {
            Properties = new PyraImageProp(configs);
        }

        public string GetSvgText()
        {
            var svgText = Properties.SvgHeader;
            svgText += GetStickers();
            svgText += Properties.SvgFooter;
            return svgText;
        }

        private string GetStickers()
        {
            var returnString = "<g id='puzzle' transform='translate(5, 5) scale(40, 69.28203232)'>\n";

            returnString += "<use id='CENTERS-l0-o0' xlink:href='#stickerV' transform='translate(5, 1)' style='fill: yellow'/>\n";

            returnString += "</g>\n";

            return returnString;
        }
    }
}
