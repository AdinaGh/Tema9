namespace Ex3
{
    partial class Program
    {
        public class Worker : Human
       {
            public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay ) : base(firstName, lastName)
            {
                this.WeekSalary = weekSalary;
                this.WorkHoursPerDay = workHoursPerDay;
            }
            public int WeekSalary { get; set; }
            public int WorkHoursPerDay { get; set; }

            public double MoneyPerHour()
           {
             return WeekSalary / (WorkHoursPerDay * 5.0);
           }

            public string Details2()
            {
                return $"Name: {this.FirstName} {this.LastName} Salary: {this.WeekSalary} WorkPerDay: {this.WorkHoursPerDay} MoneyPerHour: {this.MoneyPerHour()}";

            }

            public override string Details
            {
                get
                {
                    return $"{this.FirstName} {this.LastName} Salary: {this.WeekSalary} WorkPerDay: {this.WorkHoursPerDay} MoneyPerHour: {this.MoneyPerHour()}";
                }
            }
        } 
    }
}
