using System;
using System.IO;
using Newtonsoft.Json;

namespace RPGConsoleGame.@class
{
    public class GameService
    {
        public GameService()
        {
        }

        public void StartGame()
        {
            var basePath = $"{AppDomain.CurrentDomain.BaseDirectory}";
            string[] Path = basePath.Split("/bin");
            basePath = $"{Path[0]}/adventures";
            var initialAdventure = new Adventure();


            if (File.Exists($"{basePath}/initial.json"))
            {
                var directory = new DirectoryInfo(basePath);
                var initialJsonFile = directory.GetFiles("initial.json");

                using (StreamReader fi = File.OpenText(initialJsonFile[0].FullName))
                {
                    initialAdventure = JsonConvert.DeserializeObject<Adventure>(fi.ReadToEnd());
                }

                Console.WriteLine($"Adventure : {initialAdventure.Title}");
                Console.WriteLine($"Description : {initialAdventure.Description}");

            }
            Console.WriteLine("game started");
        }
    }
    
}
