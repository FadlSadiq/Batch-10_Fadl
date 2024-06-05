using Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Controller
{
    public class CommunityPool : ICommunityPool
    {
        public bool IsOpen { get; private set; }

        public void OpenCommunityPool(GameState gameState)
        {
            // if (gameState == GameState.Preparation)
            // {
            //     string result;
            //     using (StreamReader sr = new StreamReader("../AutoChess/Data/HeroBackUp.Json"))
            //     {
            //         result = sr.ReadToEnd();
            //         Dictionary<string, List<HeroData>> heroes = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, List<HeroData>>>(result);
            //         Random rnd = new Random();
            //         for (int i = 0; i < 5; i++)
            //         {
            //             int heroIndex = rnd.Next(0, heroes.Count);
            //             KeyValuePair<string, List<HeroData>> heroPair = heroes.ElementAt(heroIndex);
            //             string heroName = heroPair.Key;
            //             HeroData heroData = heroPair.Value[0];
            //             GameController.

            // Dictionary<string, List<HeroData>> heroes = LoadHeroesFromFile();
            // }
            // Display hero data in a table-like format
            // Console.WriteLine("Available Heroes:");
            // Console.WriteLine("----------------------------------");
            // Console.WriteLine("| Hero Name      | Rarity | Price |");

            // Random rnd = new Random();
            // for (int i = 0; i < 5; i++)
            // {
            //     int heroIndex = rnd.Next(0, heroes.Count);
            //     KeyValuePair<string, List<HeroData>> heroPair = heroes.ElementAt(heroIndex);
            //     string heroName = heroPair.Key;
            //     HeroData heroData = heroPair.Value[0];

            // Console.WriteLine($"| {heroName,-16} | {heroData.HeroRarity,-8} | {heroData.HeroPrice,-5} |");
            // }

            // Console.WriteLine("----------------------------------");
            //         }
            //     }
            // }

            // private Dictionary<string, List<HeroData>> LoadHeroesFromFile()
            // {
            //     string result;
            //     using (StreamReader sr = new StreamReader("../AutoChess/Data/HeroBackUp.Json"))
            //     {
            //         result = sr.ReadToEnd();
            //     }
            //     return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, List<HeroData>>>(result);
            // }


        }
        public void CloseCommunityPool()
        {
            Console.Clear();
            Program.Start();
        }
    }
}