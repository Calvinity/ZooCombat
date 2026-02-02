using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooCombat.Entities;

namespace ZooCombat.Menu
{
    internal class LoggedInMenu
    {
        public static bool ZooMenu(int? currentPlayerId)
        {
            Console.WriteLine(@"Welcome {currentPlayerId}!");
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine();
            Console.WriteLine("1 Animals");
            Console.WriteLine("2 Pick an animal");
            Console.WriteLine("9 Exit");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine();
            Console.Write("Enter Option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Console.WriteLine("not available yet");
                        return true;
                    }
                case "2":
                    {
                        Console.WriteLine("not available yet");
                        return true;
                    }
                case "3":
                    {

                        return true;
                    }
                case "9":
                    {
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        return false;
                    }
                default:
                    {
                        Console.WriteLine("Invalid option. Please try again.");
                        return true;
                    }
            }
        }
    }
}
