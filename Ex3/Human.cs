namespace Ex3
{
    partial class Program
    {
        public abstract class Human
        {
            public Human(string firstName, string lastName)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
            }
            protected string FirstName { get; set; }
            protected string LastName { get; set; }
            public virtual string Details
            {
                get
                {
                    return $"{FirstName} {LastName}";
                }
            }

        }
    }
}
