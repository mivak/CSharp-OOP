namespace School
{
    using System;

    public class People
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
        }
     
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }
    }
}