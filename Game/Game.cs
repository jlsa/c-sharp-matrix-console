using System;

namespace Game
{
    public class Game
    {
        public World world {get; set;}
        public Game()
        {
            world = new World();
            Console.WriteLine(world.GetWorldState());
        }
    }
}