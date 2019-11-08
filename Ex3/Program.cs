using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Ord();
            return;
            List<Student> listaStud = new List<Student>();
            AddStud(listaStud, "Adina", "Gherman", 8);
            AddStud(listaStud,"Andreea", "Magdici", 6);
            AddStud(listaStud,"Alina", "Leon", 10);
            AddStud(listaStud,"Andrei", "Stamate", 5);
            AddStud(listaStud,"Ion", "Ghica", 9);
            AddStud(listaStud,"Sebastian", "Rosca", 6);
            AddStud(listaStud,"Matei", "Timofte", 10);
            AddStud(listaStud,"Alexandra", "Lucaci", 10);
            AddStud(listaStud,"Ana", "Radu", 8);
            AddStud(listaStud,"Alina", "Gavrilut", 8);

           /* var orderedlist1 = listaStud.OrderBy(st => st.Grade);
            foreach (var item in orderedlist1)
            {
                Console.WriteLine(item.Details());
            }*/

            List<Worker> listaWork = new List<Worker>();
            AddWork(listaWork, "Andra", "Munteanu", 200, 7);
            AddWork(listaWork, "Andreea", "Todirici",100, 3);
            AddWork(listaWork, "Alina", "Stan", 900, 12);
            AddWork(listaWork, "Andrei", "Stamate", 250, 9);
            AddWork(listaWork, "Ionut", "Apostol",300, 10 );
            AddWork(listaWork, "Sebastian", "Rosca", 120, 6);
            AddWork(listaWork, "Matei", "Ion", 320, 10);
            AddWork(listaWork, "Alexandra", "Matei", 320, 10);
            AddWork(listaWork, "Ana", "Radu",220, 8);
            AddWork(listaWork, "Alina", "Gavrilut", 220, 8);

            /*var orderedList2 = listaWork.OrderByDescending(st =>st.MoneyPerHour());

            foreach (var item in orderedList2)
            {
                Console.WriteLine(item.Details());
            }*/


            //var studenti = listaWork.Select(p => new Human() { FirstName = p.FirstName, LastName = p.LastName }).ToList();

            //foreach (var item in studenti)
            //{
            //    Console.WriteLine(item.FirstName, item.LastName);
            //}
        }

        private static void Ord()
        {
            List<Student> listaStud = new List<Student>();
            AddStud(listaStud, "Adina", "Gherman", 8);
            AddStud(listaStud, "Andreea", "Magdici", 6);
            AddStud(listaStud, "Alina", "Leon", 10);
            AddStud(listaStud, "Andrei", "Stamate", 5);
            AddStud(listaStud, "Ion", "Ghica", 9);
            AddStud(listaStud, "Sebastian", "Rosca", 6);
            AddStud(listaStud, "Matei", "Timofte", 10);
            AddStud(listaStud, "Alexandra", "Lucaci", 10);
            AddStud(listaStud, "Ana", "Radu", 8);
            AddStud(listaStud, "Alina", "Gavrilut", 8);

            List<Student> studOrdered = listaStud.OrderBy(st => st.Grade).ToList();

            List<Worker> listaWork = new List<Worker>();
            AddWork(listaWork, "Andra", "Munteanu", 200, 7);
            AddWork(listaWork, "Andreea", "Todirici", 100, 3);
            AddWork(listaWork, "Alina", "Stan", 900, 12);
            AddWork(listaWork, "Andrei", "Stamate", 250, 9);
            AddWork(listaWork, "Ionut", "Apostol", 300, 10);
            AddWork(listaWork, "Sebastian", "Rosca", 120, 6);
            AddWork(listaWork, "Matei", "Ion", 320, 10);
            AddWork(listaWork, "Alexandra", "Matei", 320, 10);
            AddWork(listaWork, "Ana", "Radu", 220, 8);
            AddWork(listaWork, "Alina", "Gavrilut", 220, 8);

            List<Worker> workOrdered = listaWork.OrderByDescending(st => st.MoneyPerHour()).ToList();

            List<Human> mergeList = new List<Human>();
            mergeList.AddRange(studOrdered);
            mergeList.AddRange(workOrdered);
            Console.WriteLine(string.Join(",\r\n", mergeList.Select(ml => ml.Details)));
        }

        private static void AddStud(List<Student> listaStud, string firstname, string lastname, int grade)
        {
            listaStud.Add(new Student(firstname, lastname, grade));
        }
        private static void AddWork(List<Worker> listaWork, string firstName, string lastName, int weekSalary, int workHoursPerDay )
        {
            listaWork.Add(new Worker(firstName, lastName, weekSalary, workHoursPerDay));
        }
    }
}
