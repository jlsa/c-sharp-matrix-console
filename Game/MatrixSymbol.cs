using System;
using Game.Math;

namespace Matrix
{
    public class MatrixSymbol
    {
        public char Symbol { get; set; }
        public Point<int> Position { get; set; }

        public ConsoleColor Color {get; set;}

        public void Render()
        {
            if (Position.Y < 0)
            {
                return;
            }
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(Symbol);
        }
        public void Update()
        {
            Position.Y += 1;
            Symbol = MatrixSymbols.GetRandomChar();
        }
    }
}