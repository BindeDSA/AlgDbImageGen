using PuzzleImageGenerator.Shared;
using System;
using System.Collections.Generic;

namespace PuzzleImageGenerator.Sq1.Painter
{
    public class PieceStickers
    {
        public Sq1ImageProp Properties { get; set; }
        public string Type;
        public readonly int Rotation;
        public string[] Sides;
        public CoordPair Center;
        public string Face = "lightgray";
        public CoordPair[] FaceCoords { get; set; }
        public CoordPair[][] SideCoords { get; set; }

        public PieceStickers(string[] defs, bool secondFace, int rotation, Sq1ImageProp properties)
        {
            Properties = properties;
            Center = secondFace
                ? new CoordPair(Properties.ImageLength / 2, Properties.ImageLength / 2, xOffset: Properties.XOffset, yOffset: Properties.YOffset)
                : new CoordPair(Properties.ImageLength / 2, Properties.ImageLength/ 2);

            Type = defs[0];

            if (defs.Length > 1)
                Face = defs[1];

            if (defs.Length == 3)
                Sides = new string[] { defs[2] };

            if (defs.Length == 4)
                Sides = new string[] { defs[2], defs[3] };

            Rotation = rotation;

            SetFaceCoords();
            SetSideCoords();
        }

        public void SetFaceCoords()
        {
            var tempRotation = Rotation;
            var coords = new List<CoordPair>();
            coords.Add(GetCoord(Properties.ShortFaceDist, tempRotation));
            tempRotation += 2;

            if (Type.Equals("corner"))
            {
                coords.Add(GetCoord(Properties.LongFaceDist, tempRotation));
                tempRotation += 2;
            }

            coords.Add(GetCoord(Properties.ShortFaceDist, tempRotation));
            coords.Add(Center);

            FaceCoords = coords.ToArray();
        }

        public void SetSideCoords()
        {
            var tempRotation = Rotation;
            var coords = new List<CoordPair>();
            var tempSides = new List<CoordPair[]>();

            if (Type.Equals("corner"))
            {
                coords.Add(GetCoord(Properties.ShortFaceDist, tempRotation));
                coords.Add(GetCoord(Properties.ShortSideDist, tempRotation));
                tempRotation += 2;
                coords.Add(GetCoord(Properties.LongSideDist, tempRotation));
                coords.Add(GetCoord(Properties.LongFaceDist, tempRotation));
                tempSides.Add(coords.ToArray());
                coords.Clear();

                coords.Add(GetCoord(Properties.LongSideDist, tempRotation));
                coords.Add(GetCoord(Properties.LongFaceDist, tempRotation));
                tempRotation += 2;
                coords.Add(GetCoord(Properties.ShortFaceDist, tempRotation));
                coords.Add(GetCoord(Properties.ShortSideDist, tempRotation));
                tempSides.Add(coords.ToArray());
                SideCoords = tempSides.ToArray();
            }
            else
            {
                coords.Add(GetCoord(Properties.ShortFaceDist, tempRotation));
                coords.Add(GetCoord(Properties.ShortSideDist, tempRotation));
                tempRotation += 2;
                coords.Add(GetCoord(Properties.ShortSideDist, tempRotation));
                coords.Add(GetCoord(Properties.ShortFaceDist, tempRotation));
                tempSides.Add(coords.ToArray());
                SideCoords = tempSides.ToArray();
            }
        }

        public CoordPair GetCoord(double dist, double rotation)
        {
            return CoordPair.CartesianFromPolar(dist, rotation * Math.PI * 15/180, Center);
        }
    }
}
