using System;

namespace SSELib.QnA.Question
{
    public struct Options
    {
        public Options(int row, int col)
            : this()
        {
            if (row < 0 || col < 0)
                throw new ArgumentOutOfRangeException("The answer choices must not be negative");

            Row = row;
            Col = col;
        }

        public int Row { get; set; }

        public int Col { get; set; }
    }
}
