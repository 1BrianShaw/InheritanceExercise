using System;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird Ostrich = new Bird()
            {
                Name = "Ostrich",
                Age = 30,
                Legs = 2,
                HasBackbone = true,
                HasFeathers = true,
                CanFly = false,
                FlockSize = 10,
                From = "African Savanah",
            };
            Console.WriteLine($"--------------Information on the {Ostrich.Name}------------------------");
            Console.WriteLine();
            Console.WriteLine($"The {Ostrich.Name} lives in the {Ostrich.From}.");
            Console.WriteLine($"They have {Ostrich.Legs} poweful legs and commonly live in groups of {Ostrich.FlockSize} and can reach {Ostrich.Age} years old.");
            Console.WriteLine($"It is {Ostrich.HasBackbone} it is a vertibre; it is {Ostrich.HasFeathers} it has feathers;  But unlike other birds it is {Ostrich.CanFly} that it can fly.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile Croc = new Reptile()
            {
                Name = "Crocodile",
                Age = 60,
                Legs = 4,
                HasBackbone = true,
                IsColdBlooded = true,
                HasScales = true,
                Environment = "Freshwater and Saltwater",
                Defense = "bite",
            };

            Console.WriteLine($"--------------Information on the {Croc.Name}------------------------");
            Console.WriteLine();
            Console.WriteLine($"The {Croc.Name} has {Croc.Legs}, lives in {Croc.Environment} swams, inlets, and rivers, and has {Croc.Legs}");
            Console.WriteLine($"It is {Croc.HasBackbone} that they are vertibrates; It is {Croc.IsColdBlooded} that it is Cold blooded; It is {Croc.HasScales} that it has scales.");
            Console.WriteLine($"If you see a {Croc.Name} it could be as much as {Croc.Age} years old.");

        }



    }
}
