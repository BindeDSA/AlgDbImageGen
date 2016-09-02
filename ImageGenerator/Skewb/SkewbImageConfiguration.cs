using PuzzleImageGenerator.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuzzleImageGenerator.Skewb
{
    class SkewbImageConfiguration : ImageConfiguration
    {
        public bool Dface { get; private set; }
        public SkewbImageConfiguration(IDictionary<string, string> commands)
            :base(commands)
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
