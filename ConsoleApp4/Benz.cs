using CarSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenzSpace
{
    // Benz 繼承自Car可以使用Car的方法，以及property，fild
    class Benz : Car
    {
        // subCalss的contructor呼叫Car的contructor
        public Benz(string type, string horsepower, string year ,double currentValue) : base("Benz", type, horsepower, year, currentValue)
        {
        }
        public string OnlyBenzCanDo()
        {
            return "Only Benz can do.";
        }
        // override parentclass的方法
        public override string LockCar()
        {
            return $"Benz can lock better.";
        }
    }
}
