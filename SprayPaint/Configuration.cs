using System.Collections.Generic;
using Rocket.API;
using SprayPaint.Models;

namespace SprayPaint
{
    public class Configuration : IRocketPluginConfiguration
    {
        public List<Vehicle> Vehicles { get; set; }

        /// 62500 - Black
        /// 62501 - Blue
        /// 62502 - Green
        /// 62503 - Orange
        /// 62504 - Purple
        /// 62505 - Red
        /// 62506 - White
        /// 62507 - Yellow
        public void LoadDefaults()
        {
            Vehicles = new List<Vehicle>
            {
                // Black
                new Vehicle(62500, 62501, 62501),
                new Vehicle(62500, 62502, 62502),
                new Vehicle(62500, 62503, 62503),
                new Vehicle(62500, 62504, 62504),
                new Vehicle(62500, 62505, 62505),
                new Vehicle(62500, 62506, 62506),
                new Vehicle(62500, 62507, 62507),

                // Blue
                new Vehicle(62501, 62500, 62500),
                new Vehicle(62501, 62502, 62502),
                new Vehicle(62501, 62503, 62503),
                new Vehicle(62501, 62504, 62504),
                new Vehicle(62501, 62505, 62505),
                new Vehicle(62501, 62506, 62506),
                new Vehicle(62501, 62507, 62507),

                // Green
                new Vehicle(62502, 62500, 62500),
                new Vehicle(62502, 62501, 62501),
                new Vehicle(62502, 62503, 62503),
                new Vehicle(62502, 62504, 62504),
                new Vehicle(62502, 62505, 62505),
                new Vehicle(62502, 62506, 62506),
                new Vehicle(62502, 62507, 62507),

                // Orange
                new Vehicle(62503, 62500, 62500),
                new Vehicle(62503, 62501, 62501),
                new Vehicle(62503, 62502, 62502),
                new Vehicle(62503, 62504, 62504),
                new Vehicle(62503, 62505, 62505),
                new Vehicle(62503, 62506, 62506),
                new Vehicle(62503, 62507, 62507),

                // Purple
                new Vehicle(62504, 62500, 62500),
                new Vehicle(62504, 62501, 62501),
                new Vehicle(62504, 62502, 62502),
                new Vehicle(62504, 62503, 62503),
                new Vehicle(62504, 62505, 62505),
                new Vehicle(62504, 62506, 62506),
                new Vehicle(62504, 62507, 62507),

                // Red
                new Vehicle(62505, 62500, 62500),
                new Vehicle(62505, 62501, 62501),
                new Vehicle(62505, 62502, 62502),
                new Vehicle(62505, 62503, 62503),
                new Vehicle(62505, 62504, 62504),
                new Vehicle(62505, 62506, 62506),
                new Vehicle(62505, 62507, 62507),

                // White
                new Vehicle(62506, 62500, 62500),
                new Vehicle(62506, 62501, 62501),
                new Vehicle(62506, 62502, 62502),
                new Vehicle(62506, 62503, 62503),
                new Vehicle(62506, 62504, 62504),
                new Vehicle(62506, 62505, 62505),
                new Vehicle(62506, 62507, 62507),

                // Yellow
                new Vehicle(62507, 62500, 62500),
                new Vehicle(62507, 62501, 62501),
                new Vehicle(62507, 62502, 62502),
                new Vehicle(62507, 62503, 62503),
                new Vehicle(62507, 62504, 62504),
                new Vehicle(62507, 62505, 62505),
                new Vehicle(62507, 62506, 62506),
            };
        }
    }
}
