using Programming_Languages_Linq.Models;

namespace Programming_Languages_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Language> languages = File.ReadAllLines("languages.tsv")
        .Skip(1)
        .Select(line => Language.FromTsv(line))
        .ToList();

            var orderalphabetcly = languages.OrderBy(language => language.Name);

            foreach(var item in orderalphabetcly)
            {
                Console.WriteLine(item.Name);
            }

            int latestyear = languages.Min(languages => languages.Year);

            var oldestlanguage  = languages.Where(l => l.Year ==  latestyear);

            foreach (var item in oldestlanguage)
            {
                Console.WriteLine($"Oldest language:{item.Name} create in {item.Year}");
            }

            /*foreach (var item in languages)
            {
                Console.WriteLine(item.Prettify());
            }*/



            /*var csharp = languages.Where(l => l.Name == "C#").ToList();
            foreach (var item in csharp)
            {
                Console.WriteLine(item.Prettify());
            }*/

            /*var microsoft = languages.Where(l => l.ChiefDeveloper == "Microsoft").ToList();
            foreach (var item in microsoft)
            {
                Console.WriteLine(item.Prettify());
            }*/

            /*var lispdesc = languages.Where(l => l.Predecessors == "Lisp").ToList();
            foreach (var item in lispdesc)
            {
                Console.WriteLine(item.Prettify());
            }*/

            /*var containscript = languages.Where(l => l.Name.Contains("Script")).ToList();
            foreach (var item in containscript)
            {
                Console.WriteLine(item.Prettify());
            }*/

            /*int totallanguages = languages.Count;
            Console.WriteLine(totallanguages);*/

            // var filteredlanguages = languages.Where(l => l.Year > 1994 && l.Year < 2006);
            //int countsearch = filteredlanguages.Count();
            // Console.WriteLine($"Total Languages between 1995 and 2005: {countsearch}");


            /* var language_and_year = filteredlanguages.Select(filteredlanguages => (filteredlanguages.Name, filteredlanguages.Year)).ToList();

             foreach (var language in language_and_year)
             {
                 Console.WriteLine($"{language.Name} was invented in {language.Year}");
             }*/

        }
    }
}
