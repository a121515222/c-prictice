using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IVehicleSpace;

namespace CarSpace
{
    public class Car: IVehicle
    {
        // 以下是是Field
        // 有下底線開頭的變數名為全域變數
        private string _mark;
        private string _type;
        private string _horsepower;
        private string _year;
        // 以下是constructor，constructor是method，是創建實體的時後先執行的method

        public Car(string mark, string type, string horsepower, string year, double currentValue)
        {
            // constructor可以把初始參數帶入全域變數
            _mark = mark;
            _type = type;
            _horsepower = horsepower;
            // 也可把property賦值
            _year = year;
            CurrentValue = currentValue;
        }
        //  以下是method
        public string ShowMark()
        {
            return _mark;
        }
        public string Move()
        {
            return "Car move";
        }
        public string Stop()
        {
            return "Car Stop";
        }
        public string TurnLeft()
        {
            return "Car left";
        }
        public string TurnRight()
        {
            return "Car Right";
        }
        // GetHorsepower與SetHorsepower可以使用property取代
        public string GetHorsepower()
        {
            return _horsepower;
        }
        public void SetHorsepower(string info)
        {
            _horsepower = info;
        }
        // 可以被subclass override的方法
        public virtual string LockCar()
        {
            return $"{this._mark} is Lock.";
        }

        public void SetType(string type)
        {
            _type = type;
        }
        // property

        public string HorsePower
        {
            get { return _horsepower; }
            set { this._horsepower = value; }
        }
        public string Year
        {
            get { return _year; }
            set { this._year = value; }
        }

        // 如果property內的get與set沒有其他邏輯則可以在更簡化

        public double CurrentValue { get; set; }

        // 也可以只用get,但是需要constructor或是其他函式把資料寫入

        public string CarType { get { return _type; } }
        public string CarMark { get { return _mark; } }
    }
}
