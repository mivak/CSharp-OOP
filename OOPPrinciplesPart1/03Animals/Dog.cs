namespace Animals
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, AnimalSex sex) : base(name, age, sex)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine(this.Name + " says bau");
        }
    }
}