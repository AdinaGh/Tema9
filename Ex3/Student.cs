namespace Ex3
{
    partial class Program
    {
        public class Student : Human
       {
            public Student(string firstName, string lastName,int grade) : base(firstName, lastName)
            {
                this.Grade = grade;
            }
            public int Grade { get; set; }
            public string Details2()
            { 
                return $"{this.FirstName} {this.LastName} {this.Grade} ";
               
            }

            public override string Details
            {
                get
                {
                    return $"{this.FirstName} {this.LastName} {this.Grade}";
                }
            }
        }
    }
}
