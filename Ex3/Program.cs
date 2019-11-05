using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> listaStud = new List<Student>();
            AddStud(listaStud, "Adina", "Gherman", "8");
            AddStud(listaStud, "Andreea", "Gherman", "8");
            AddStud(listaStud, "Adina", "Gherman", "8");
            AddStud(listaStud, "Adina", "Gherman", "8");
            AddStud(listaStud, "Adina", "Gherman", "8");
            AddStud(listaStud, "Adina", "Gherman", "8");
            AddStud(listaStud, "Adina", "Gherman", "8");
            AddStud(listaStud, "Adina", "Gherman", "8");
            AddStud(listaStud, "Adina", "Gherman", "8");
            AddStud(listaStud, "Adina", "Gherman", "8");

            var orderedlist = listaStud.OrderBy(st => st.Grade);


        }

        private static void AddStud(List<Student> listaStud)
        {
            listaStud.Add(new Student(8));
        }

        public abstract class Human
        {
            protected Human(string firstname, string lastname)
            {
                this.FirstName = firstname;
                this.LastName = lastname;
            }
            protected string FirstName { get; set; }
            protected string LastName { get; set; }
        }
       public class Student : Human
       {
            public Student(string firstname, string lastname,int grade) : base(firstname, lastname)
            {
                this.Grade = grade;
            }
          public int Grade { get; set; } 
       }
      public class Worker : Human
       {
            public Worker(string firstname, string lastname, int weekSalary, int workHoursPerDay) : base(firstname, lastname)
            {
                this.WeekSalary = weekSalary;
                this.WorkHoursPerDay = workHoursPerDay;
            }
            public int WeekSalary { get; set; }
            public int WorkHoursPerDay { get; set; }

            public int MoneyPerHour()
           {
             return WeekSalary / (WorkHoursPerDay * 5);
           }

       } 
}
}
