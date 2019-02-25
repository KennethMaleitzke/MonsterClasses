using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayWelcomeScreen();
            DisplayMenu();
            DisplayClosingScreen();
        }

        static SeaMonster InitializeSeaMonster()
        {
            return new SeaMonster()
            {
                Id = 34,
                Name = "Suzy",
                Age = 473,
                HasGills = true,
                HomeSea = "Baltic Sea",
                Color = "Blue"
            };
        }

        static SpaceMonster InitializeSpaceMonster()
        {
            return new SpaceMonster()
            {
                Id = 56,
                Name = "Sid",
                Age = 18,
                Galaxy = "Andromeda",
                Color = "Red"
            };
        }

        static EarthMonster InitializeEarthMonster()
        {
            return new EarthMonster()
            {
                Id = 44,
                Name = "Eddy",
                Age = 254,
                Home = "Asia",
                Color = "Brown",
                HasWings = true
            };
        }

        private static void DisplayMenu()
        {
            bool exitMenu = false;
            int menuSelection;
            SeaMonster mySeaMonster;
            SpaceMonster mySpaceMonster;
            EarthMonster myEarthMonster;

            mySeaMonster = InitializeSeaMonster();
            mySpaceMonster = InitializeSpaceMonster();
            myEarthMonster = InitializeEarthMonster();

            do
            {
                Console.Clear();
                DisplayHeader("Menu");
                Console.WriteLine("1) Display Monsters");
                Console.WriteLine("2) Exit");
                Console.WriteLine();
                Console.Write("Enter Selection:");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out menuSelection))
                    {

                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Clear();
                        DisplayHeader("Menu");
                        Console.WriteLine("1) Display Monsters");
                        Console.WriteLine("2) Exit");
                        Console.WriteLine();
                        Console.WriteLine("Please Enter a valid response!");
                        Console.WriteLine();
                        Console.Write("Enter Selection:");
                    }
                }

                switch (menuSelection)
                {
                    case 1:
                        DisplayMonsterInfoScreen(mySeaMonster, mySpaceMonster, myEarthMonster);
                        break;
                    case 2:
                        exitMenu = true;
                        break;
                    case 3:
                        DisplayEditSeaMonster(mySeaMonster);
                        break;
                    default:
                        Console.WriteLine("Please Enter a proper selection.");
                        DisplayContinuePrompt();
                        break;
                }
            } while (!exitMenu);

        }

        

        private static void DisplayEditSeaMonster(SeaMonster mySeaMonster)
        {
            DisplayHeader("Edit Sea Monster Info");
        }

        private static void DisplayMonsterInfoScreen(SeaMonster seaMonster, SpaceMonster spaceMonster, EarthMonster earthMonster)
        {
            DisplayHeader("Monster Info");

            Console.WriteLine("Sea Monster");
            DisplaySeaMonsterInfo(seaMonster);

            Console.WriteLine();
            Console.WriteLine("Space Monster");
            DisplaySpaceMonsterInfo(spaceMonster);

            Console.WriteLine();
            Console.WriteLine("Earth Monster");
            DisplayEarthMonsterInfo(earthMonster);

            DisplayContinuePrompt();
        }

        private static void DisplayEarthMonsterInfo(EarthMonster earthMonster)
        {
            Console.WriteLine($"Id: {earthMonster.Id}");
            Console.WriteLine($"Name: {earthMonster.Name}");
            Console.WriteLine($"Age: {earthMonster.Age}");
            Console.WriteLine($"Home: {earthMonster.Home}");
            Console.WriteLine($"Is Happy: {(earthMonster.IsHappy() ? "yes" : "no")}");
            Console.WriteLine($"Color: {earthMonster.Color}");

        }


        private static void DisplaySpaceMonsterInfo(SpaceMonster spaceMonster)
        {
            Console.WriteLine($"Id: {spaceMonster.Id}");
            Console.WriteLine($"Name: {spaceMonster.Name}");
            Console.WriteLine($"Age: {spaceMonster.Age}");
            Console.WriteLine($"Galaxy: {spaceMonster.Galaxy}");
            Console.WriteLine($"Is Happy: {(spaceMonster.IsHappy() ? "yes" : "no")}");
            Console.WriteLine($"Color: {spaceMonster.Color}");

            Console.WriteLine($"You attacked {spaceMonster.Name} and they {spaceMonster.MonsterBattleResponse()}");
        }

        private static void DisplaySeaMonsterInfo(SeaMonster seaMonster)
        {
            Console.WriteLine($"Id: {seaMonster.Id}");
            Console.WriteLine($"Name: {seaMonster.Name}");
            Console.WriteLine($"Age: {seaMonster.Age}");
            Console.WriteLine($"Galaxy: {seaMonster.HomeSea}");
            Console.WriteLine($"Has Gills {seaMonster.HasGills}");
            Console.WriteLine($"Is Happy: {seaMonster.IsHappy()}");
            Console.WriteLine($"Color: {seaMonster.Color}");
        }

        static void DisplayWelcomeScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tWelcome to My App");
            DisplayContinuePrompt();
        }

        static void DisplayClosingScreen()
        {
            Console.Clear();
            Console.WriteLine("\t\tThank you for using My App");
            DisplayContinuePrompt();
        }

        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }


        static void DisplayHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(headerText);
            Console.WriteLine();
        }
    }
}
