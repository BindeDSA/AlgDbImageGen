using PuzzleImageGenerator.Shared;
using PuzzleImageGenerator.Three.Simulation;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Three
{
    public class ThreeImageConfiguration : ImageConfiguration
    {
        public ViewType View { get; private set; }
        public VirtualCube Cube { get; set; }
        public string ColorScheme { get; set; }

        public ThreeImageConfiguration(IDictionary<string, string> commands)
            : base(commands)
        {
            View = ViewType.trans;
            foreach (var command in commands)
            {
                switch (command.Key)
                {
                    case "view":
                        View = command.Value.Equals("plan") ? ViewType.plan : ViewType.trans;
                        break;
                    case "scheme":
                        ColorScheme = command.Value;
                        break;
                }
            }
        }
    }

    public enum ViewType { plan, trans }
}