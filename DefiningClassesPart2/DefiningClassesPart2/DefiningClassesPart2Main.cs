namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DefiningClassesPart2Main
    {
        public static void Main()
        {
            Point3D firstPoint = new Point3D(1, 2, 3);
            Point3D secondPoint = new Point3D(5, -2, 13);
            Point3D startCoord = new Point3D(0, 0, 0);
            Console.Write("Start point: {0}", startCoord);
            Console.WriteLine("Point 1: {0}", firstPoint.ToString());
            Console.WriteLine("Point 2: {0}", secondPoint.ToString());

            Console.WriteLine("Distance: {0}", CalcPoints3D.CalcDistance(firstPoint, secondPoint));

            List<Path> pointHistory = new List<Path>();

            Path firstPath = new Path(3, 7, 15);
            Path secondPath = new Path(4, 10, 16);
            Path thirdPath = new Path(6, 0, 18);
            pointHistory.Add(firstPath);
            pointHistory.Add(secondPath);
            pointHistory.Add(thirdPath);
            
            Console.WriteLine("\nSave path history:\n");
            StringBuilder buffer = new StringBuilder();

            foreach (var path in pointHistory)
            {
                Console.WriteLine(path.ToString());
                buffer.Append(path.ToString() + "\r\n");
            }

            PathStorage.SavePath(@"..\..\Save.txt", buffer.ToString());
            Console.WriteLine("\nLoad path history:\n");            
            Console.WriteLine(PathStorage.LoadPath(@"..\..\Save.txt"));

            GenericList<int> array = new GenericList<int>(8);
            array.Add(5);
            array.Add(8);
            array.Add(3);
            array.InsertAt(88, 2);
            array.Add(33);
            array.InsertAt(1337, 3);
            array.InsertAt(1338, 4);
            string result = array.ToString();
            Console.WriteLine(result);

            double[,] firstMatrix = { { 0, 2, 3, 4.2 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            double[,] secondMatrix = { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 1, 0, 3, 4 } };

            Matrix<double> arrFirst = new Matrix<double>(firstMatrix);
            Matrix<double> arrSecond = new Matrix<double>(secondMatrix);

            if (arrFirst)
            {
                Console.WriteLine("There is no zero inside");
            }
            else
            {
                Console.WriteLine("There is at least one zero inside\n");
            }

            Console.WriteLine("Sum of the matrixes:\n{0}", arrFirst + arrSecond);
            Console.WriteLine("\nSubtraction of the matrixes:\n{0}", arrFirst - arrSecond);
            Console.WriteLine("\nMultiplication of the matrixes:\n{0}", arrFirst * arrSecond);

            VersionDemo.Demo();           
        }
    }
}