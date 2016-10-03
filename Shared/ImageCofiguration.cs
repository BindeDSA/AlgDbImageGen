using System.Collections.Generic;

namespace PuzzleImageGenerator.Shared
{
    public abstract class ImageConfiguration
    {
        public string Moves { get; private set; }
        public string Case { get; private set; }
        public string StickerDefs { get; set; }
        public int ImageLength { get; private set; }
        public string Stage { get; private set; }

        protected ImageConfiguration(IDictionary<string, string> commands)
        {
            // default values
            ImageLength = 500;
            Stage = "full";

            int temp;
            foreach (var command in commands)
            {
                switch (command.Key)
                {
                    case "alg": Moves = command.Value; break;
                    case "case": Case = command.Value; break;
                    case "size": if (int.TryParse(command.Value, out temp)) { ImageLength = temp; }; break;
                    case "stage": Stage = command.Value; break;
                    case "stickers": StickerDefs = command.Value; break;
                }
            }
        }
    }
}
