namespace School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private readonly List<Class> classes;
    
        public School(Class[] classes)
        {
            this.classes = new List<Class>(classes);
        }
      
        public Class[] Classes
        {
            get
            {
                return this.classes.ToArray();
            }

            private set
            {
            }
        }

        public void AddClass(Class @class)
        {
            this.classes.Add(@class);
        }

        public void RemoveClass(Class @class)
        {
            this.classes.Remove(@class);
        }
    }
}