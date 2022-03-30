using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Enums;

namespace Vehicle.Classes
{
    public class ElectricCar : Car
    {
        public double BateryCapacity { get; set; }
        public double BateryPercentage { get; set; }
        public double MaxSpeedOnBatery { get; set; }


        public ElectricCar(string manufactorer, string model, int numberOfVheels, string type, EngineType engineType, double fuelConsumption, int doorNumbers, double maxSpeed, double bateryCapacity, double Percentage, double maxSpeedOnBattery) : base(manufactorer,
                                                                                                                                                                                                                                 model,
                                                                                                                                                                                                                                 numberOfVheels,
                                                                                                                                                                                                                                 type,
                                                                                                                                                                                                                                 engineType,
                                                                                                                                                                                                                                 fuelConsumption,
                                                                                                                                                                                                                                 doorNumbers,
                                                                                                                                                                                                                                 maxSpeed)
        {
            BateryCapacity = bateryCapacity;
            BateryPercentage = Percentage;
            MaxSpeedOnBatery = maxSpeedOnBattery;

        }



        public bool Recharge(double bateryCapacity)
        {
            if(bateryCapacity < 10)
                return true;

                    return false;
            
        }
        public override void Drive()
        {
            Console.WriteLine($"Max.Speed is : {MaxSpeed}.");
        }


    }
}
