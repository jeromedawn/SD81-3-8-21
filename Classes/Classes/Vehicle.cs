using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    public enum VehicleType { Car, Truck, Van, Motorcycles, Spaceships, Planes, Boats}
     
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public double Mileage { get; set; }

        public VehicleType TypeOfVehichle { get; set; }

        public Vehicle()
        {

        }
        public Vehicle(string make, string model, double mileage, VehicleType typeOfVehicle)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehichle = typeOfVehicle;
        }
        public bool IsRunning { get; private set; }


        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turn the vehicle on");
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turn the vehicle off");
        }
    }

    public class Indicator
    {
        public bool IsFlashing { get; private set; }

        public void FlashOn()
        {
            IsFlashing = true;
            Console.WriteLine("You turn the flash on");
        }

        public void FlashOff()
        {
            IsFlashing = false;
            Console.WriteLine("You turn the flash off");
        }
        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }

        public void IndicateRight()
        {
            RightIndicator.FlashOn();
            LeftIndicator.FlashOff();
        }

        public void IndicateLeft()
        {
            RightIndicator.FlashOff();
            LeftIndicator.FlashOn();
        }

        public void HazardsOn()
        {
            RightIndicator.FlashOn();
            LeftIndicator.FlashOn();
        }

        public void HazardsOff()
        {
            RightIndicator.FlashOff();
            LeftIndicator.FlashOff();
        }

       

    }


}
