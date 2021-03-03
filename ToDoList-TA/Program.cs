using System;
using System.Threading.Tasks;

namespace ToDoList_TA
{
    class Program
    {
        async Task ListAllToDos()
        {
            Cli.DisplayLine("Called ListAllToDos()");
        }
        async Task Run()
        {
            Cli.DisplayLine("ToDo Application");
            var option = DisplayMenu();
            while(option != 0)
            {
                switch (option)
                {
                    case 1: await ListAllToDos();
                        break;
                    case 0:
                        return;
                    default:
                        Cli.DisplayLine("Invalid menu option");
                        break;
                }
                option = DisplayMenu();
            }
        }
        int DisplayMenu()
        {
            Cli.DisplayLine("Menu");
            Cli.DisplayLine("1 : List all ToDos");
            Cli.DisplayLine("0 : Exit Menu");
            var option = Cli.GetInt("Enter Menu number");
            return option;
        }

        static async Task Main(string[] args)
        {
            var pgm = new Program();
            await pgm.Run();

            /*
            var aStr = Cli.GetString("Enter a string");
            var aDate1 = Cli.GetDateTime("Enter a valid date");
            var aDate2 = Cli.GetDateTime("Hit enter");
            var anInt = Cli.GetInt("Enter an int");

            Console.WriteLine($"{aStr}");
            Console.WriteLine($"{anInt}");
            Console.WriteLine($"{aDate1} [{aDate2}]");
            */
        }
    }
}
