using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class SportCar : Car
    {
        private double _zeroToSixty;
        /*----Contructor-----*/
        public SportCar(string make, string model, int year, decimal price,
            string engineSize, int averageMpg, double zeroToSixty) : base(make, model, year, price, engineSize, averageMpg)
        {
            _zeroToSixty = zeroToSixty;
        }
        /*----Properties-----*/
        public double ZeroToSixty { get { return _zeroToSixty; } }
    }
}
