using System.Collections.Generic;
using System.Linq;
using Nancy;

namespace PuzzleImageGenerator.Web
{
    public class ImageModule : Nancy.NancyModule
    {
        public ImageModule() : base("/image")
        {
            //size=200&stage=full&transform=horizontal&case=/(-3,0) / (0,3) / (0,-3) / (0,3) / (2,0) / (0,2) / (-2,0) / (4,0) / (0,-2) / (0,2) / (-1,4) / (0,-3) / (0,3) 

            Get["/"] = _ => View["index"];
            Get["/gui"] = _ => View["gui"];
            Get["/failure"] = _ => View["failure"];
            Get["/generator"] = _ =>
            {
                return Response
                .AsText(getSVG())
                .WithContentType("image/svg+xml");
            };
        }

        public string getSVG()
        {
            IEnumerable<string> keys = Request.Query.GetDynamicMemberNames();

            var commands = keys.ToDictionary(key => key, key => (string)Request.Query[key]);

            string puzzle;
            commands.TryGetValue("puzzle", out puzzle);
            switch (puzzle)
            {
                case "sq1":
                    return PuzzleImageGenerator.Sq1.Sq1ImageGenerator.Generate(commands);
                case "skewb":
                    return PuzzleImageGenerator.Skewb.SkewbImageGenerator.Generate(commands);
                case "mega":
                    return PuzzleImageGenerator.Mega.MegaImageGenerator.Generate(commands);
                default:
                    return "";
            }
        }
    }
}