namespace School
{
    using System;

    public class Student : People
    {
        private int numberInClass;

        public Student(string name, int numberInClass)
            : base(name)
        {
            this.NumberInClass = numberInClass;
        }

        public int NumberInClass
        {
            get
            {
                return this.numberInClass;
            }

            set
            {
                this.numberInClass = value;
            }
        }
    }
}