using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSpace;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            Car myCar = new Car("newEle", "sando", "500", "2016");
            Console.WriteLine(myCar.Move());
            // 原本設置Horsepower
            myCar.SetHorsepower("500");
            Console.WriteLine(myCar.GetHorsepower());
            // 改用property
            myCar.HorsePower = "600";
            Console.WriteLine(myCar.HorsePower);
            myCar.Year = "2010";
            Console.WriteLine(myCar.Year);
            Console.WriteLine(myCar);
        }
    }
}
