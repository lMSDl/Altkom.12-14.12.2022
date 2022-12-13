using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Creational.Prototype
{
    public class Person : ICloneable
    {

        public Person Parent { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Address Address { get; set; }

        public ICollection<Person> Children { get; set; }


        public object Clone()
        {
            var clone = (Person)MemberwiseClone();
            clone.Address = (Address)Address.Clone();

            clone.Children = Children?.ToList(); //new List<Person>(Children);
            return clone;
        }

        public object DeepClone()
        {
            var clone = (Person) MemberwiseClone();
            clone.Address = (Address)Address.Clone();

            clone.Parent = (Person)Parent?.DeepClone();
            clone.Children = Children?.Select(x => (Person)x.DeepClone()).ToList();
            return clone;
        }

        public object ShallowClone()
        {
            return MemberwiseClone();
        }
    }
}
