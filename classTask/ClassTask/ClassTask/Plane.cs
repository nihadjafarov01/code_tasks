using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Plane : Vehicle
    {
        public int SeatCount;
        public bool HasBusinessClass;

        public Plane(string brand, string model, string colour, int producedYear, int seatCount, bool hasBusinessClass) : base(brand, model, colour, producedYear)
        {
            SeatCount = seatCount;
            HasBusinessClass = hasBusinessClass;
        }
    }
}
