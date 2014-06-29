namespace School
{
    using System;
    using System.Collections.Generic;

    public class Class
    {
        private readonly List<Teacher> teachers;
        private readonly List<Student> students;
        private string uniqueTextIdentifier;

        public Class(Student[] students, Teacher[] teachers, string uniqueTextIdentifier)
        {
            this.students = new List<Student>(students);
            this.teachers = new List<Teacher>(teachers);
            this.uniqueTextIdentifier = uniqueTextIdentifier;
        }

        public Student[] Students
        {
            get
            {
                return this.students.ToArray();
            }

            private set
            {
            }
        }

        public Teacher[] Teachers
        {
            get
            {
                return this.teachers.ToArray();
            }
            
            private set
            {
            }
        }

        public string UniqueTextIdentifier
        {
            get
            {
                return this.uniqueTextIdentifier;
            }
            
            set
            {
                this.uniqueTextIdentifier = value;
            }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }
    }
}