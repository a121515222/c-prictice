using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVehicleSpace
{
    public interface IVehicle
    {
        string ShowMark();
        string Move();

        string Stop();

        string TurnLeft();

        string TurnRight();
    }
    
}
