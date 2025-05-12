using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Interfaces.Entities
{
    internal class TodoList : IDisplayable, IResetable
    {
        //properties
        public string HeaderSymbol { get; set; }
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        //constructors
        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        //methods
        public void Add(string todo)
        {
            if (nextOpenIndex < 5)
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }
            else
            {
                Console.WriteLine($"Cannot add more than 5 items to list. [{todo}] was not added!");
            }
        }

        public void Display()
        {
            HeaderSymbol = "-------";

            Console.WriteLine("Todo List: ");
            Console.WriteLine(HeaderSymbol);

            foreach (string todo in Todos)
            {
                if (String.IsNullOrEmpty(todo))
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine(todo);
                }
                    
            }
        }

        public void Reset()
        {
            Console.WriteLine("reseting list...");
            Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}
