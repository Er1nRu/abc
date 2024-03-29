using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class Person
    {
        static public List<Person> List = new List<Person>();
        public Person(string nick, string date)
        {
            Nick = nick;
            Date = date;
            List.Add(this);
        }

        public string Nick { get; set; }
        public string Date { get; set; }
    }
}
