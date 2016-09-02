using System.Collections.Generic;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Sq1
{
    public class Sq1ImageConfiguration : ImageConfiguration
    {
        public bool PlaceDOnRight { get; private set; } = true;
        public int FaceSpacer { get; private set; } = 5;
        public int FaceSize { get; private set; } = 80;

        public Sq1ImageConfiguration(IDictionary<string, string> commands) 
            : base(commands)
        {
            int temp;
            foreach (var command in commands)
            {
                switch (command.Key)
                {
                    case "transform":
                        PlaceDOnRight = command.Value.Equals("horizontal");
                        break;

                    case "stickers":
                        StickerDefs = command.Value;
                        break;

                    case "facespacer":
                        if (int.TryParse(command.Value, out temp))
                            FaceSpacer = temp;
                        break;

                    case "faceSize":
                        if (int.TryParse(command.Value, out temp))
                            FaceSize = temp;
                        break;
                }
            }
        }
    }
}
