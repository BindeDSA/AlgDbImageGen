using System.Collections.Generic;
using System.Linq;
using Nancy;

namespace PuzzleImageGenerator.Web
{
    public class ImageModule : Nancy.NancyModule
    {
        public ImageModule()
        {
            Get["/"] = _ => View["index"];
            Get["/gui"] = _ => View["gui"];
            Get["/generator"] = _ =>
            {
                return Response
                    .AsText(GetSVG())
                    .WithContentType("image/svg+xml");
            };
        }

        public string GetSVG()
        {
            var commands = (Request.Query.GetDynamicMemberNames() as IEnumerable<string>)
                .ToDictionary(
                    key => key, 
                    key => (string)Request.Query[key]
                );

            string puzzle;
            commands.TryGetValue("puzzle", out puzzle);

            switch (puzzle)
            {
                case "sq1":
                    return Sq1.Sq1ImageGenerator.Generate(commands);

                case "skewb":
                    return Skewb.SkewbImageGenerator.Generate(commands);

                case "mega":
                    return Mega.MegaImageGenerator.Generate(commands);

                default:
                    return "";
            }
        }
    }
}