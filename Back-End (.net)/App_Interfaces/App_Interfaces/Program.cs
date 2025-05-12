using App_Interfaces.Entities;

namespace App_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            tdl.Add("Bloom");
            tdl.Add("Random");
            tdl.Add("Buy milk");
            tdl.Display();
            tdl.Reset();
            tdl.Display();

            PasswordManager pm = new PasswordManager("iluvpie", false);
            pm.Display();
            //pm.Reset();
            pm.ChangePassword("iluvpie", "oio");
            pm.Display();
        }
    }
}
