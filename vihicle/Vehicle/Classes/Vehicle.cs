using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Classes
{
    public class Vehicle
    {
        protected int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {
            Id = new Random().Next(1,9999999);
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Vechicle manufacturer: {Manufacturer}, Model: {Model}, Id: {Id}");
        }
        public int GetId()
        {
            return Id;
        }
    }
}
