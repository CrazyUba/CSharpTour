using System;

namespace CSharpTour
{
    class Hello
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("Hello world!!!");

            Console.CursorVisible = false;
            Console.Title = "My Program";

            Console.Beep(1000, 500);
            Console.Beep();



            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR :)");

            Console.ReadKey();

            Console.ResetColor();
            Console.Clear();

        }
    }
}
