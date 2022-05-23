// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class MainProgram
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentTime = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}. It is Present Day {currentTime:d}, at Present Time {currentTime:t}!");
            Console.WriteLine("Press any key to exit program....");
            Console.ReadKey(true);
        }
    }
}