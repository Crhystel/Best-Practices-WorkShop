using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.ModelBuilders
{
    public class CarBuilder
    {
        public string _brand = "Ford";
        public string _model = "Mustang";
        public string _color = "Red";
        //Adding year property, using datetime to get current year as default.
        private int _year = DateTime.Now.Year;

        public CarBuilder SetBrand(string brand)
        {
            _brand = brand;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            _model = model;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            _color = color;
            return this;
        }
        public CarBuilder SetYear(int year)
        {
            _year = year;
            return this;
        }
        //if 20 new properties are added, we only need to change this Builder
        public Car Build()
        {
            return new Car(_color, _brand,_model,_year);
        }
    }
}
