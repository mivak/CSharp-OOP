namespace AbstractClassHuman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HumanMain
    {
        public static void Main()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Petar", "Dimitrov", 5));
            students.Add(new Student("Dimitar", "Popov", 7));
            students.Add(new Student("Ivan", "Todorov", 2));
            students.Add(new Student("Vladimir", "Vazov", 8));
            students.Add(new Student("Pencho", "Slaveykov", 6));
            students.Add(new Student("Ivan", "Geshov", 8));
            students.Add(new Student("Georgi", "Rakovski", 9));
            students.Add(new Student("Vasil", "Levski", 11));
            students.Add(new Student("Goce", "Delchev", 3));
            students.Add(new Student("Dimitar", "Petkov", 10));

            var sortedByGrade = students.OrderBy(x => x.Grade);
            foreach (var student in sortedByGrade)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Grade);
            }

            Console.WriteLine("\n");
            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Ivan", "Petrov", 150, 8));
            workers.Add(new Worker("Dimitar", "Dimitrov", 180, 7));
            workers.Add(new Worker("Georgi", "Dimitrov", 200, 8));
            workers.Add(new Worker("Sasho", "Rangelov", 220, 9));
            workers.Add(new Worker("Ivan", "Ikonomov", 230, 10));
            workers.Add(new Worker("Hristo", "Shopov", 190, 9));
            workers.Add(new Worker("Bogdan", "Yordanov", 185, 7.5M));
            workers.Add(new Worker("Ivan", "Kafedjiev", 198, 4.5M));
            workers.Add(new Worker("Simeon", "Mitev", 250, 11));
            workers.Add(new Worker("Ana", "Todorova", 225, 6.5M));

            var sortedByMoneyPerHour =
                from worker in workers
                orderby worker.MoneyPerHour() descending
                select worker;
            foreach (var worker in sortedByMoneyPerHour)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName + " " + worker.MoneyPerHour());
            }

            Console.WriteLine("\n");

            var mergedLists = workers.Concat<Human>(students).ToList();
            mergedLists = mergedLists.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ToList();

            foreach (var human in mergedLists)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }
    }
}