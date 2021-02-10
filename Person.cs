using System.Collections.Generic;

namespace MockData.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Person> Persons = new List<Person>(); 
    }
}
