using System;
using RPGConsoleGame.@class;

namespace RPGConsoleGame
{
    class Program
    {
        private static GameService gameService = new GameService();
        static void Main(string[] args)
        {
            Console.Clear();
            MakeTitle();
            MakeMainMenu();
        }

        private static void MakeTitle()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n");

            Console.WriteLine("******************************************************************************************************************************************");
            Console.WriteLine(" ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄            ▄▄▄▄▄▄▄▄▄▄▄       ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄    ");
            Console.WriteLine("▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌          ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌   ");
            Console.WriteLine("▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░█▀▀▀▀▀▀▀█░▌▐░▌          ▐░█▀▀▀▀▀▀▀▀▀      ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀▀▀    "); 
            Console.WriteLine("▐░▌          ▐░▌       ▐░▌▐░▌▐░▌    ▐░▌▐░▌          ▐░▌       ▐░▌▐░▌          ▐░▌               ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌             ");
            Console.WriteLine("▐░▌          ▐░▌       ▐░▌▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░▌       ▐░▌▐░▌          ▐░█▄▄▄▄▄▄▄▄▄      ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░▌ ▄▄▄▄▄▄▄▄    ");
            Console.WriteLine("▐░▌          ▐░▌       ▐░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░▌          ▐░░░░░░░░░░░▌     ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌▐░░░░░░░░▌   ");
            Console.WriteLine("▐░▌          ▐░▌       ▐░▌▐░▌   ▐░▌ ▐░▌ ▀▀▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌▐░▌          ▐░█▀▀▀▀▀▀▀▀▀      ▐░█▀▀▀▀█░█▀▀ ▐░█▀▀▀▀▀▀▀▀▀ ▐░▌ ▀▀▀▀▀▀█░▌   ");
            Console.WriteLine("▐░▌          ▐░▌       ▐░▌▐░▌    ▐░▌▐░▌          ▐░▌▐░▌       ▐░▌▐░▌          ▐░▌               ▐░▌     ▐░▌  ▐░▌          ▐░▌       ▐░▌   ");
            Console.WriteLine("▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄█░▌▐░▌     ▐░▐░▌ ▄▄▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄▄▄▄▄      ▐░▌      ▐░▌ ▐░▌          ▐░█▄▄▄▄▄▄▄█░▌   ");
            Console.WriteLine("▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░▌      ▐░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌     ▐░▌       ▐░▌▐░▌          ▐░░░░░░░░░░░▌   ");
            Console.WriteLine(" ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀        ▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀       ▀         ▀  ▀            ▀▀▀▀▀▀▀▀▀▀▀    ");
            Console.WriteLine("******************************************************************************************************************************************\n\n");
            
        }

        private static void MakeMainMenu()
        {
            MenuOptions();
            var validation = false;

            while (!validation)
            {
                switch(Console.ReadLine().ToUpper())
                {
                    case "S":
                        gameService.StartGame();
                        validation = true;
                        break;
                    case "L":
                        LoadGame();
                        validation = true;
                        break;
                    case "C":
                        CreateCharacter();
                        validation = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid character!\n");
                        MenuOptions();
                        validation = false;
                        break;

                }
                
            }

        }

     

        private static void LoadGame()
        {
            Console.WriteLine("load game");
        }

        private static void CreateCharacter()
        {
            Console.WriteLine("character creation");
        }

        private static void MenuOptions()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("(S)tart a new game");
            Console.WriteLine("(L)oad a game");
            Console.WriteLine("(C)reate new character");
        }
    }

}
