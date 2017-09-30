namespace PuzzleImageGenerator.Sq1.Painter.Pieces.Edge
{
    public class Edge : Piece
    {
        private EdgeFace Face;
        private EdgeSide Side;
        public override PieceType Type { get { return PieceType.Edge; } }
        public override Sticker[] Stickers
        {
            get { return new Sticker[] { Face, Side }; }
        }

        public Edge(string stickerDef, int position, Sq1ImageProp properties)
        {
            Face = new EdgeFace(position, stickerDef[0], properties);
            Side = new EdgeSide(position, stickerDef[1], properties);
        }
    }
}
