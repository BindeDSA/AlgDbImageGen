using System.Collections.Generic;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Pyra
{
    public class PyraImageConfiguration : ImageConfiguration
    {
        public string ColorScheme { get; private set; }

        public PyraImageConfiguration(IDictionary<string, string> commands)
            : base(commands)
        {
            foreach (var command in commands)
            {
                switch (command.Key)
                {
                    case "scheme":
                        ColorScheme = command.Value;
                        break;
                }
            }
        }
    }
}