using CustomMiddleware.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddleware.Models.Service
{
    public class PersonService
    {
        public List<Person> getAllPerson()
        {
            return new List<Person> { new Person(1, "erfan", "kazemi"),new Person(2,"mohammad","moghadam") };
        }
    }
}
