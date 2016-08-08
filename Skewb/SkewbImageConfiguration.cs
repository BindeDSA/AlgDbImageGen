using PuzzleImageGenerator.Shared;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Skewb
{
    public class SkewbImageConfiguration : ImageConfiguration
    {
        public bool Dface { get; private set; }
        public SkewbImageConfiguration(IDictionary<string, string> commands)
            : base(commands)
        {
            // Default Values
            Dface = false;
            foreach (var command in commands)
            {
                switch (command.Key)
                {
                    case "dface": Dface = true; break;
                }
            }
        }
    }
}
