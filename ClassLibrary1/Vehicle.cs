using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vehicle
    {
        //frugal / fields
        private string _make;
        private string _model;
        private int _year;
        private decimal _weight;

        //people / properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        private decimal Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        //collect / constructors
        public Vehicle() { }
        public Vehicle(string make, string model, int year, decimal weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }

        //money / methods
        public override string ToString()
        {
            return string.Format("{0}\n", "{1}\n", "{3}\n", "{4}", Make, Model, Year, Weight);
        }

        
    }
}
