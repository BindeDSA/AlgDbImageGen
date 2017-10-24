using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Skewb.Painter
{
    public class ColorScheme
    {
        public static char[] Faces = { 'y', 'o', 'b', 'w', 'r', 'g' }; // Uppercase - back, lowercase - front
        public string[] Scheme = { "#FEFE00", "#FFA100", "#0000F2", "#FFFFFF", "#EE0000", "#00D800" }; // Default Scheme

        public string NullColor = "#404040";

        public ColorScheme() { }

        public ColorScheme(string[] scheme)
        {
            Scheme = scheme.Select((colorCode) => (Regex.IsMatch(colorCode, @"\A\b[0-9a-fA-F]+\b\Z") ? "#" : "") + colorCode)
                           .ToArray();
        }

        public string GetFace(char face)
        {
            if (Faces.Contains(face))
                return Scheme[Array.IndexOf(Faces, face)];
            else
                return NullColor;
        }
    }
}
