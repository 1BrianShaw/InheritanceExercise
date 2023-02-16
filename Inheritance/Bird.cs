using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public int FlockSize { get; set; }

        public string From { get; set; }

        public bool CanFly { get; set; }

        public bool HasFeathers { get; set; }

        public Bird()
        {

        }
        public Bird(string name, int age, int legs, bool hasBackbone, bool hasFeathers, bool canFly, int flockSize, string from)
        {
            Name = name;
            Age = age;
            Legs = legs;
            HasBackbone= hasBackbone;
            HasFeathers= hasFeathers;
            FlockSize = flockSize;
            From = from;
        }
    }
}
