using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirtyAssignment2
{
    internal class MenuDB
    {
        internal static void MenuChoices()
        {
            Console.WriteLine("Choose a database type:");
            Console.WriteLine("1. MongoDB");
            Console.WriteLine("2. MySQL");
            Console.WriteLine("3. SQLite");
            Console.WriteLine("4. API");
            Console.WriteLine("5. Exit\n");

            Console.Write("Enter your choice: ");
            
            string? menuInput = Console.ReadLine();
            switch (menuInput)
            {
                case "1":
                    MongoDB.MongoDBMenu();
                    break;
                case "2":
                    MySQL.MySQLMenu();
                    break;
                case "3":
                    SQLite.SQLiteMenu();
                    break;
                case "4":
                    API.APIMenu();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.\n");
                    MenuChoices();
                    break;
            }
        }
    }
}
