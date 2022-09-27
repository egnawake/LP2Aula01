using System;

namespace CuteAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat bob = new Cat("Bob", 4, "Persian", Mood.Grumpy, Feed.Starving);
            Cat harry = new Cat("Harry", 2, "Siamese", Mood.HyperActive,
                Feed.Satisfied);
            Cat garfield = new Cat("Garfield");

            Console.WriteLine(bob.GetName());
            Console.WriteLine(harry.GetName());
            Console.WriteLine(garfield.GetName());
        }
    }
}
