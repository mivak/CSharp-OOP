namespace School
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People
    {
        private readonly List<Discipline> disciplines;

        public Teacher(string name, Discipline[] disciplines)
            : base(name)
        {
            this.disciplines = new List<Discipline>(disciplines);
        }

        public Discipline[] Disciplines
        {
            get
            {
                return this.disciplines.ToArray();
            }

            private set
            {
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);
        }
    }
}