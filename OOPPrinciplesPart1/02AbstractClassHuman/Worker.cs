namespace AbstractClassHuman
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
      
        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
        
            set
            {
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.WorkHoursPerDay;
            }
            
            set
            {
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = (this.weekSalary / 5) / this.workHoursPerDay;
            return decimal.Round(moneyPerHour, 2);
        }
    }
}