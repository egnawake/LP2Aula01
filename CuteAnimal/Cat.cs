using System;

namespace CuteAnimal
{
    public class Cat
    {
        private int age;
        private string species;
        private Mood mood;
        private Feed feedStatus;
        private int energy;

        private Random rand;

        public string Name { get; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    age = 0;
                    return;
                }
                age = value;
            }
        }
        public int Energy
        {
            get
            {
                return energy;
            }
            set
            {
                if (value < 0)
                {
                    energy = 0;
                    return;
                }
                if (value > 100)
                {
                    energy = 100;
                    return;
                }
                energy = value;
            }
        }

        private Cat()
        {
            rand = new Random();
            Energy = rand.Next(101);
        }

        public Cat(string name, int age, string species,
            Mood mood, Feed feedStatus) : this()
        {
            Name = name;
            Age = age;
            this.species = species;
            this.mood = mood;
            this.feedStatus = feedStatus;
        }

        public Cat(string name) : this(name, 1, "None", Mood.Happy,
            Feed.AboutToExplode)
        {
        }

        public void Play()
        {
            if (mood == Mood.Grumpy)
            {
                Console.WriteLine($"{Name} doesn't want to play.");
                return;
            }
            Console.WriteLine($"{Name} played with its mouse toy.");
        }

        public override string ToString()
        {
            return $"{Name} | Age: {Age} | Energy: {Energy}";
        }
    }
}
