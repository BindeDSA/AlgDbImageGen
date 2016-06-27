using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuzzleImageGenerator.Shared;
namespace PuzzleImageGenerator.Mega
{
    class MegaImageConfiguration : ImageConfiguration
    {
        public string Scheme { get; private set; }
        public MegaImageConfiguration(IDictionary<string, string> commands)
            : base(commands)
        {
            foreach (var command in commands)
            {
                switch (command.Key)
                {
                    case "scheme": Scheme = command.Value; break;
                }
            }
        }
    }
}