using System;
using System.Linq;

namespace PuzzleImageGenerator.Kilo.Painter
{
    public class ColorScheme
    {
        public static char[] Faces = { 'u', 'f', 'l', 'L', 'r', 'R' }; // Uppercase - back, lowercase - front
        public string[] Scheme = { "grey", "#00D800", "#FFA100", "lightblue", "palegoldenrod", "deeppink" }; // Default Scheme

        public ColorScheme() { }

        public ColorScheme(string[] scheme)
        {
            Scheme = scheme;
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
