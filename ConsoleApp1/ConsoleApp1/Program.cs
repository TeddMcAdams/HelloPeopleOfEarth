using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(" Hello People of Earth!");
            WriteLine();
            WriteLine(" Enter some stuff and I will reverse it!  (maybe) >:)");
            WriteLine();
            Write(" ");
            string userInput = ReadLine();
            WriteLine();
            WriteLine($" Your input: {userInput}");
            WriteLine($" & reversed: {userInput.ReverseIt()}");
            WriteLine($" & special?: {userInput.ReverseItSpecial()}");
            WriteLine();
            Write(" press any key to exit . . . ");
            ReadKey();
        }
    }
}
