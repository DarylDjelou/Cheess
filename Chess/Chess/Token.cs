using System.Collections.Generic;

namespace Chess
{
    public class Token
    {
        public PieceType PieceType;
        public TokenType Type;
        public string Value;
        public Position From;
        public Position To;
        public PieceType Promotion;
        public bool IsCheck;
        public bool IsCheckMate;

        //PieceType
        public PieceType GetPieceType()
        {
            return PieceType;
        }

        private void SetPieceType(PieceType pieceType)
        {
            PieceType = pieceType;
        }
        
        //TokenType
        public TokenType GetTokenTypeType()
        {
            return Type;
        }

        private void SetTokenType(TokenType type)
        {
            Type = type;
        }

        public int GuessTokenType(string value)
        {
            bool[] conBools = new bool[7];
            int res = 7;
            conBools[0] = value == "0-0";
            conBools[1] = value == "0-0-0";
            conBools[2] = (new Position(value.Substring(1))).IsOnBoard();
            conBools[3] = value.Contains("x");
            conBools[4] = value[0] == '$';
            conBools[5] = value[(value.Length) - 1] == '.';
            conBools[6] = value == "1-0" || value == "0-1" || value == "1/2-1/2";
            for (int i = 0; i < 7; i++)
            {
                if (conBools[i])
                {
                    res =  i;
                }   
            }
            return res;
        }    

    
        
        //Value 
        public string GetValue()
        {
            return Value;
        }
        
        //From
        public Position GetFrom()
        {
            return From;
        }

        private void SetFrom(Position pos)
        {
            From = pos;
        }
        
        //To
        public Position GetTo()
        {
            return To;
        }

        private void SetTo(Position pos)
        {
            To = pos;
        }

        //isCheck
        
        
        public Token(string Value)
        {
            int Tint = GuessTokenType(Value);
            PieceType = PieceType.None;
            Type = (TokenType)Tint;
            this.Value = Value;
            From = new Position(-1, -1);
            To = new Position(-1, -1);
            Promotion = PieceType.None;
            IsCheck = Value.Contains("+");
            IsCheckMate = Value.Contains("#");
        }
    }
}