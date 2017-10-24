using PuzzleImageGenerator.Shared;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Skewb
{
    public class SkewbImageConfiguration : ImageConfiguration
    {
        public bool Dface { get; private set; }
        public string ColorScheme;

        public SkewbImageConfiguration(IDictionary<string, string> commands)
            : base(commands)
        {
            // Default Values
            Dface = true;
            foreach (var command in commands)
            {
                switch (command.Key)
                {
                    case "dface": Dface = command.Key == "true"; break;
                    case "stage": Stage = command.Key; break;
                    case "scheme":
                        ColorScheme = command.Value;
                        break;
                }
            }
        }
    }
}
