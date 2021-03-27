using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddleware.Models.Entity
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }


        public Person(int id, string name, string family)
        {
            Id = id;
            Name = name;
            Family = family;
        }
    }
}
