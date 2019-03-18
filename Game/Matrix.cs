using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

using Game.Math;

namespace Matrix
{
    public class Matrix
    {
        List<Trail> Trails = new List<Trail>(); 
        Random random = new Random();

        int MaxTrails = Console.WindowWidth / 4;


        public Matrix()
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            AddTrail();
        }

        public void Update()
        {
            if(Trails.Count < MaxTrails) {
                AddTrail();
            }
            
            for(int i = 0; i < Trails.Count; i++)
            {
                var trail = Trails.ElementAt(i);
                trail.Update();

                if (!trail.HasSymbolsLeft())
                {
                    Trails.RemoveAt(i);
                }
                trail = null;
            }
        }

        public void Render()
        {
            // clear the console.
            Console.Clear();
        
            foreach (var trail in Trails)
            {
                trail.Render();
            }
        }

        private void AddTrail()
        {
            int width = Console.WindowWidth;
            int height = Console.WindowHeight;

            var position = new Point<int>(random.Next(0, width), 0);
            
            var trail = new Trail(position, random.Next(5, height));
            Trails.Add(trail);
        }

        private void AddTrails(int amount)
        {
            int i = 0;
            while(i < amount)
            {
                AddTrail();
                i++;
            }
        }
    }
}