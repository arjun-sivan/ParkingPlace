using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParkPlatz
{
    public sealed class ParkingPlot
    {

        private static readonly ParkingPlot instance = new ParkingPlot(new List<Floor>());

        int totalAvailableCarParking = 0;
        int totalAvailableMotorParking = 0;
        public List<Floor> floors;
        static ParkingPlot()
            {
            }
            private ParkingPlot(List<Floor> floors)
            {
                foreach (var floor in floors)
                {
                    this.totalAvailableCarParking += floor.availParkingCars;
                    this.totalAvailableMotorParking += floor.availParkingMotors;
                }
                this.floors = floors;
            }
            public static ParkingPlot Instance
            {
                get
                {
                    return instance;
                }
            }

      
        public Tuple<int, int> ParkVehicle(Vehicle vehicle)
        {


            if (vehicle.GetVehicleType() == VehicleType.CAR)
            {
                if (totalAvailableCarParking > 0)
                {
                    int floorNumber = -1;
                    foreach (var floor in floors)
                    {

                        floorNumber = floors.FindIndex(x => x.availParkingCars > 0);
                        if (floorNumber != -1)
                            break;
                    }

                    int slotNumber = floors[floorNumber].ParkVehicle(vehicle);
                    return Tuple.Create(floorNumber, slotNumber);

                }

            }

            if (vehicle.GetVehicleType() == VehicleType.MOTOR)
            {
                if (totalAvailableMotorParking > 0)
                {
                    int floorNumber = -1;
                    foreach (var floor in floors)
                    {

                        floorNumber = floors.FindIndex(x => x.availParkingMotors > 0);
                        if (floorNumber != -1)
                            break;
                    }

                    int slotNumber = floors[floorNumber].ParkVehicle(vehicle);
                    return Tuple.Create(floorNumber, slotNumber);

                }

            }
            return Tuple.Create(-1, -1);

        }

        public bool UnparkVehicle(int vehicleId,VehicleType vehicleType)
        {
            try
            {
                Tuple<int, int> parkingSpot = this.FindVehicle(vehicleId, vehicleType);
                int floorNumber = parkingSpot.Item1;
                int slotNumber = parkingSpot.Item2;

                return floors[floorNumber].UnparkVehicle(slotNumber, vehicleType);

            }
            catch { return false; }
           

        }

        public Tuple<int, int> FindVehicle(int vehicleId, VehicleType type)
        {
            int parkingNumber;
        
                foreach (var floor in floors.Select((value, i) => new { i, value }))
                {
                    parkingNumber = floor.value.FindVehicle(vehicleId, type);
                    if (parkingNumber != -1)
                    {
                        return Tuple.Create(floor.i, parkingNumber);
                    }
                    
                }          
            return Tuple.Create(-1, -1);

        }

        public bool AddFloor(Floor floor)
        {
            try
            {
                this.totalAvailableCarParking += floor.availParkingCars;
                this.totalAvailableMotorParking += floor.availParkingMotors;
                floors.Insert(0, floor);
                return true;
            }
            catch
            {
                return false;
            }

                     
            
        }

        public bool DeleteFloor(int floorNumber)
        {
            try
            {
                this.totalAvailableCarParking -= floors[floorNumber].availParkingCars;
                this.totalAvailableMotorParking -= floors[floorNumber].availParkingMotors;
                floors.RemoveAt(floorNumber);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

    }
}
    



