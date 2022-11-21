using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPlatz
{
    public enum VehicleType
    {
        CAR, 
        MOTOR,
    }
    public class Vehicle
    {
        public bool parked = false;
        private int vehicleId;
        private VehicleType type;


        
        public Vehicle(int _vehicleId,VehicleType _type)
        {
            this.vehicleId = _vehicleId;    
            this.type = _type;
        }


        public Vehicle Park()
        {
            parked = true;
            return this;
        }
        public Vehicle UnPark()
        {

            parked = false;
            return this;
        }
        public VehicleType GetVehicleType()
        {
            return type;
        }

        public int GetVehicleId()
        {
            return vehicleId;
        }
    }

}
