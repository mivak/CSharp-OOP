namespace DefiningClassesPart2
{
    using System;

    public static class CalcPoints3D
    {
        public static double CalcDistance(Point3D point1, Point3D point2)
        {
            double distance = 0;
            double temp = 0;
           
            temp = point1.X - point2.X;
            distance += temp * temp;
    
            temp = point1.Y - point2.Y;
            distance += temp * temp;

            temp = point1.Z - point2.Z;
            distance += temp * temp;

            return distance;
        }
    }
}