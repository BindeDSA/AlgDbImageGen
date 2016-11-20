namespace PuzzleImageGenerator.Shared.Helpers
{
    public static class SvgHelper
    {
        public static string GetHeader(ImageProp properties)
        {
            return "<svg xmlns=\"http://www.w3.org/2000/svg\" viewBox =\"0 0 " + properties.ImageSize.Item1 + " " +
                properties.ImageSize.Item2 + "\" preserveAspectRatio=\"xMidYMid meet\">\n\n\t<g>\n";
        }

        public static string GetPolygonText(CoordPair[] polygon, ImageProp properties, string fill = "lightgray", string stroke = "black", double width = 0.5)
        {
            var polygonText = "";

            polygonText += "\t\t<polygon points=\"";

            foreach (CoordPair coordPair in polygon)
                polygonText += coordPair.ToString();

            polygonText = polygonText.Trim();

            if (properties.Stage.Equals("cubeshape"))
                fill = "lightgray";

            polygonText += "\" stroke=\"" + stroke + "\" stroke-width=\"" + properties.ImageLength / 400 + "\" fill=\"" + fill + "\"/>\"\n\n";

            return polygonText;
        }

        public static string GetFooter()
        {
            return "\t</g>\n</svg>";
        }
    }
}
