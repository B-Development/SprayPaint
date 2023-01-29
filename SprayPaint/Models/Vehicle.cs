using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SprayPaint.Models
{
    public class Vehicle
    {
        [XmlAttribute("PaintedVehicleID")]
        public ushort PaintedVehicleID { get; set; }

        [XmlAttribute("PaintID")]
        public ushort PaintID { get; set; }

        public Vehicle(ushort painted_vehicle_id, ushort paint_id)
        {
            if (painted_vehicle_id <= 0) throw new ArgumentOutOfRangeException(nameof(painted_vehicle_id));
            
            PaintedVehicleID = painted_vehicle_id;
            PaintID = paint_id;
        }

        public Vehicle()
        {
        }
    }

    public class Vehicles
    {
        [XmlAttribute("BaseVehicleID")]
        public ushort BaseVehicleID { get; set; }
        
        [XmlArrayItem("PaintedVehicle")]
        public List<Vehicle> PaintedVehicles { get; set; }

        public Vehicles(ushort base_vehicle_id, List<Vehicle> painted_vehicles)
        {
            BaseVehicleID = base_vehicle_id;
            PaintedVehicles = painted_vehicles;
        }

        public Vehicles()
        {
        }
    }
}
