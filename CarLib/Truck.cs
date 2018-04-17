using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class Truck : Car
    {
        private int _maxTowing;
        /*-----Constructor-----*/
        public Truck(string make, string model, int year, decimal price,
            string engineSize, int averageMpg, int maxTowing) : base(make, model, year, price, engineSize, averageMpg)
        {
            _maxTowing = maxTowing;
        }
        /*-----Properties-----*/
        public int MaxTowing { get { return _maxTowing; } }
    }
}
