namespace DefiningClassesPart2
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D startCoord = new Point3D(0, 0, 0);
        private double x;
        private double y;
        private double z;

        public Point3D(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public static Point3D ZeroCoord()
        {
            return startCoord;
        }

        public override string ToString()
        {
            string pointAsString = string.Format("({0},{1},{2})", this.X, this.Y, this.Z);
            return pointAsString;
        }
    }
}