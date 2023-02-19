using System;

namespace Chess
{
    public class Position
    {
        public readonly int X;
        public readonly int Y;

        public bool IsOnBoard()
        {
            return (X > 0 & X < 9) & (Y > 0 & Y < 9);
        }

        public Position(string position)
        {
            Position res;
            int x = position[0] - 96;
            int y = position[1] - '0';
            X = x;
            Y = y;
        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            string res = "";
            res += ((X > 0 & X < 9)) ? ((char)(X + 96)) : '?';
            res += (Y > 0 & Y < 9) ? ((char)(Y + '0')) : '?';
            return res;
        }

        public static bool operator ==(Position pos1, Position pos2)
        {
            bool res = false;
            if (pos1.IsOnBoard() && pos2.IsOnBoard())
            {
                res =  pos1.X == pos2.X & pos1.Y == pos2.Y;
            }
            else
            {
                res = true;
            }
            return res;
        }

        public static bool operator !=(Position pos1, Position pos2)
        {
            return !(pos1 == pos2);
        }
    }
}