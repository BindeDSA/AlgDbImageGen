using PuzzleImageGenerator.Shared;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Mega.Painter.Piece
{
    public class Corner : Piece
    {
        public Corner(MegaImageProp properties, int pieceNum)
        {
            GetStickers(properties, pieceNum);
        }

        public void GetStickers(MegaImageProp properties, int pieceNum)
        {
            var tempStickers = new List<Sticker>();
            var tempCoords = new List<CoordPair>();
            var angle = MegaImageProp.LARGEANGLE * (pieceNum + 0.5);

            tempCoords.Add(CoordPair.CartesianFromPolar(properties.CenterDist, angle, properties.Center));
            angle -= MegaImageProp.SMALLANGLE;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.ShortFaceDist, angle, properties.Center));
            angle += MegaImageProp.SMALLANGLE;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.LongFaceDist, angle, properties.Center));
            angle += MegaImageProp.SMALLANGLE;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.ShortFaceDist, angle, properties.Center));

			tempStickers.Add(new Sticker(tempCoords, properties.CornerColors[pieceNum][0]));

			tempCoords.Clear();

            angle = MegaImageProp.LARGEANGLE * (pieceNum + 0.5);

            tempCoords.Add(CoordPair.CartesianFromPolar(properties.LongFaceDist, angle, properties.Center));
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.LongSideDist, angle, properties.Center));

            angle -= MegaImageProp.LARGEANGLE / 2 - properties.SideAngle;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.ShortSideDist, angle, properties.Center));
            angle -= MegaImageProp.SMALLANGLE + properties.SideAngle - MegaImageProp.LARGEANGLE / 2;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.ShortFaceDist, angle, properties.Center));

			tempStickers.Add(new Sticker(tempCoords, properties.CornerColors[pieceNum][1]));

			tempCoords.Clear();

            angle = MegaImageProp.LARGEANGLE * (pieceNum + 0.5);

            tempCoords.Add(CoordPair.CartesianFromPolar(properties.LongFaceDist, angle, properties.Center));
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.LongSideDist, angle, properties.Center));

            angle += MegaImageProp.LARGEANGLE / 2 - properties.SideAngle;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.ShortSideDist, angle, properties.Center));
            angle += MegaImageProp.SMALLANGLE + properties.SideAngle - MegaImageProp.LARGEANGLE / 2;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.ShortFaceDist, angle, properties.Center));

			tempStickers.Add(new Sticker(tempCoords, properties.CornerColors[pieceNum][2]));

			Stickers = tempStickers.ToArray();
        }
    }
}
