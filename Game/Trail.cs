using System;
using System.Collections.Generic;
using Game.Math;

namespace Matrix
{
    public class Trail
    {
        private Random random = new Random();
        // lead color
        ConsoleColor leadColor = ConsoleColor.White;

        ConsoleColor normalColor = ConsoleColor.Green;

        ConsoleColor endColor = ConsoleColor.DarkGray;

        List<MatrixSymbol> _matrixSymbols = new List<MatrixSymbol>(); 

        public Trail(Point<int> StartPosition, int length)
        {
            for (int i = 0; i < length; i++)
            {
                var matrixSymbol = new MatrixSymbol
                {
                    Symbol = MatrixSymbols.GetRandomChar(),
                    Position = new Point<int>(StartPosition.X, StartPosition.Y - i),
                    Color = (i == 0) ? leadColor : ((i == length-1) ? endColor : normalColor)
                };
                _matrixSymbols.Add(matrixSymbol);
            }            
        }

        public bool HasSymbolsLeft()
        {
            return (_matrixSymbols.Count > 0);
        }

        public void Update()
        {
            // move down
            for (int i = 0; i < _matrixSymbols.Count; i++)
            {
                var symbol = _matrixSymbols[i];
                symbol.Update();
                if (symbol.Position.Y >= Console.WindowHeight)
                {
                    _matrixSymbols.Remove(symbol);
                }
            }
        }

        public void Render()
        {
            foreach(var symbol in _matrixSymbols)
            {
                symbol.Render();
            }
        }
    }
}