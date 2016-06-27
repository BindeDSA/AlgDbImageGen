namespace PuzzleImageGenerator.Sq1.Simulation
{
    public class Piece
    {
        public char Type { get; private set; }
        int PieceInt;
        public int Position { get; set; }

        public static string[] PieceDefs = {
            "cyog", "eyg", "cygr", "eyr", "cyrb", "eyb", "cybo", "eyo", // U-layer
            "ewr", "cwrg", "ewg", "cwgo", "ewo", "cwob", "ewb", "cwbr"  // D-layer
        };   

        public Piece(int pieceInt, int position)
        {
            Type = PieceDefs[pieceInt][0];
            PieceInt = pieceInt;
            Position = position;
        }

        public int GetWidth()
        {
            return Type == 'c' ? 2 : 1;
        }

        public string GetDefs()
        {
            return PieceDefs[PieceInt];
        }
    }
}