using System;
using System.Threading;

namespace Snake_game
{
    class Snake
    {
        int Height = 20;
        int Width = 30;

        ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
        char key = 'w';
        public void Palya()
        {
            //pálya készítése
            Console.Clear();
            for (int i = 1; i <= (Width + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write(".");
            }
            for (int i = 1; i <= (Width + 2); i++)
            {
                Console.SetCursorPosition(i, (Height+2));
                Console.Write(".");
            }
            for (int i = 1; i <= (Height + 1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write(".");
            }
            for (int i = 1; i <= (Height + 1); i++)
            {
                Console.SetCursorPosition((Width+2), i);
                Console.Write(".");
            }
        public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyinfo = Console.ReadKey(true);
                key = keyinfo.KeyChar;
            } 
        }
        }
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            snake.Palya();
            Console.ReadKey();
        }
    }
}
