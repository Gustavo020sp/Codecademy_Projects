using System;
using System.Collections.Generic;
using System.Text;

namespace GameList
{
    internal class Game
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public int Year { get; set; }
        public double Avg { get; set; }

        public string ToString()
        {
            return Name;
        }
    }


}

