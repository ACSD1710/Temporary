using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Classes
{
   public class WheeledVehicle : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public string Type { get; set; }

        
        public virtual void Repair( string parts)
        {
            
          Console.WriteLine( $" Vehicle: {Manufacturer}, Model: {Model} with Id: {Id} \n have to be repaired and there have to me changed this Parts: {parts}");
        }

    }
}
