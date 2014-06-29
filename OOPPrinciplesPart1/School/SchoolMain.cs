namespace School
{
    using System;

    public class SchoolMain
    {
        public static void Main()
        {
            Student firstStudent = new Student("Ivan", 6);
            Student secondStudent = new Student("Pesho", 9);
            Student thirdStudent = new Student("Vasko", 3);

            Student[] students = new Student[] { firstStudent, secondStudent, thirdStudent };

            Discipline firstDiscipline = new Discipline("OOP", 10, 15);

            Teacher firstTeacher = new Teacher("Gosho", new Discipline[] { firstDiscipline });
            Teacher[] teachers = new Teacher[] { firstTeacher };

            Class firstClass = new Class(students, teachers, "11B");

            Console.Write("The name of the first discipline of the first teacher of the first class: ");
            Console.WriteLine(firstClass.Teachers[0].Disciplines[0].Name);
        }
    }
}