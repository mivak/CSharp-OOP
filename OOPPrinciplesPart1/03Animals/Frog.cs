namespace Animals
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, AnimalSex sex) : base(name, age, sex)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine(this.Name + " says qwak");
        }
    }
}