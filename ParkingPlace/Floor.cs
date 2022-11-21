using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkPlatz
{
    public class Floor
    {

        public int availParkingCars = 0;
        public int availParkingMotors = 0; 
       

        List<Vehicle> parkedCars = new List<Vehicle>();
        List<Vehicle> parkedMotors = new List<Vehicle>();


        public Floor(int _availParkingCars,int _availParkingMotors)
        {
            this.availParkingCars = _availParkingCars;   
            this.availParkingMotors = _availParkingMotors;          
        }

        public int ParkVehicle(Vehicle vehicle)
        {
            if (vehicle.GetVehicleType() == VehicleType.CAR && availParkingCars > 0)
            {
              int slot =  parkedCars.FindIndex(car => car.parked == false);
                
                if(slot < 0)
                {
                    parkedCars.Add(vehicle.Park());
                }    

                else
                {
                    parkedCars[slot] = vehicle.Park();
                }
             
                availParkingCars--;
                return slot;    
                

            }
            if (vehicle.GetVehicleType() == VehicleType.MOTOR && availParkingMotors > 0)
            {
                int slot = parkedMotors.FindIndex(car => car.parked == false);

                if (slot < 0)
                {
                    parkedMotors.Add(vehicle.Park());

                    slot = parkedMotors.Count - 1;
                }

                else
                {
                    parkedMotors[slot] = vehicle.Park();
                }

                availParkingMotors--;
                return slot;


            }

            return -1;
        }

        public bool UnparkVehicle(int slot, VehicleType vehicleType)
        {
            try
            {
                if (vehicleType == VehicleType.CAR)
                {

                    parkedCars[slot] = parkedCars[slot].UnPark();
                    availParkingCars++;
                    return true;
                }
                else
                {

                    parkedMotors[slot] = parkedMotors[slot].UnPark();
                    availParkingMotors++;
                    return true;
                }
            }
            catch (IndexOutOfRangeException )
            {
                return false;

            }
        }
        public int FindVehicle(int vehicleId, VehicleType vehicleType)
        {
            if (vehicleType == VehicleType.CAR)
            {
                int slot = parkedCars.FindIndex(x => x.GetVehicleId().Equals(vehicleId));
                if (slot != -1)
                {
                    return slot;

                }

            }

            if (vehicleType == VehicleType.MOTOR)
            {
                int slot = parkedMotors.FindIndex(x => x.GetVehicleId().Equals(vehicleId));
                if (slot != -1)
                {
                    return slot;

                }
            }
            return -1;
        }
    }
}
