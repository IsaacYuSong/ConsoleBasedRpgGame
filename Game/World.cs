using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Game
{
    public class World
    {
        private const int WorldWidth = 50;
        private const int WorldHeight = 50;
        private static char[,] gameWorld = new char[WorldHeight, WorldWidth];

        public static void DisplayWorld()
        {
            Console.WriteLine("Welcome");
            

            for (int y = 0; y < WorldHeight; y++)
            {
                for (int x = 0; x < WorldWidth; x++)
                {
                    
                    Console.WriteLine(gameWorld[y, x] + "X");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Hello isaac");
        }
    }
}
