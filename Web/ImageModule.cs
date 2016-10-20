using System.Collections.Generic;
using System.Linq;
using Nancy;
using Svg;
using System;
using System.Drawing.Imaging;
using System.Text;
using System.IO;
using SharpVectors.Converters;

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
                return GetImage();
            };
        }

        public Response GetImage()
        {

            var commands = (Request.Query.GetDynamicMemberNames() as IEnumerable<string>)
                            .ToDictionary(
                                key => key,
                                key => (string)Request.Query[key]
                            );

            string type = "";
            commands.TryGetValue("type", out type);
            if (type != null)
            {
                type = type.ToLower();
            }

            switch (type)
            {
                case "svg":
                    return GetSvg(commands);
                case "jpg":
                case "jpeg":
                    return GetJpeg(commands);
                case "png":
                    return GetPng(commands);
                default:
                    return GetSvg(commands);
            }

        }

        public Response GetJpeg(Dictionary<string, string> commands)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Guid.NewGuid().ToString() + ".svg");
            string temporary = filePath + ".tmp.jpeg";
            File.WriteAllText(filePath, GetSvgText(commands));
            var svg = SvgDocument.Open(filePath);
            File.Delete(filePath);
            svg.Draw().Save(temporary, ImageFormat.Jpeg);
            return new TempImageResponse(temporary, "image/jpg");
        }

        public Response GetPng(Dictionary<string, string> commands)
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Guid.NewGuid().ToString() + ".svg");
            string temporary = filePath + ".tmp.png";
            File.WriteAllText(filePath, GetSvgText(commands));
            var svg = SvgDocument.Open(filePath);
            File.Delete(filePath);
            svg.Draw().Save(temporary, ImageFormat.Png);
            return new TempImageResponse(temporary, "image/png");
        }

        public Response GetSvg(Dictionary<string, string> commands)
        {

            return Response
                    .AsText(GetSvgText(commands))
                    .WithContentType("image/svg+xml");
        }

        public string GetSvgText(Dictionary<string, string> commands)
        {

            string puzzle;
            commands.TryGetValue("puzzle", out puzzle);
            if (puzzle != null)
            {
                puzzle = puzzle.ToLower();
            }

            switch (puzzle)
            {
                case "sq1":
                    return Sq1.Sq1ImageGenerator.Generate(commands);
                case "skewb":
                    return Skewb.SkewbImageGenerator.Generate(commands);
                case "mega":
                    return Mega.MegaImageGenerator.Generate(commands);
                case "kilo":
                    return Kilo.KiloImageGenerator.Generate(commands);
                default:
                    return "";

            }
        }
    }
}