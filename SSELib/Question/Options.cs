using System;

namespace SSELib.Question
{
    public struct Options
    {
        //private bool[,] _assigned;

        public Options(int x, int y)
        {
            if (x < 0 || y < 0)
                throw new ArgumentOutOfRangeException("The answer choices must not be negative");

            X = x;
            Y = y;

            //_assigned = new bool[x, y];
            //for (int i = 0; i < _assigned.GetLength(0); i++)
            //{
            //    for (int j = 0; j < _assigned.GetLength(1); j++)
            //        _assigned[i, j] = true;
            //}
        }

        public int X { get; }

        public int Y { get; }

        //public bool this[int indexX, int indexY]
        //{
        //    get => _assigned[indexX, indexY];
        //    set => _assigned[indexX, indexY] = value;
        //}

        public static Options operator +(Options first, Options second)
        {
            return new Options(first.X + second.X, first.Y + second.Y);
        }

        public static Options operator -(Options first, Options second)
        {
            if (first.X - second.X < 0 || first.Y - second.Y < 0)
                throw new InvalidOperationException("The answer choices must not be negative");

            return new Options(first.X - second.X, first.Y - second.Y);
        }
    }
}
