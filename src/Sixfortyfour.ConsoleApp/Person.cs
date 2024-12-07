using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixfortyfour.ConsoleApp
{
    internal class Person
    {
        [SetsRequiredMembers]
        public Person() => Name = String.Empty;
        public Person(string name) => Name = name;
        public Person(int id, string name) => (Id, Name) = (id, name);

        public int Id { get; set; }
        public required string Name { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}";
        }
    }
}
