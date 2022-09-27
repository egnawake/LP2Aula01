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
