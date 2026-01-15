namespace GameList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Game> Games = new List<Game>
           {
                new Game { Name = "Zelda", Platform = "Switch", Year = 2017, Avg = 9.8 },
                new Game { Name = "God of War", Platform = "PS4", Year = 2018, Avg = 9.6 },
                new Game { Name = "Halo", Platform = "Xbox", Year = 2001, Avg = 9.4 },
                new Game { Name = "Minecraft", Platform = "PC", Year = 2011, Avg = 9.0 },
                new Game { Name = "The Witcher 3", Platform = "PC", Year = 2015, Avg = 9.7 },
                new Game { Name = "Forza", Platform = "Xbox", Year = 2021, Avg = 8.9 }
            };

          
            var pcgames = Games.Where(g => g.Platform == "PC");
            Console.WriteLine("PC Games:");

            foreach (var item in pcgames)
            {
                Console.WriteLine(item.Name);
            }

            var goodgames = Games.Where(g => g.Avg >= 9.5);
            Console.WriteLine("Best Games:");

            foreach (var item in goodgames)
            {
                Console.WriteLine(item.Name);
            }

            var orderedgames = Games.OrderBy(g => g.Year);
            Console.WriteLine("Ordered Games by year:");

            foreach (var item in orderedgames)
            {
                Console.WriteLine(item.Name);
            }

            double lowestavg = Games.Min(g => g.Avg);

            var lowestgamesavg = Games.Where(g => g.Avg == lowestavg);
            Console.WriteLine("Lowest avg game:");

            foreach (var item in lowestgamesavg)
            {
                Console.WriteLine(item.Name);
            }

            //using select
            List<string> GameNames = Games.Select(g => g.Name).ToList();
            Console.WriteLine("New list only Game names:");
            foreach (var item in GameNames)
            {
                Console.WriteLine(item);
            }

            int xboxgames = Games.Count(g => g.Platform == "Xbox");
            

            Console.WriteLine($"Total Xbox games in the list: {xboxgames}");
            
            //groupby
            var pccategory = Games.GroupBy(g => g.Platform).ToList();

            Console.WriteLine("PC GAMES LIST:");

            foreach (var group in pccategory)
            {
                Console.WriteLine(group.Key);

                foreach (var jogo in group)
                {
                    Console.WriteLine(jogo.Name);
                }
            }
        }
    }
}


