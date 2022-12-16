using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSpace
{
    public class Car
    {
        // 以下是是Field
        // 有下底線開頭的變數名為全域變數
        private string _mark;
        private string _type;
        private string _horsepower;

        // 以下是constructor，constructor是method，是創建實體的時後先執行的method

        public Car(string mark, string type, string horsepower, string year)
        {
            // constructor可以把初始參數帶入全域變數
            _mark = mark;
            _type = type;
            _horsepower = horsepower;
            // 也可把property賦值
            Year= year;
        }
        //  以下是method
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
        // property
       
        public string HorsePower
        {
            get { return _horsepower; }
            set { _horsepower = value; }
        }
        
        // 如果property內的get與set沒有其他邏輯則可以在更簡化
        public string Year { get; set; }

        // 也可以只用get,但是需要constructor或是其他函式把資料寫熱

        public string GetCarType { get { return _type; } }
    }
}
