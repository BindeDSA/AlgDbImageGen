using System.Collections.Generic;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Sq1
{
    public class Sq1ImageConfiguration : ImageConfiguration
    {
        public bool PlaceDOnRight { get; private set; }
        public int SliceSpacer { get; private set; }
        public int FaceSpacer { get; private set; }

        public Sq1ImageConfiguration(IDictionary<string, string> commands) 
            : base(commands)
        {
            // default values
            PlaceDOnRight = true;
            SliceSpacer = 0;
            FaceSpacer = 10;

            int temp;
            foreach (var command in commands)
            {
                switch (command.Key)
                {
                    case "placedonright": PlaceDOnRight = command.Value.Equals("horizontal"); break;
                    case "pieces": StickerDefs = command.Value; break;
                    case "facespacer": if (int.TryParse(command.Value, out temp)) { FaceSpacer = temp; }; break;
                    case "slicespacer": if (int.TryParse(command.Value, out temp)) { SliceSpacer = temp; }; break;
                }
            }
        }
    }
}
