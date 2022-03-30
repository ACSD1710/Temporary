using System;
using System.Collections.Generic;
using System.Text;
using Vehicle.Enums;

namespace Vehicle.Classes
{
    public class Car : WheeledVehicle
    {
        private string manufactorer;
        private int numberOfVheels;
        private EngineType engineType;

        public EngineType EngineType1 { get; set; }
        public double FuelConsumption { get; set; }
        public int DoorNumbers { get; set; }
        public double MaxSpeed { get; set; }

        public Car()
        {
            Id = new Random().Next(1, 9999999);
        }
        public Car(string manufactorer, string model, string v, int numberOfVheels, string type, EngineType engineType, double fuelConsumption, int doorNumbers, double maxSpeed)
        {
            Manufacturer = manufactorer;
            Model = model;
            NumberOfWheels = numberOfVheels;
            Type = type;
            EngineType1 = engineType;
            FuelConsumption = fuelConsumption;
            DoorNumbers = doorNumbers;
            MaxSpeed = maxSpeed;
            Id = new Random().Next(1, 9999999);

        }

        public Car(string manufactorer, string model, int numberOfVheels, string type, EngineType engineType, double fuelConsumption, int doorNumbers, double maxSpeed)
        {
            this.manufactorer = manufactorer;
            Model = model;
            this.numberOfVheels = numberOfVheels;
            Type = type;
            this.engineType = engineType;
            FuelConsumption = fuelConsumption;
            DoorNumbers = doorNumbers;
            MaxSpeed = maxSpeed;
        }

        public virtual void Drive()
        {
            Console.WriteLine($"Manufactorer: {Manufacturer}, Model: {Model} is driving with Max.Speed: {MaxSpeed}.");
        }
        public override void Repair(string parts)
        {
            Console.WriteLine(value: $" Vehicle: {Manufacturer}, Model: {Model} with Id: {Id}, Is electric: {EngineType1},   \n have to be repaired and there have to me changed this Parts: {parts}");
        }
    }
}
