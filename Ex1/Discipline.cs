

namespace Ex1
{
    class Discipline
    {
        public int NoOfLectures { get; set; }
        public int NoOfExercises { get; set; }
        public string Comments { get; set; }
        public string Name { get; internal set; }

        internal object Print()
        {
            return $"Discipline: {Name}-{NoOfExercises}-{NoOfLectures}";
        }
    }
}