using System;

namespace CuteAnimal
{
    public class Cat
    {
        private string name;
        private int age;
        private string species;
        private Mood mood;
        private Feed feedStatus;

        public Cat(string name, int age, string species,
            Mood mood, Feed feedStatus)
        {
            this.name = name;
            this.age = age;
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
                Console.WriteLine($"{name} doesn't want to play.");
                return;
            }
            Console.WriteLine($"{name} played with its mouse toy.");
        }
    }
}
