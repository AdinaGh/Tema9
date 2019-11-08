namespace Ex2
{
    abstract class Animal : ISound
    {
        public Animal()
        {
            Age = 0;
        }
        public int Age { get; set; }
        public string Name { get; set; }
        public Sex Sex { get; set; }

        abstract public string ProduceSound();
    }
}