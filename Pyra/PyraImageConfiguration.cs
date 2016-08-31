using System.Collections.Generic;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Pyra
{
    public class PyraImageConfiguration : ImageConfiguration
    {
        public string Scheme { get; private set; }

        public PyraImageConfiguration(IDictionary<string, string> commands)
            : base(commands)
        {
            foreach (var command in commands)
            {
                switch (command.Key)
                {
                    case "scheme":
                        Scheme = command.Value;
                        break;
                }
            }
        }
    }
}