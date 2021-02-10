using MockData.Model;
using System;
using System.Collections.Generic;

namespace MockData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            for (int i = 0; i < 10; i++)
            {
                var person = new Person
                {
                    Id = i,
                    Name = i.ToString()
                };

                persons.Add(person);
            }

            foreach (Person person in persons)
            {
                Console.WriteLine(person.Id);
            }
        }
    }
}
