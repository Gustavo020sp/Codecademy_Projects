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

            var languagesearch = languages.Where(l => l.Year > 1994 && l.Year < 2006);
            int countsearch = languagesearch.Count();
            Console.WriteLine($"Total Languages between 1995 and 2005: {countsearch}");




        }
    }
}
