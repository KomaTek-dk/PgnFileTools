using System;

using MvbaCore;

namespace PgnFileTools
{
    public class PieceType : NamedConstant<PieceType>
    {
        public static readonly PieceType Bishop = new PieceType("B", "B", IsLegalBishopMove);

        public static readonly PieceType King = new PieceType("K", "K", IsLegalKingMove);

        public static readonly PieceType Knight = new PieceType("N", "N", IsLegalKnightMove);

        public static readonly PieceType Pawn = new PieceType("", "P", IsLegalPawnMove);
        public static readonly PieceType Queen = new PieceType("Q", "Q", IsLegalQueenMove);

        public static readonly PieceType Rook = new PieceType("R", "R", IsLegalRookMove);

        private PieceType(string token, string symbol, Func<Position, bool, Position, bool> isLegal)
        {
            Symbol = symbol;
            IsLegal = isLegal;
            Add(token, this);
        }

        public Func<Position, bool, Position, bool> IsLegal { get; private set; }

        public string Symbol { get; private set; }

        public static PieceType GetFor(char token)
        {
            var pieceType = GetFor(token + "");
            return (pieceType != null && pieceType.Symbol[0] == token) ? pieceType : null;
        }

        private static bool IsLegalBishopMove(Position source, bool isCapture, Position destination)
        {
            return true; // todo
        }

        private static bool IsLegalKingMove(Position source, bool isCapture, Position destination)
        {
            return true; // todo
        }

        private static bool IsLegalKnightMove(Position source, bool isCapture, Position destination)
        {
            return true; // todo
        }

        private static bool IsLegalPawnMove(Position source, bool isCapture, Position destination)
        {
            if (isCapture)
            {
                return source.File != null && source.File != destination.File;
            }
            return true;
        }

        private static bool IsLegalQueenMove(Position source, bool isCapture, Position destination)
        {
            return true; // todo
        }

        private static bool IsLegalRookMove(Position source, bool isCapture, Position destination)
        {
            return true; // todo
        }
    }
}