using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoUygulaması
{
    public class PersonInfo
    {
        public static List<Person> person = new List<Person>();

        public PersonInfo()
        {
            person.Add(new Person(1, "Sümeyye Coşkun"));
            person.Add(new Person(2, "Büşra Işık"));
            person.Add(new Person(3, "Kader Yılmaz"));
            person.Add(new Person(4, "Bulut Kedi"));
        }
    }
}
