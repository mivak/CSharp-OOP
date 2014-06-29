namespace Animals
{
    using System;

    public class AnimalMain
    {
        public static void Main()
        {
            Frog[] frogs = new Frog[] 
            {
                new Frog("Gosho", 2, AnimalSex.Male),
                new Frog("Pesho", 1, AnimalSex.Male),
                new Frog("Beti", 3, AnimalSex.Female)
            };

            Dog[] dogs = new Dog[] 
            {
                new Dog("Vlado", 2, AnimalSex.Male),
                new Dog("Sara", 1, AnimalSex.Female),
                new Dog("Roki", 2, AnimalSex.Male)
            };

            Cat[] cats = new Cat[]
            {
                new Cat("Kitty", 2, AnimalSex.Female),
                new Cat("Boni", 1, AnimalSex.Female),
                new Cat("Goldi", 3, AnimalSex.Male)
            };

            dogs[2].IdentifyAnimal();
            cats[1].IdentifyAnimal();
            frogs[0].ProduceSound();

            Console.WriteLine("Average age of dogs " + Animal.Average(dogs));
            Console.WriteLine("Average age of frogs " + Animal.Average(frogs));
            Console.WriteLine("Average age of cats " + Animal.Average(cats));
        }
    }
}