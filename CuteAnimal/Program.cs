using System;

namespace CuteAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat bob = new Cat("Bob", 4, "Persian", Mood.Grumpy, Feed.Starving,
                OwnedToys.Fish | OwnedToys.Ball);
            Cat harry = new Cat("Harry", 2, "Siamese", Mood.HyperActive,
                Feed.Satisfied, OwnedToys.Ball);
            Cat garfield = new Cat("Garfield");
            Cat lucas = new Cat("Lucas", -23, "Siamese", Mood.Happy, Feed.Full,
                OwnedToys.None);
            Cat lisa = new Cat("Lisa", 6, "Siamese", Mood.Happy, Feed.Full,
                OwnedToys.Bird | OwnedToys.Fish);

            Console.WriteLine(bob);
            Console.WriteLine(harry);
            Console.WriteLine(garfield);
            Console.WriteLine(lucas);

            Console.WriteLine(Cat.NumberOfCats);

            Console.WriteLine($"{bob.Name}'s toys: {bob.Toys}");
            Console.WriteLine($"{harry.Name}'s toys: {harry.Toys}");
            Console.WriteLine($"{lucas.Name}'s toys: {lucas.Toys}");
            Console.WriteLine($"{lisa.Name}'s toys: {lisa.Toys}");
        }
    }
}
