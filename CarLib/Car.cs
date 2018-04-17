using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLib
{
    public class Car
    {
        private string _make;
        private string _model;
        private int _mileage;
        private int _year;
        private decimal _price;
        private string _engineSize; //like 2.4L V4, 3.8L V8        
        private int _averageMpg;
        private int _customerID;
        /*-----Constructor-----*/
        public Car(string make, string model, int year, decimal price, string engineSize, int averageMpg)
        {
            _make = make;
            _model = model;
            _year = year;
            _price = price;
            _engineSize = engineSize;
            _averageMpg = averageMpg;
        }
        /*-----Properties-----*/
        public string Make { get { return _make; } }
        public string Model { get { return _model; } }
        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }
        public int Year { get { return _year; } }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string EngineSize { get { return _engineSize; } }
        public int AverageMpg { get { return _averageMpg; } }
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        /*-----Methods-----*/
        public void LowerPriceBy(decimal percent)
        {
            _price -= percent * Price / 100;
        }
        public void ChangePrice(decimal newPrice)
        {
            _price = newPrice;
        }
    }
}
