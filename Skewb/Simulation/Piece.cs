namespace PuzzleImageGenerator.Skewb.Simulation
{
    public class Piece
    {
        public string PieceName { get; protected set; }
        public static string PieceNames = "";

        public Piece(string pieceName)
        {
            PieceName = pieceName;            
        }
    }
}
