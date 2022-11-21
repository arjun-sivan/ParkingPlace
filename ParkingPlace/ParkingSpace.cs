using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPlatz
{
    public class ParkingSpace
    {
        string vehicleNumber = string.Empty;
        int floorNo = 0;

        public ParkingSpace( string vehicleNumber)
        {
            this.vehicleNumber = vehicleNumber;
        }
    }
  
}
