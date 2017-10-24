using PuzzleImageGenerator.Three.Simulation.Enums;
using PuzzleImageGenerator.Three.Simulation.Pieces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleImageGenerator.Three.Painter
{
    class TwoImage
    {

        TwoImageProp Properties;

        public TwoImage(ThreeImageConfiguration configs)
        {
            Properties = new TwoImageProp(configs);
        }

        public string GetSvgText()
        {
            var svgText = "";
            if (Properties.View == ViewType.plan)
            {
                svgText += Properties.SvgPlanHeader;
                svgText += GetPlanStickers();
            }
            else
            {
                svgText += Properties.SvgTransHeader;
                svgText += GetTransStickers();
            }

            svgText += Properties.SvgFooter;
            return svgText;
        }

        private string GetPlanStickers()
        {
            var returnString = "<g style='opacity:1;stroke-opacity:0.5;stroke-width:0;stroke-linejoin:round'>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.ULB], 0) + "' stroke='#000000'  points='-0.51388888888889,-0.51388888888889 -0.041666666666667,-0.51388888888889 -0.041666666666667,-0.041666666666667 -0.51388888888889,-0.041666666666667'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UBR], 0) + "' stroke='#000000'  points='0.041666666666667,-0.51388888888889 0.51388888888889,-0.51388888888889 0.51388888888889,-0.041666666666667 0.041666666666667,-0.041666666666667'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UFL], 0) + "' stroke='#000000'  points='-0.51388888888889,0.041666666666667 -0.041666666666667,0.041666666666667 -0.041666666666667,0.51388888888889 -0.51388888888889,0.51388888888889'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.URF], 0) + "'  points='0.041666666666667,0.041666666666667 0.51388888888889,0.041666666666667 0.51388888888889,0.51388888888889 0.041666666666667,0.51388888888889'/>\n";
            returnString += "</g>\n";
            returnString += "<g style='opacity:1;stroke-opacity:1;stroke-width:0.02;stroke-linejoin:round'>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UFL], 1) + "' stroke='#000000'  points='-0.53888888888889,0.55388888888889 -0.016666666666667,0.55388888888889 -0.016666666666667,0.70166666666667 -0.48666666666667,0.70166666666667'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.URF], 2) + "' stroke='#000000'  points='0.015,0.55388888888889 0.53722222222222,0.55388888888889 0.485,0.70166666666667 0.015,0.70166666666667'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.ULB], 1) + "' stroke='#000000'  points='-0.55388888888889,-0.53888888888889 -0.55388888888889,-0.016666666666667 -0.70166666666667,-0.016666666666667 -0.70166666666667,-0.48666666666667'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UFL], 2) + "' stroke='#000000'  points='-0.55388888888889,0.015 -0.55388888888889,0.53722222222222 -0.70166666666667,0.485 -0.70166666666667,0.015'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UBR], 1) + "' stroke='#000000'  points='0.53888888888889,-0.55388888888889 0.016666666666667,-0.55388888888889 0.016666666666667,-0.70166666666667 0.48666666666667,-0.70166666666667'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.ULB], 2) + "' stroke='#000000'  points='-0.015,-0.55388888888889 -0.53722222222222,-0.55388888888889 -0.485,-0.70166666666667 -0.015,-0.70166666666667'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.URF], 1) + "' stroke='#000000'  points='0.55388888888889,0.53888888888889 0.55388888888889,0.016666666666667 0.70166666666667,0.016666666666667 0.70166666666667,0.48666666666667'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UBR], 2) + "' stroke='#000000'  points='0.55388888888889,-0.015 0.55388888888889,-0.53722222222222 0.70166666666667,-0.485 0.70166666666667,-0.015'/>\n";
            returnString += "</g>\n";

            return returnString;
        }


        private string GetTransStickers()
        {
            var returnString = "<g style='opacity:1;stroke-opacity:0.5;stroke-width:0;stroke-linejoin:round'>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.ULB], 0) + "' stroke='#000000'  points='-4.8380889382E-17,-0.73882511818944 0.29971040905097,-0.60915232226652 -3.9227748147568E-18,-0.4633757043086 -0.29971040905097,-0.60915232226652'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UBR], 0) + "' stroke='#000000'  points='0.35610206861,-0.58314481961994 0.69303295289668,-0.43736820166201 0.3957867255104,-0.27228930092359 0.05639165955903,-0.43736820166201'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UFL], 0) + "' stroke='#000000'  points='-0.35610206861,-0.58314481961994 -0.05639165955903,-0.43736820166201 -0.3957867255104,-0.27228930092359 -0.69303295289668,-0.43736820166201'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.URF], 0) + "' stroke='#000000'  points='5.0352558971797E-18,-0.40787437832688 0.33939506595137,-0.24279547758845 6.210148939855E-17,-0.054308764414833 -0.33939506595137,-0.24279547758845'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.URF], 1) + "' stroke='#000000'  points='0.028167748675664,-0.0056272084291322 0.36756281462704,-0.19411392160275 0.34740223366653,0.1925314788301 0.028167748675664,0.3947544954701'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UBR], 2) + "' stroke='#000000'  points='0.42237469800666,-0.22649630734307 0.71962092539294,-0.3915752080815 0.68402039606385,-0.018364565460249 0.40221411704615,0.16014909308978'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.DFR], 2) + "' stroke='#000000'  points='0.026588359831327,0.46037226484125 0.34582284482219,0.25814924820125 0.32792310458637,0.60143559717498 0.026588359831327,0.81305046175342'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.DRB], 1) + "' stroke='#000000'  points='0.39762672437695,0.22370736870217 0.67943300339465,0.045193710152138 0.64760313410419,0.37887543332634 0.37972698414113,0.5669937176759'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.UFL], 1) + "' stroke='#000000'  points='-0.7209832737784,-0.39038978827459 -0.42373704639212,-0.22531088753617 -0.40357646543161,0.16133451289669 -0.68538274444932,-0.017179145653343'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.URF], 2) + "' stroke='#000000'  points='-0.36934168941767,-0.19290189482631 -0.029946623466298,-0.0044151816526869 -0.029946623466298,0.39596652224655 -0.34918110845716,0.19374350560655'/>\n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.DLF], 2) + "' stroke='#000000'  points='-0.68066213242888,0.046041177134449 -0.39885585341118,0.22455483568448 -0.38095611317536,0.56784118465821 -0.64883226313842,0.37972290030865'/> \n";
            returnString += "<polygon fill='" + GetCornerColor(Properties.Cube.Corners[(int)CornerPiece.DFR], 1) + "' stroke='#000000'  points='-0.34740223366653,0.2589779406664 -0.028167748675664,0.4612009573064 -0.028167748675664,0.81387915421858 -0.32950249343071,0.60226428964013'/>\n";

            returnString += "</g>\n";
            return returnString;
        }

        private string GetCornerColor(Corner piece, int stickerNum)
        {
            if (Properties.Stage.ToLower() == "oll")
            {
                if (piece.Piece.ToString().Contains("U") && piece.GetStickerFace(stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "coll")
            {
                if (piece.Piece.ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "ocll")
            {
                if (piece.GetStickerFace(stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "ll")
            {
                if (piece.Piece.ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "fl")
            {
                if (piece.Piece.ToString().Contains("D"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "cll")
            {
                if (piece.Piece.ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "ocell")
            {
                if (piece.GetStickerFace(stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "wv")
            {
                if (!piece.Piece.ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }
            else if (Properties.Stage.ToLower() == "cls")
            {
                if (piece.GetStickerFace(stickerNum) == FaceType.U)
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                if (!piece.Piece.ToString().Contains("U"))
                {
                    return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
                }
                else
                {
                    return Properties.ColorScheme.GetSticker(null);
                }
            }

            return Properties.ColorScheme.GetSticker((int)piece.GetStickerFace(stickerNum));
        }
    }
}
