using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSpace;
namespace CarFleetSpace
{
    public class CarFleet
    {
        private Car[] _cars;
        private int _carCount;

        public CarFleet() {
            _cars = new Car[100];
            _carCount = 0;
        }
        public void AddCar(Car car) {
            _cars[_carCount] = car;
            _carCount++;
        }
        public void ShowCars() {
            for (var i = 0; i < _carCount; i++)
            {
                Console.WriteLine($"mark:{_cars[i].CarMark}");
                Console.WriteLine($"type:{_cars[i].CarType}");
                Console.WriteLine($"horsepower:{_cars[i].HorsePower}");
                Console.WriteLine($"currentValue:{_cars[i].CurrentValue}");
            }
        }
    }


}
