using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Classes
{
    public class Bycycle : WheeledVehicle
    {
        public int NumberOfSpeedLevels { get; set; }
        bool IsElectric { get; set; }


        public Bycycle(string manufactorer, string model, int numberOfVheels, string type, int numberOfSpeedLevels, bool isElectric)
        {
            Manufacturer = manufactorer;
            Model = model;
            Id = new Random().Next(1, 9999999);
            NumberOfSpeedLevels = numberOfVheels;
            Type = type;
            NumberOfSpeedLevels = numberOfSpeedLevels;
            IsElectric = isElectric;
        }
        public void Ride(bool isElectric)
        {
           
            if (isElectric == true){
                Console.WriteLine($"Manufacturer: {Manufacturer}, Model: {Model},\n with Number of Wheels: {NumberOfWheels} is driven by electrical power");
            }
            if(isElectric == false)
            {
                Console.WriteLine($"Manufacturer: {Manufacturer}, Model: {Model},\n with Number of Wheels: {NumberOfWheels} rides with human force by turning the pedals");
            }
        }
        public override void Repair(string parts)
        {
           Console.WriteLine( $" Vehicle: {Manufacturer}, Model: {Model} with Id: {Id}, Is electric: {IsElectric}, Number od speed levels:{NumberOfSpeedLevels}  \n have to be repaired and there have to me changed this Parts: {parts}");
        }
    }
}
