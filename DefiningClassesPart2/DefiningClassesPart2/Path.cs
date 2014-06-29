namespace DefiningClassesPart2
{
    using System;

    public class Path
    {
        private Point3D point = new Point3D();

        public Path(double x, double y, double z)
        {
            this.point.X = x;
            this.point.Y = y;
            this.point.Z = z;
        }

        public double X
        {
            get { return this.point.X; }
            set { this.point.X = value; }
        }

        public double Y
        {
            get { return this.point.Y; }
            set { this.point.Y = value; }
        }

        public double Z
        {
            get { return this.point.Z; }
            set { this.point.Z = value; }
        }

        public override string ToString()
        {
            return this.X + "," + this.Y + "," + this.Z;
        }
    }
}