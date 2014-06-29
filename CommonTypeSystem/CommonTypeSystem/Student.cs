namespace CommonTypeSystem
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string eMail;
        private int course;
        private Specialty specialty;
        private Faculty faculty;
        private University university;

        public Student(string firstName, string middleName, string lastName, int sSN, string permanentAddress, string mobilePhone, string eMail, int course, Specialty specialty, Faculty faculty, University university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = sSN;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.EMail = eMail;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;
            this.University = university;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }

            private set
            {
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                this.lastName = value;
            }
        }

        public int Ssn
        {
            get
            {
                return this.ssn;
            }

            private set
            {
                this.ssn = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }

            private set
            {
                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }

            private set
            {
                this.mobilePhone = value;
            }
        }

        public string EMail
        {
            get
            {
                return this.eMail;
            }

            private set
            {
                this.eMail = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }

            private set
            {
                this.course = value;
            }
        }

        public Specialty Specialty
        {
            get
            {
                return this.specialty;
            }

            private set
            {
                this.specialty = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }

            private set
            {
                this.faculty = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }

            private set
            {
                this.university = value;
            }
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.FirstName);
            sb.AppendLine(this.MiddleName);
            sb.AppendLine(this.LastName);
            sb.AppendLine(this.Ssn.ToString());
            sb.AppendLine(this.PermanentAddress);
            sb.AppendLine(this.MobilePhone);
            sb.AppendLine(this.EMail);
            sb.AppendLine(this.Specialty.ToString());
            sb.AppendLine(this.Faculty.ToString());
            sb.AppendLine(this.University.ToString());
            return sb.ToString();
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (student == null)
            {
                return false;
            }

            if (!object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (!object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }

            if (!object.Equals(this.LastName, student.LastName))
            {
                return false;
            }

            if (this.Ssn != student.Ssn)
            {
                return false;
            }

            if (!object.Equals(this.PermanentAddress, student.PermanentAddress))
            {
                return false;
            }

            if (!object.Equals(this.MobilePhone, student.MobilePhone))
            {
                return false;
            }

            if (!object.Equals(this.EMail, student.EMail))
            {
                return false;
            }

            if (this.Course != student.Course)
            {
                return false;
            }

            if (!object.Equals(this.Specialty, student.Specialty))
            {
                return false;
            }

            if (!object.Equals(this.Faculty, student.Faculty))
            {
                return false;
            }

            if (!object.Equals(this.University, student.University))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.Ssn.GetHashCode();
        }

        public Student Clone()
        {
            Student clonedStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.PermanentAddress, this.MobilePhone, this.EMail, this.Course, this.Specialty, this.Faculty, this.University);
            
            return clonedStudent;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student student)
        {
            if (!object.Equals(this.LastName, student.LastName))
            {
                return string.Compare(this.LastName, student.LastName);
            }

            if (!object.Equals(this.FirstName, student.FirstName))
            {
                return string.Compare(this.FirstName, student.FirstName);
            }
            else
            {
                return Math.Min(this.Ssn, student.Ssn);
            }
        }
    }
}