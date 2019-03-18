using System;
using System.Threading;
using Game.Math;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new Matrix.Matrix();

            while (true) 
            {
                matrix.Render();
                matrix.Update();
                Thread.Sleep(125);
            }
        }
    }
}


// https://www.youtube.com/watch?v=rpWrtXyEAN0\
// based on this video
// the trail should move down but when a symbol is placed on a spot keep it there.
// the symbol has a random chance to change to another symbol.
// trails should not overlap
// trails start at random moments not only when another reaches the end.