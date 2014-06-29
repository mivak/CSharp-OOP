namespace School
{
    using System;

    public class Discipline
    {
        private int exercisesCount;
        private int lecturesCount;
        private string name;

        public Discipline(string name, int exercisesCount, int lecturesCount)
        {
            this.Name = name;
            this.ExercisesCount = exercisesCount;
            this.LecturesCount = lecturesCount;
        }

        public int ExercisesCount
        {
            get
            {
                return this.exercisesCount;
            }

            set
            {
                this.exercisesCount = value;
            }
        }

        public int LecturesCount
        {
            get
            {
                return this.lecturesCount;
            }
 
            set
            {
                this.lecturesCount = value;
            }
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