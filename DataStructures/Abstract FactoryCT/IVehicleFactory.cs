using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_FactoryCT
{
    /// <summary>
    /// The 'AbstractFactory' interface. 
    /// </summary>
    interface IVehicleFactory
    {
        IBike GetBike(string Bike);
        IScooter GetScooter(string Scooter);
    }
}
