namespace Chess
{
    public enum Team
    {
        White,
        Black
    }

    public enum PieceType
    {
        None,
        Pawn,
        Knight,
        Bishop,
        Rook,
        Queen,
        King
    }

    public enum TokenType
    {
        LittleCastling,
        BigCastling,
        SimpleMove,
        Capture,
        Comment,
        Round,
        Result,
        Unknown
    }
}