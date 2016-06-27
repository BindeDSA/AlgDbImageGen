using System.Collections.Generic;

namespace PuzzleImageGenerator.Shared.Helpers
{
    public static class ColorHelper
    {
        static Dictionary<char, string> ColorDictionary = new Dictionary<char, string>{
            {'n', "black" },
            {'d', "dark grey" },
            {'l', "light grey" },
            {'s', "silver" },
            {'w', "white" },
            {'y', "yellow" },
            {'r', "red" },
            {'o', "orange" },
            {'b', "blue" },
            {'g', "green" },
            {'m', "purple" },
            {'p', "pink" },
            {'t', "transparent" }
        };

        public static string GetColorNameFromCharacter(char character)
        {
            return ColorDictionary.ContainsKey(character) 
                ? ColorDictionary[character] 
                : "black";
        }
    }
}
