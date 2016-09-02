using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PuzzleImageGenerator.Mega.Painter
{
    public class ColorScheme
    {
        public static char[] Faces = { 'u', 'f', 'l', 'L', 'r', 'R' }; // Uppercase - back, lowercase - front
        public string[] Scheme = { "grey", "lime", "#FB8C00", "lightblue", "palegoldenrod", "deeppink" }; // Default Scheme

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
                return "white";
        }
    }
}
