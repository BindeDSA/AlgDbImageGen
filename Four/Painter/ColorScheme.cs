using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Four.Painter
{
    public class ColorScheme
    {
        public string[] Scheme = { "#FEFE00", "#EE0000", "#0000F2", "#FFFFFF", "#FFA100", "#00D800",}; // Default Scheme
        public string NullColor = "#404040";

        public ColorScheme() { }

        public ColorScheme(string[] scheme)
        {
            Scheme = scheme.Select((colorCode) => (Regex.IsMatch(colorCode, @"\A\b[0-9a-fA-F]+\b\Z") ? "#" : "") + colorCode)
                           .ToArray();
        }

        public string GetSticker(int? faceNum)
        {
            if(faceNum == null)
            {
                return NullColor;
            }
            var intFaceNum = (int)faceNum;
            return Scheme[intFaceNum];
        }
    }
}
