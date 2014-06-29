namespace Animals
{
    using System;
    public abstract class Animal
    {
        private readonly int age;
        private readonly string name;
        private readonly AnimalSex sex;

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
            }
        }

        public AnimalSex Sex
        {
            get
            {
                return this.sex;
            }

            private set
            {
            }
        }

        public Animal(string name, int age, AnimalSex sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public void IdentifyAnimal()
        {
            Console.WriteLine("I am a " + GetType().Name);
        }
        
        
        public static double Average(Animal[] array)
        {
            double sum = 0;
            double averige = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i].age;
            }

            averige = sum / array.Length;
            return averige;
        }
    }
}