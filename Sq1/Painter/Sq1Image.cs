using PuzzleImageGenerator.Shared.Helpers;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Sq1.Painter
{
    public class Sq1Image
    {
        Sq1ImageProp Properties;
        public List<PieceStickers>[] PieceStickers;

        public Sq1Image(Sq1ImageConfiguration configs)
        {
            var isCubeShape = CheckIfCubeshape(configs);

            Properties = new Sq1ImageProp(configs, isCubeShape);

            CreatePieces(ParseDefs(configs.StickerDefs));
        }

        static bool CheckIfCubeshape(Sq1ImageConfiguration configs)
        {
            var cubeshape = true;
            var counter = 0;
            var Faces = configs.StickerDefs.Split(';');
            foreach (var face in Faces)
                foreach (var piece in face.Split(','))
                {
                    if (counter % 2 == 0 && piece[0] != 'c')
                        cubeshape = false;

                    if (counter % 2 == 1 && piece[0] != 'e')
                        cubeshape = false;

                    if (counter > 15)
                        cubeshape = false;

                    counter++;
                }

            return cubeshape;
        }



        public static string[][][] ParseDefs(string pieceDefString)
        {
            var Faces = pieceDefString.Split(';');
            var pieceDefs = new List<string[]>[] { new List<string[]>(), new List<string[]>() };

            var counter = 0;
            foreach (var face in Faces)
            {
                var faceArray = face.Split(',');
                foreach (var defs in faceArray)
                {
                    var tempDefs = new List<string>();

                    if (defs[0] == 'c')
                        tempDefs.Add("corner");
                    else if (defs[0] == 'e')
                        tempDefs.Add("edge");
                    else
                        break;
                    if (defs.Length > 1)
                        tempDefs.Add(ColorHelper.GetColorNameFromCharacter(defs[1]));

                    if (defs.Length > 2)
                        tempDefs.Add(ColorHelper.GetColorNameFromCharacter(defs[2]));

                    if (defs.Length > 3)
                        tempDefs.Add(ColorHelper.GetColorNameFromCharacter(defs[3]));

                    pieceDefs[counter].Add(tempDefs.ToArray());

                }
                counter++;
            }
            return new string[][][] { pieceDefs[0].ToArray(), pieceDefs[1].ToArray() };
        }

        public void CreatePieces(string[][][] pieces)
        {
            var tempPieces = new List<PieceStickers>[] { new List<PieceStickers>(), new List<PieceStickers>() };
            var rotation = 1;
            for (int i = 0; i < pieces.Length; i++)
            {
                var Face = pieces[i];
                foreach (var face in Face)
                {
                    tempPieces[rotation / 24].Add(new PieceStickers(face, i == 1, rotation, Properties));
                    rotation += face[0].Equals("corner") ? 4 : 2;
                }
            }
            PieceStickers = tempPieces;
        }

        public string GetSvgText()
        {
            var svgText = "";
            svgText += SvgHelper.GetHeader(Properties);
            foreach (var face in PieceStickers)
            {
                foreach (var piece in face)
                {
                    svgText += SvgHelper.GetPolygonText(piece.FaceCoords, Properties, fill: piece.Face);
                    if (piece.Sides != null)
                    {
                        if (!Properties.Stage.Equals("cubeshape"))
                        {
                            for (int i = 0; i < piece.SideCoords.Length; i++)
                            {
                                string fill = piece.Sides.Length < i + 1
                                    ? ColorHelper.GetColorNameFromCharacter(' ')
                                    : piece.Sides[i];

                                svgText += SvgHelper.GetPolygonText(piece.SideCoords[i], fill: fill);
                            }
                        }
                    }
                }
            }
            svgText += SvgHelper.GetFooter();
            return svgText;
        }
    }
}
