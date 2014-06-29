namespace CommonTypeSystem
{
    using System;

    public class Person
    {
        private string name;
        private ushort age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, ushort age) : this(name)
        {
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public ushort Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            if (this.Age == 0)
            {
                return this.Name + " " + "Age not specified";
            }
            else
            {
                return this.Name + " " + this.Age;
            }
        }
    }
}