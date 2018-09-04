using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGameTe16
{
    class Program
    {
        static int spelareX = 1;
        static int spelareY = 1;

        static void Main(string[] args)
        {
            Initialize();

            while (true)
            {
                Update();
                Draw();
            }
        }

        static void Initialize()
        {

        }

        static void Update()
        {
            //Läser in tangenttryckningar
            var key = Console.ReadKey();

            switch(key.Key)
            {
                case ConsoleKey.LeftArrow:
                    spelareX--;
                    break;
                case ConsoleKey.RightArrow:
                    spelareX++;
                    break;
                case ConsoleKey.UpArrow:
                    spelareY--;
                    break;
                case ConsoleKey.DownArrow:
                    spelareY++;
                    break;
            }
        }

        static void Draw()
        {
            Console.Clear();
            for(int y = 0; y < 10; y++) { 
                for(int x=0; x < 10; x++)
                {
                    if (x == spelareX && y == spelareY)
                        Console.Write("@");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
