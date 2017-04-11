using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTool
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
        
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.Beep();

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Bitte geben Sie eine WWW-Adresse an:");
                    string uriString = Console.ReadLine();
                    string host;
                    try
                    {
                        UriBuilder uriBuilder = new UriBuilder("http", uriString);
                        Uri uri = uriBuilder.Uri;
                        host = uri.Host;
                        Console.WriteLine();
                        Console.WriteLine($"Der Host lautet '{host}'");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    Console.WriteLine("Q für beenden. Ansonsten andere Taste");
                } while (Console.ReadKey(true).Key != ConsoleKey.Q);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
