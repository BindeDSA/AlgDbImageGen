using PuzzleImageGenerator.Shared;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Mega.Painter.Piece
{
    public class Edge : Piece
    {
        public Edge(MegaImageProp properties, int pieceNum)
        {
            GetStickers(properties, pieceNum);
        }

        public void GetStickers(MegaImageProp properties, int pieceNum)
        {
            var tempStickers = new List<Sticker>();
            var tempCoords = new List<CoordPair>();
            var angle = MegaImageProp.LARGEANGLE * (pieceNum - 0.5);
            var angleChange = ((MegaImageProp.LARGEANGLE / 2) - MegaImageProp.SMALLANGLE) * 2;
             
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.CenterDist, angle, properties.Center));
            angle += MegaImageProp.SMALLANGLE;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.ShortFaceDist, angle, properties.Center));
            angle += angleChange;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.ShortFaceDist, angle, properties.Center));
            angle += MegaImageProp.SMALLANGLE;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.CenterDist, angle, properties.Center));

            tempStickers.Add(new Sticker(tempCoords, properties.EdgeStickerDefs[pieceNum][0]));

            tempCoords.Clear();

            angle = MegaImageProp.LARGEANGLE * (pieceNum - 0.5);
            
            angle += MegaImageProp.SMALLANGLE;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.ShortFaceDist, angle, properties.Center));
            angle += angleChange;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.ShortFaceDist, angle, properties.Center));
            angle += properties.SideAngle - angleChange / 2;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.ShortSideDist, angle, properties.Center));
            angle -= properties.SideAngle * 2;
            tempCoords.Add(CoordPair.CartesianFromPolar(properties.ShortSideDist, angle, properties.Center));

            tempStickers.Add(new Sticker(tempCoords, properties.EdgeStickerDefs[pieceNum][1]));

            Stickers = tempStickers.ToArray();
        }
    }
}
