namespace DefiningClassesPart2
{
    using System;
    [Version(2,11)]
    public class VersionDemo
    {
        public static void Demo()
        {
            Type type = typeof(VersionDemo);

            object[] allAttributes = type.GetCustomAttributes(false);
            
            foreach (VersionAttribute attr in allAttributes)
            {
                Console.WriteLine("{0}.{1}", attr.Major, attr.Minor);
            }
        }
    }
}