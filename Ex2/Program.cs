using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        private static void Test()
        {
            var animals = new List<Animal>()
            {
                new Dog()
                {
                    Age=3,
                     Name="dog.1"
                },
                new Cat()
                {
                    Age=1,
                    Name="cat.1"
                },
                new Frog()
                {
                    Age=2,
                     Name="forg.1"
                },
                new Kitten()
                {
                    Age=2,
                     Name="kitt.1"
                },
                new TomCat()
                {
                    Age=7,
                     Name="tomc.1"
                }
            };
            var avAgeList = AverageAgePerAnimal(animals);
            Console.WriteLine($"Average is: {avAgeList}");
        }

        private static (double perCat, double perDog, double perFrog) AverageAgePerAnimal(List<Animal> animals)
        {
            var averageCat = animals.Where(an => an is Cat || an is Kitten || an is TomCat).Average(an => an.Age);
            var averageDog = animals.Where(an => an is Dog).Average(an => an.Age);
            var averageFrog = animals.Where(an => an is Frog).Average(an => an.Age);

            return (averageCat, averageDog, averageFrog);
        }
    }

    interface ISound
    {
        string ProduceSound();
    }
    enum Sex
    {
        Female,
        Male
    }
}