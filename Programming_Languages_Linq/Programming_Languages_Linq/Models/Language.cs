using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Languages_Linq.Models
{
    internal class Language
    {
        public static Language FromTsv(string tsvLine)
        {
            string[] values = tsvLine.Split('\t');

            return new Language(
                Convert.ToInt32(values[0]),
                values[1],
                values[2],
                values[3]);
        }

        public int Year { get; set; }
        public string Name { get; set; }
        public string ChiefDeveloper { get; set; }
        public string Predecessors { get; set; }

        public Language(int year, string name, string chiefDeveloper, string predecessors)
        {
            Year = year;
            Name = name;
            ChiefDeveloper = chiefDeveloper;
            Predecessors = predecessors;
        }

        public string Prettify()
        {
            return $"{Year}, {Name}, {ChiefDeveloper}, {Predecessors}";
        }
    }
}
