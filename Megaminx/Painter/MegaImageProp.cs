using System;
using System.Collections.Generic;
using System.Linq;
using PuzzleImageGenerator.Shared;

namespace PuzzleImageGenerator.Mega.Painter
{
    public class MegaImageProp : ImageProp
    {
        public const double LARGEANGLE = Math.PI * 72 / 180;
        public const double SMALLANGLE = Math.PI * 30.533 / 180;

        public double CenterDist { get; private set; }
        public string CenterColor { get; private set; }
        public string[][] EdgeColors { get; private set; }
        public string[][] CornerColors { get; private set; }
        public double SideAngle { get; private set; }

        public MegaImageProp(MegaImageConfiguration configs)
            : base(configs)
        {
            var scheme = new ColorScheme();
            if (configs.Scheme != null)
            {
                scheme = new ColorScheme(configs.Scheme.Split(','));
            }

            CenterColor = scheme.GetFace("u");
            var edgeFaces = Enumerable.Range(1, 5)
                        .Select(i => new string[] { ColorScheme.faces[0], ColorScheme.faces[i] })
                        .ToArray();

            var cornerFaces = Enumerable.Range(1, 5)
                        .Select(i => new string[] { ColorScheme.faces[0], ColorScheme.faces[i], ColorScheme.faces[(i + 1) % 5] })
                        .ToArray();

            if (configs.StickerDefs != null)
            {
                var byPieceType = configs.StickerDefs.Split(';');
                if (byPieceType.Length == 3)
                {
                    if (byPieceType[0].Length == 1)
                        CenterColor = scheme.GetFace(byPieceType[0]);

                    var edgeDefs = byPieceType[1].Split(',');
                    if (edgeDefs.Length == 5)
                    {
                        var tempEdges = new List<string[]>();
                        foreach (var piece in edgeDefs)
                        {
                            var tempPiece = new List<string>();
                            var face = "";
                            foreach (var character in piece)
                            {
                                if ((character == 'f' || character == 'b') && face.Length != 0)
                                {
                                    tempPiece.Add(face);
                                    face = "";
                                }

                                face += character;
                            }
                            tempPiece.Add(face);
                            tempEdges.Add(tempPiece.ToArray());
                        }
                        edgeFaces = tempEdges.ToArray();
                    }

                    var cornerDefs = byPieceType[2].Split(',');
                    if (cornerDefs.Length == 5)
                    {
                        var tempCorners = new List<string[]>();
                        foreach (var piece in cornerDefs)
                        {
                            var tempPiece = new List<string>();
                            var face = "";
                            foreach (var character in piece)
                            {
                                if ((character == 'f' || character == 'b') && face.Length != 0)
                                {
                                    tempPiece.Add(face);
                                    face = "";
                                }
                                face += character;
                            }
                            tempPiece.Add(face);
                            tempCorners.Add(tempPiece.ToArray());
                        }
                        cornerFaces = tempCorners.ToArray();
                    }
                }
            }

            EdgeColors = cornerFaces.Select(i => i.Select(j => scheme.GetFace(j)).ToArray()).ToArray();
            CornerColors = cornerFaces.Select(i => i.Select(j => scheme.GetFace(j)).ToArray()).ToArray();
            var defs = configs.StickerDefs;
            ImageLength = configs.ImageLength;

            var centerX = ImageLength / 2;

            LongSideDist = centerX / Math.Cos(LARGEANGLE / 4);
            LongFaceDist = 0.8 * LongSideDist;
            CenterDist = LongFaceDist * 0.4;
            var belowCenterY = Math.Cos(LARGEANGLE / 2) * LongSideDist;

            Center = new CoordPair(centerX, LongSideDist);
            ImageSize = new Tuple<double, double>(ImageLength, Center.Y + belowCenterY);

            ShortFaceDist = Math.Sin(Math.PI * 54 / 180) * LongFaceDist / Math.Sin(Math.PI * 126 / 180 - SMALLANGLE);

            var edgeHalfWidth = Math.Sin(LARGEANGLE / 2) * CenterDist * 0.75;
            ShortSideDist = Math.Sqrt(Math.Pow(edgeHalfWidth, 2) + Math.Pow(belowCenterY, 2));
            SideAngle = Math.Acos(belowCenterY / ShortSideDist);
        }
    }
}
