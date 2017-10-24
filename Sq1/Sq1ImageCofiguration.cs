using System.Collections.Generic;
using PuzzleImageGenerator.Shared;
using PuzzleImageGenerator.Sq1.Painter;

namespace PuzzleImageGenerator.Sq1
{
    public class Sq1ImageConfiguration : ImageConfiguration
    {
        public TransformType transform = TransformType.horizontal;
        public int FaceSpacer  = 5;
        public int FaceSize = 80;
        public string ColorScheme;

        public Sq1ImageConfiguration(IDictionary<string, string> commands) 
            : base(commands)
        {
            int temp;
            foreach (var command in commands)
            {
                switch (command.Key)
                {
                    case "transform":
                        transform = command.Value.Equals("horizontal") ? TransformType.horizontal : TransformType.vertical;
                        break;

                    case "stickers":
                        StickerDefs = command.Value;
                        break;

                    case "facespacer":
                        if (int.TryParse(command.Value, out temp))
                            FaceSpacer = temp;
                        break;

                    case "facesize":
                        if (int.TryParse(command.Value, out temp))
                            FaceSize = temp;
                        break;
                    case "scheme":
                        ColorScheme = command.Value;
                        break;
                }
            }
        }
    }

    public enum TransformType { horizontal, vertical}
}
