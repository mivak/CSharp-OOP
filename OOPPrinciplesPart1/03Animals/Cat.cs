namespace Animals
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, AnimalSex sex) : base(name, age, sex)
        {
        }

        public void ProduceSound()
        {
            System.Console.WriteLine(this.Name + " says meow");
        }
    }
}