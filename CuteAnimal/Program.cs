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
            Cat lucas = new Cat("Lucas", -23, "Siamese", Mood.Happy, Feed.Full);

            Console.WriteLine(bob);
            Console.WriteLine(harry);
            Console.WriteLine(garfield);
            Console.WriteLine(lucas);
        }
    }
}
