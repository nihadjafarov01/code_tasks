using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Car : Vehicle
    {
        public byte DoorCount;
        public string Type;

        public Car(string brand, string model, string colour, int producedYear, byte doorCount, string type) : base (brand, model, colour, producedYear)
        {
            DoorCount = doorCount;
            Type = type;
        }
    }
}
