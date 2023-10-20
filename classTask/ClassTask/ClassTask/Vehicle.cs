using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Vehicle
    {
        public string Brand;
        public string Model;
        public string Colour;
        public int ProducedYear;

        public string GetMaximumSpeed()
        {
            return ($"{Brand} {Model} can run max at speed 220");
        }

        public Vehicle(string brand, string model, string colour, int producedYear)
        {
            Brand = brand;
            Model = model;
            Colour = colour;
            ProducedYear = producedYear;
        }
    }
}
