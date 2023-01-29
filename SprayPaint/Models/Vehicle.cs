using System;
using System.Xml.Serialization;

namespace SprayPaint.Models
{
    public class Vehicle
    {
        [XmlAttribute("BaseVehicleID")]
        public ushort BaseVehicleID { get; set; }

        [XmlAttribute("PaintedVehicleID")]
        public ushort PaintedVehicleID { get; set; }

        [XmlAttribute("PaintID")]
        public ushort PaintID { get; set; }

        public Vehicle(ushort base_vehicle_id, ushort painted_vehicle_id, ushort paint_id)
        {
            if (painted_vehicle_id <= 0) throw new ArgumentOutOfRangeException(nameof(painted_vehicle_id));
            if (base_vehicle_id <= 0) throw new ArgumentOutOfRangeException(nameof(painted_vehicle_id));

            BaseVehicleID = base_vehicle_id;
            PaintedVehicleID = painted_vehicle_id;
            PaintID = paint_id;
        }

        public Vehicle()
        {
        }
    }
}
