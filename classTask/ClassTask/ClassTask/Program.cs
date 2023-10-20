using System.Runtime.ExceptionServices;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("mercedes", "amg", "white", 2000, 4, "sedan");
            Plane plane1 = new Plane("f18","e/c","white", 1980 , 2, false );
            Console.WriteLine(car1.GetMaximumSpeed());
            Console.WriteLine(plane1.GetMaximumSpeed());
            Vehicle[] array = new Vehicle[] {car1,plane1 };

            foreach (var item in array)
            {
                Console.WriteLine(item.ProducedYear);
            }
        }
    }
}