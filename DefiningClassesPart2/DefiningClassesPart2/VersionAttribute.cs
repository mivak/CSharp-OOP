namespace DefiningClassesPart2
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum |
        AttributeTargets.Method, AllowMultiple = false)]
    public class VersionAttribute : System.Attribute
    {
        private int major;
        private int minor;

        public VersionAttribute(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }

        public int Major
        {
            get
            {
                return this.major;
            }

            set
            {
                if (value >= 0)
                {
                    this.major = value;
                }

                throw new ArgumentException("The value should be positive");
            }
        }

        public int Minor
        {
            get
            {
                return this.minor;
            }
            
            set
            {
                if (value >= 0)
                {
                    this.minor = value;
                }
            }
        }
    }
}