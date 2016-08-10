using System.Collections.Generic;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Kilo
{
    public class KiloImageConfiguration : ImageConfiguration
    {
        public string Scheme { get; private set; }

        public KiloImageConfiguration(IDictionary<string, string> commands)
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