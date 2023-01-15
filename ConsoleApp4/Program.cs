using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSpace;
using BenzSpace;
using IVehicleSpace;
using CarFleetSpace;
namespace ConsoleApp4
{
    internal class Program
    {
        static void Main()
        {
            Car myCar = new Car("newEle", "sando", "500", "2016", 500);
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

            Console.WriteLine("changing type");
            myCar.SetType("Truck");
            Console.WriteLine(myCar.CarType);

            //使用Benz的class有兩種寫法
            // 1.
            Car myBenz = new Benz("sando", "800", "2023",300);
            Console.WriteLine(myBenz.ShowMark());
            // 強制傳換型別，因為Car這個型別不能直接使用Benz內的方法
            Console.WriteLine(((Benz)myBenz).OnlyBenzCanDo());
            // 2.
            Benz myBenz2 = new Benz("sando", "900", "2005",850);
            Console.WriteLine(myBenz2.OnlyBenzCanDo());
            // interface也可以當作一種類型
            IVehicle myCar1 = new Benz("sando", "1000", "2023",980);
            // 強制傳換型別，因為IVehicle這個型別不能直接使用Benz內的方法
            Console.WriteLine(myCar1.TurnLeft());
            Console.WriteLine(((Benz)myCar1).OnlyBenzCanDo());

            CarFleet myCarFleet = new CarFleet();
            myCarFleet.AddCar(myCar);
            myCarFleet.ShowCars();


        }
        
    }
}
