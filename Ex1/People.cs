
namespace Tema9
{
    class Student : People
    {
        public string ClassNumber { get; set; }
        public string Comments { get; set; }

        internal string Print()
        {
            return $"Student: {Name}-{ClassNumber}";
        }
    }
}
