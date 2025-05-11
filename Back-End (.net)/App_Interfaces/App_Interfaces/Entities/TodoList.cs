using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Interfaces.Entities
{
    internal class TodoList
    {
        //properties
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        //constructors
        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }
    }
}
