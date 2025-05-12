using Escape_Room_Adventure.Entities;

namespace Escape_Room_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FieldAgent agent1 = new FieldAgent("Agent Smith", 007);
            FieldAgent agent2 = agent1;

            agent2.SecretCode = 999;

            //referencial type in action
            Console.WriteLine(agent1.SecretCode); //prints 999
            Console.WriteLine(agent2.SecretCode); // prints 999

            File file1 = new File("Confidential.txt", 1024);
            File file2 = new File("Confidential.txt", 1024);

            bool sameFile = file1 == file2;

            Console.WriteLine(sameFile); // prints false !

            Server mainServer = new Server("Active");
            Server backupServer = new Server("Inactive");


            //this is where interfaces becomes essencial...
            ISystem[] systems = [mainServer, backupServer];

            foreach (ISystem system in systems) 
            {
                system.Operate();
            }



        }
    }
}
