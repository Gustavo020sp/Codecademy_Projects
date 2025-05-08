namespace Bibliographical_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Resource test = new Resource("Title", "Horror");
            //test.GetInfo();

            Book book1 = new Book("Charles Petzold", "Code: The Hidden Language of Computer Hardware and Software", "Non-Fiction", 396);
            book1.GetInfo();

            Periodical p1 = new Periodical("Wired", "Technology", "Monthly");
            p1.UpdateStatus("Out");
            Console.WriteLine(p1.Status);

            Video v = new Video("Alex Garland", 108, "On-Demand", "Ex Machina", "Sci-FI");
            v.GetInfo();
        }
    }
}
