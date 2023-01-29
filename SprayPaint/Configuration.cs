using System.Collections.Generic;
using Rocket.API;
using SprayPaint.Models;

namespace SprayPaint
{
    public class Configuration : IRocketPluginConfiguration
    {
        public List<Vehicles> Vehicles { get; set; }

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
            Vehicles = new List<Vehicles>
            {
                new Vehicles(62500,
                    new List<Vehicle>()
                    {
                        new Vehicle(62501, 62501),
                        new Vehicle(62502, 62502),
                        new Vehicle(62503, 62503),
                        new Vehicle(62504, 62504),
                        new Vehicle(62505, 62505),
                        new Vehicle(62506, 62506),
                        new Vehicle(62507, 62507)
                    }
                ),
                new Vehicles(62501,
                    new List<Vehicle>()
                    {
                        new Vehicle(62500, 62500),
                        new Vehicle(62502, 62502),
                        new Vehicle(62503, 62503),
                        new Vehicle(62504, 62504),
                        new Vehicle(62505, 62505),
                        new Vehicle(62506, 62506),
                        new Vehicle(62507, 62507),
                    }
                ),
                new Vehicles(62502,
                    new List<Vehicle>()
                    {
                        new Vehicle(62500, 62500),
                        new Vehicle(62501, 62501),
                        new Vehicle(62503, 62503),
                        new Vehicle(62504, 62504),
                        new Vehicle(62505, 62505),
                        new Vehicle(62506, 62506),
                        new Vehicle(62507, 62507)
                    }
                ),
                new Vehicles(62503,
                    new List<Vehicle>()
                    {
                        new Vehicle(62500, 62500),
                        new Vehicle(62501, 62501),
                        new Vehicle(62502, 62502),
                        new Vehicle(62504, 62504),
                        new Vehicle(62505, 62505),
                        new Vehicle(62506, 62506),
                        new Vehicle(62507, 62507)
                    }
                ),
                new Vehicles(62504,
                    new List<Vehicle>()
                    {
                        new Vehicle(62500, 62500),
                        new Vehicle(62501, 62501),
                        new Vehicle(62502, 62502),
                        new Vehicle(62503, 62503),
                        new Vehicle(62505, 62505),
                        new Vehicle(62506, 62506),
                        new Vehicle(62507, 62507)
                    }
                ),
                new Vehicles(62505,
                    new List<Vehicle>()
                    {
                        new Vehicle(62500, 62500),
                        new Vehicle(62501, 62501),
                        new Vehicle(62502, 62502),
                        new Vehicle(62503, 62503),
                        new Vehicle(62504, 62504),
                        new Vehicle(62506, 62506),
                        new Vehicle(62507, 62507)
                    }
                ),
                new Vehicles(62506,
                    new List<Vehicle>()
                    {
                        new Vehicle(62500, 62500),
                        new Vehicle(62501, 62501),
                        new Vehicle(62502, 62502),
                        new Vehicle(62503, 62503),
                        new Vehicle(62504, 62504),
                        new Vehicle(62505, 62505),
                        new Vehicle(62507, 62507)
                    }
                ),
                new Vehicles(62507,
                    new List<Vehicle>()
                    {
                        new Vehicle(62500, 62500),
                        new Vehicle(62501, 62501),
                        new Vehicle(62502, 62502),
                        new Vehicle(62503, 62503),
                        new Vehicle(62504, 62504),
                        new Vehicle(62505, 62505),
                        new Vehicle(62506, 62506)
                    }
                ),
                new Vehicles(62510,
                    new List<Vehicle>()
                    {
                        new Vehicle(62511, 62501),
                        new Vehicle(62512, 62502),
                        new Vehicle(62513, 62503),
                        new Vehicle(62514, 62504),
                        new Vehicle(62515, 62505),
                        new Vehicle(62516, 62506),
                        new Vehicle(62517, 62507)
                    }
                ),
                new Vehicles(62511,
                    new List<Vehicle>()
                    {
                        new Vehicle(62510, 62500),
                        new Vehicle(62512, 62502),
                        new Vehicle(62513, 62503),
                        new Vehicle(62514, 62504),
                        new Vehicle(62515, 62505),
                        new Vehicle(62516, 62506),
                        new Vehicle(62517, 62507),
                    }
                ),
                new Vehicles(62512,
                    new List<Vehicle>()
                    {
                        new Vehicle(62510, 62500),
                        new Vehicle(62511, 62501),
                        new Vehicle(62513, 62503),
                        new Vehicle(62514, 62504),
                        new Vehicle(62515, 62505),
                        new Vehicle(62516, 62506),
                        new Vehicle(62517, 62507)
                    }
                ),
                new Vehicles(62513,
                    new List<Vehicle>()
                    {
                        new Vehicle(62510, 62500),
                        new Vehicle(62511, 62501),
                        new Vehicle(62512, 62502),
                        new Vehicle(62514, 62504),
                        new Vehicle(62515, 62505),
                        new Vehicle(62516, 62506),
                        new Vehicle(62517, 62507)
                    }
                ),
                new Vehicles(62514,
                    new List<Vehicle>()
                    {
                        new Vehicle(62510, 62500),
                        new Vehicle(62511, 62501),
                        new Vehicle(62512, 62502),
                        new Vehicle(62513, 62503),
                        new Vehicle(62515, 62505),
                        new Vehicle(62516, 62506),
                        new Vehicle(62517, 62507)
                    }
                ),
                new Vehicles(62515,
                    new List<Vehicle>()
                    {
                        new Vehicle(62510, 62500),
                        new Vehicle(62511, 62501),
                        new Vehicle(62512, 62502),
                        new Vehicle(62513, 62503),
                        new Vehicle(62514, 62504),
                        new Vehicle(62516, 62506),
                        new Vehicle(62517, 62507)
                    }
                ),
                new Vehicles(62516,
                    new List<Vehicle>()
                    {
                        new Vehicle(62510, 62500),
                        new Vehicle(62511, 62501),
                        new Vehicle(62512, 62502),
                        new Vehicle(62513, 62503),
                        new Vehicle(62514, 62504),
                        new Vehicle(62515, 62505),
                        new Vehicle(62517, 62507)
                    }
                ),
                new Vehicles(62517,
                    new List<Vehicle>()
                    {
                        new Vehicle(62510, 62500),
                        new Vehicle(62511, 62501),
                        new Vehicle(62512, 62502),
                        new Vehicle(62513, 62503),
                        new Vehicle(62514, 62504),
                        new Vehicle(62515, 62505),
                        new Vehicle(62516, 62506)
                    }
                ),
                new Vehicles(62520,
                    new List<Vehicle>()
                    {
                        new Vehicle(62521, 62501),
                        new Vehicle(62522, 62502),
                        new Vehicle(62523, 62503),
                        new Vehicle(62524, 62504),
                        new Vehicle(62525, 62505),
                        new Vehicle(62526, 62506),
                        new Vehicle(62527, 62507)
                    }
                ),
                new Vehicles(62521,
                    new List<Vehicle>()
                    {
                        new Vehicle(62520, 62500),
                        new Vehicle(62522, 62502),
                        new Vehicle(62523, 62503),
                        new Vehicle(62524, 62504),
                        new Vehicle(62525, 62505),
                        new Vehicle(62526, 62506),
                        new Vehicle(62527, 62507),
                    }
                ),
                new Vehicles(62522,
                    new List<Vehicle>()
                    {
                        new Vehicle(62520, 62500),
                        new Vehicle(62521, 62501),
                        new Vehicle(62523, 62503),
                        new Vehicle(62524, 62504),
                        new Vehicle(62525, 62505),
                        new Vehicle(62526, 62506),
                        new Vehicle(62527, 62507)
                    }
                ),
                new Vehicles(62523,
                    new List<Vehicle>()
                    {
                        new Vehicle(62520, 62500),
                        new Vehicle(62521, 62501),
                        new Vehicle(62522, 62502),
                        new Vehicle(62524, 62504),
                        new Vehicle(62525, 62505),
                        new Vehicle(62526, 62506),
                        new Vehicle(62527, 62507)
                    }
                ),
                new Vehicles(62524,
                    new List<Vehicle>()
                    {
                        new Vehicle(62520, 62500),
                        new Vehicle(62521, 62501),
                        new Vehicle(62522, 62502),
                        new Vehicle(62523, 62503),
                        new Vehicle(62525, 62505),
                        new Vehicle(62526, 62506),
                        new Vehicle(62527, 62507)
                    }
                ),
                new Vehicles(62525,
                    new List<Vehicle>()
                    {
                        new Vehicle(62520, 62500),
                        new Vehicle(62521, 62501),
                        new Vehicle(62522, 62502),
                        new Vehicle(62523, 62503),
                        new Vehicle(62524, 62504),
                        new Vehicle(62526, 62506),
                        new Vehicle(62527, 62507)
                    }
                ),
                new Vehicles(62526,
                    new List<Vehicle>()
                    {
                        new Vehicle(62520, 62500),
                        new Vehicle(62521, 62501),
                        new Vehicle(62522, 62502),
                        new Vehicle(62523, 62503),
                        new Vehicle(62524, 62504),
                        new Vehicle(62525, 62505),
                        new Vehicle(62527, 62507)
                    }
                ),
                new Vehicles(62527,
                    new List<Vehicle>()
                    {
                        new Vehicle(62520, 62500),
                        new Vehicle(62521, 62501),
                        new Vehicle(62522, 62502),
                        new Vehicle(62523, 62503),
                        new Vehicle(62524, 62504),
                        new Vehicle(62525, 62505),
                        new Vehicle(62526, 62506)
                    }
                ),
                new Vehicles(62570,
                    new List<Vehicle>()
                    {
                        new Vehicle(62571, 62501),
                        new Vehicle(62572, 62502),
                        new Vehicle(62573, 62503),
                        new Vehicle(62574, 62504),
                        new Vehicle(62575, 62505),
                        new Vehicle(62576, 62506),
                        new Vehicle(62577, 62507)
                    }
                ),
                new Vehicles(62571,
                    new List<Vehicle>()
                    {
                        new Vehicle(62570, 62500),
                        new Vehicle(62572, 62502),
                        new Vehicle(62573, 62503),
                        new Vehicle(62574, 62504),
                        new Vehicle(62575, 62505),
                        new Vehicle(62576, 62506),
                        new Vehicle(62577, 62507),
                    }
                ),
                new Vehicles(62572,
                    new List<Vehicle>()
                    {
                        new Vehicle(62570, 62500),
                        new Vehicle(62571, 62501),
                        new Vehicle(62573, 62503),
                        new Vehicle(62574, 62504),
                        new Vehicle(62575, 62505),
                        new Vehicle(62576, 62506),
                        new Vehicle(62577, 62507)
                    }
                ),
                new Vehicles(62573,
                    new List<Vehicle>()
                    {
                        new Vehicle(62570, 62500),
                        new Vehicle(62571, 62501),
                        new Vehicle(62572, 62502),
                        new Vehicle(62574, 62504),
                        new Vehicle(62575, 62505),
                        new Vehicle(62576, 62506),
                        new Vehicle(62577, 62507)
                    }
                ),
                new Vehicles(62574,
                    new List<Vehicle>()
                    {
                        new Vehicle(62570, 62500),
                        new Vehicle(62571, 62501),
                        new Vehicle(62572, 62502),
                        new Vehicle(62573, 62503),
                        new Vehicle(62575, 62505),
                        new Vehicle(62576, 62506),
                        new Vehicle(62577, 62507)
                    }
                ),
                new Vehicles(62575,
                    new List<Vehicle>()
                    {
                        new Vehicle(62570, 62500),
                        new Vehicle(62571, 62501),
                        new Vehicle(62572, 62502),
                        new Vehicle(62573, 62503),
                        new Vehicle(62574, 62504),
                        new Vehicle(62576, 62506),
                        new Vehicle(62577, 62507)
                    }
                ),
                new Vehicles(62576,
                    new List<Vehicle>()
                    {
                        new Vehicle(62570, 62500),
                        new Vehicle(62571, 62501),
                        new Vehicle(62572, 62502),
                        new Vehicle(62573, 62503),
                        new Vehicle(62574, 62504),
                        new Vehicle(62575, 62505),
                        new Vehicle(62577, 62507)
                    }
                ),
                new Vehicles(62577,
                    new List<Vehicle>()
                    {
                        new Vehicle(62570, 62500),
                        new Vehicle(62571, 62501),
                        new Vehicle(62572, 62502),
                        new Vehicle(62573, 62503),
                        new Vehicle(62574, 62504),
                        new Vehicle(62575, 62505),
                        new Vehicle(62576, 62506)
                    }
                ),
                new Vehicles(62590,
                    new List<Vehicle>()
                    {
                        new Vehicle(62591, 62501),
                        new Vehicle(62592, 62502),
                        new Vehicle(62593, 62503),
                        new Vehicle(62594, 62504),
                        new Vehicle(62595, 62505),
                        new Vehicle(62596, 62506),
                        new Vehicle(62597, 62507)
                    }
                ),
                new Vehicles(62591,
                    new List<Vehicle>()
                    {
                        new Vehicle(62590, 62500),
                        new Vehicle(62592, 62502),
                        new Vehicle(62593, 62503),
                        new Vehicle(62594, 62504),
                        new Vehicle(62595, 62505),
                        new Vehicle(62596, 62506),
                        new Vehicle(62597, 62507),
                    }
                ),
                new Vehicles(62592,
                    new List<Vehicle>()
                    {
                        new Vehicle(62590, 62500),
                        new Vehicle(62591, 62501),
                        new Vehicle(62593, 62503),
                        new Vehicle(62594, 62504),
                        new Vehicle(62595, 62505),
                        new Vehicle(62596, 62506),
                        new Vehicle(62597, 62507)
                    }
                ),
                new Vehicles(62593,
                    new List<Vehicle>()
                    {
                        new Vehicle(62590, 62500),
                        new Vehicle(62591, 62501),
                        new Vehicle(62592, 62502),
                        new Vehicle(62594, 62504),
                        new Vehicle(62595, 62505),
                        new Vehicle(62596, 62506),
                        new Vehicle(62597, 62507)
                    }
                ),
                new Vehicles(62594,
                    new List<Vehicle>()
                    {
                        new Vehicle(62590, 62500),
                        new Vehicle(62591, 62501),
                        new Vehicle(62592, 62502),
                        new Vehicle(62593, 62503),
                        new Vehicle(62595, 62505),
                        new Vehicle(62596, 62506),
                        new Vehicle(62597, 62507)
                    }
                ),
                new Vehicles(62595,
                    new List<Vehicle>()
                    {
                        new Vehicle(62590, 62500),
                        new Vehicle(62591, 62501),
                        new Vehicle(62592, 62502),
                        new Vehicle(62593, 62503),
                        new Vehicle(62594, 62504),
                        new Vehicle(62596, 62506),
                        new Vehicle(62597, 62507)
                    }
                ),
                new Vehicles(62596,
                    new List<Vehicle>()
                    {
                        new Vehicle(62590, 62500),
                        new Vehicle(62591, 62501),
                        new Vehicle(62592, 62502),
                        new Vehicle(62593, 62503),
                        new Vehicle(62594, 62504),
                        new Vehicle(62595, 62505),
                        new Vehicle(62597, 62507)
                    }
                ),
                new Vehicles(62597,
                    new List<Vehicle>()
                    {
                        new Vehicle(62590, 62500),
                        new Vehicle(62591, 62501),
                        new Vehicle(62592, 62502),
                        new Vehicle(62593, 62503),
                        new Vehicle(62594, 62504),
                        new Vehicle(62595, 62505),
                        new Vehicle(62596, 62506)
                    }
                ),
                new Vehicles(62610,
                    new List<Vehicle>()
                    {
                        new Vehicle(62611, 62501),
                        new Vehicle(62612, 62502),
                        new Vehicle(62613, 62503),
                        new Vehicle(62614, 62504),
                        new Vehicle(62615, 62505),
                        new Vehicle(62616, 62506),
                        new Vehicle(62617, 62507)
                    }
                ),
                new Vehicles(62611,
                    new List<Vehicle>()
                    {
                        new Vehicle(62610, 62500),
                        new Vehicle(62612, 62502),
                        new Vehicle(62613, 62503),
                        new Vehicle(62614, 62504),
                        new Vehicle(62615, 62505),
                        new Vehicle(62616, 62506),
                        new Vehicle(62617, 62507),
                    }
                ),
                new Vehicles(62612,
                    new List<Vehicle>()
                    {
                        new Vehicle(62610, 62500),
                        new Vehicle(62611, 62501),
                        new Vehicle(62613, 62503),
                        new Vehicle(62614, 62504),
                        new Vehicle(62615, 62505),
                        new Vehicle(62616, 62506),
                        new Vehicle(62617, 62507)
                    }
                ),
                new Vehicles(62613,
                    new List<Vehicle>()
                    {
                        new Vehicle(62610, 62500),
                        new Vehicle(62611, 62501),
                        new Vehicle(62612, 62502),
                        new Vehicle(62614, 62504),
                        new Vehicle(62615, 62505),
                        new Vehicle(62616, 62506),
                        new Vehicle(62617, 62507)
                    }
                ),
                new Vehicles(62614,
                    new List<Vehicle>()
                    {
                        new Vehicle(62610, 62500),
                        new Vehicle(62611, 62501),
                        new Vehicle(62612, 62502),
                        new Vehicle(62613, 62503),
                        new Vehicle(62615, 62505),
                        new Vehicle(62616, 62506),
                        new Vehicle(62617, 62507)
                    }
                ),
                new Vehicles(62615,
                    new List<Vehicle>()
                    {
                        new Vehicle(62610, 62500),
                        new Vehicle(62611, 62501),
                        new Vehicle(62612, 62502),
                        new Vehicle(62613, 62503),
                        new Vehicle(62614, 62504),
                        new Vehicle(62616, 62506),
                        new Vehicle(62617, 62507)
                    }
                ),
                new Vehicles(62616,
                    new List<Vehicle>()
                    {
                        new Vehicle(62610, 62500),
                        new Vehicle(62611, 62501),
                        new Vehicle(62612, 62502),
                        new Vehicle(62613, 62503),
                        new Vehicle(62614, 62504),
                        new Vehicle(62615, 62505),
                        new Vehicle(62617, 62507)
                    }
                ),
                new Vehicles(62617,
                    new List<Vehicle>()
                    {
                        new Vehicle(62610, 62500),
                        new Vehicle(62611, 62501),
                        new Vehicle(62612, 62502),
                        new Vehicle(62613, 62503),
                        new Vehicle(62614, 62504),
                        new Vehicle(62615, 62505),
                        new Vehicle(62616, 62506)
                    }
                ),
                new Vehicles(62620,
                    new List<Vehicle>()
                    {
                        new Vehicle(62621, 62501),
                        new Vehicle(62622, 62502),
                        new Vehicle(62623, 62503),
                        new Vehicle(62624, 62504),
                        new Vehicle(62625, 62505),
                        new Vehicle(62626, 62506),
                        new Vehicle(62627, 62507)
                    }
                ),
                new Vehicles(62621,
                    new List<Vehicle>()
                    {
                        new Vehicle(62620, 62500),
                        new Vehicle(62622, 62502),
                        new Vehicle(62623, 62503),
                        new Vehicle(62624, 62504),
                        new Vehicle(62625, 62505),
                        new Vehicle(62626, 62506),
                        new Vehicle(62627, 62507),
                    }
                ),
                new Vehicles(62622,
                    new List<Vehicle>()
                    {
                        new Vehicle(62620, 62500),
                        new Vehicle(62621, 62501),
                        new Vehicle(62623, 62503),
                        new Vehicle(62624, 62504),
                        new Vehicle(62625, 62505),
                        new Vehicle(62626, 62506),
                        new Vehicle(62627, 62507)
                    }
                ),
                new Vehicles(62623,
                    new List<Vehicle>()
                    {
                        new Vehicle(62620, 62500),
                        new Vehicle(62621, 62501),
                        new Vehicle(62622, 62502),
                        new Vehicle(62624, 62504),
                        new Vehicle(62625, 62505),
                        new Vehicle(62626, 62506),
                        new Vehicle(62627, 62507)
                    }
                ),
                new Vehicles(62624,
                    new List<Vehicle>()
                    {
                        new Vehicle(62620, 62500),
                        new Vehicle(62621, 62501),
                        new Vehicle(62622, 62502),
                        new Vehicle(62623, 62503),
                        new Vehicle(62625, 62505),
                        new Vehicle(62626, 62506),
                        new Vehicle(62627, 62507)
                    }
                ),
                new Vehicles(62625,
                    new List<Vehicle>()
                    {
                        new Vehicle(62620, 62500),
                        new Vehicle(62621, 62501),
                        new Vehicle(62622, 62502),
                        new Vehicle(62623, 62503),
                        new Vehicle(62624, 62504),
                        new Vehicle(62626, 62506),
                        new Vehicle(62627, 62507)
                    }
                ),
                new Vehicles(62626,
                    new List<Vehicle>()
                    {
                        new Vehicle(62620, 62500),
                        new Vehicle(62621, 62501),
                        new Vehicle(62622, 62502),
                        new Vehicle(62623, 62503),
                        new Vehicle(62624, 62504),
                        new Vehicle(62625, 62505),
                        new Vehicle(62627, 62507)
                    }
                ),
                new Vehicles(62627,
                    new List<Vehicle>()
                    {
                        new Vehicle(62620, 62500),
                        new Vehicle(62621, 62501),
                        new Vehicle(62622, 62502),
                        new Vehicle(62623, 62503),
                        new Vehicle(62624, 62504),
                        new Vehicle(62625, 62505),
                        new Vehicle(62626, 62506)
                    }
                ),
                new Vehicles(62630,
                    new List<Vehicle>()
                    {
                        new Vehicle(62631, 62501),
                        new Vehicle(62632, 62502),
                        new Vehicle(62633, 62503),
                        new Vehicle(62634, 62504),
                        new Vehicle(62635, 62505),
                        new Vehicle(62636, 62506),
                        new Vehicle(62637, 62507)
                    }
                ),
                new Vehicles(62631,
                    new List<Vehicle>()
                    {
                        new Vehicle(62630, 62500),
                        new Vehicle(62632, 62502),
                        new Vehicle(62633, 62503),
                        new Vehicle(62634, 62504),
                        new Vehicle(62635, 62505),
                        new Vehicle(62636, 62506),
                        new Vehicle(62637, 62507),
                    }
                ),
                new Vehicles(62632,
                    new List<Vehicle>()
                    {
                        new Vehicle(62630, 62500),
                        new Vehicle(62631, 62501),
                        new Vehicle(62633, 62503),
                        new Vehicle(62634, 62504),
                        new Vehicle(62635, 62505),
                        new Vehicle(62636, 62506),
                        new Vehicle(62637, 62507)
                    }
                ),
                new Vehicles(62633,
                    new List<Vehicle>()
                    {
                        new Vehicle(62630, 62500),
                        new Vehicle(62631, 62501),
                        new Vehicle(62632, 62502),
                        new Vehicle(62634, 62504),
                        new Vehicle(62635, 62505),
                        new Vehicle(62636, 62506),
                        new Vehicle(62637, 62507)
                    }
                ),
                new Vehicles(62634,
                    new List<Vehicle>()
                    {
                        new Vehicle(62630, 62500),
                        new Vehicle(62631, 62501),
                        new Vehicle(62632, 62502),
                        new Vehicle(62633, 62503),
                        new Vehicle(62635, 62505),
                        new Vehicle(62636, 62506),
                        new Vehicle(62637, 62507)
                    }
                ),
                new Vehicles(62635,
                    new List<Vehicle>()
                    {
                        new Vehicle(62630, 62500),
                        new Vehicle(62631, 62501),
                        new Vehicle(62632, 62502),
                        new Vehicle(62633, 62503),
                        new Vehicle(62634, 62504),
                        new Vehicle(62636, 62506),
                        new Vehicle(62637, 62507)
                    }
                ),
                new Vehicles(62636,
                    new List<Vehicle>()
                    {
                        new Vehicle(62630, 62500),
                        new Vehicle(62631, 62501),
                        new Vehicle(62632, 62502),
                        new Vehicle(62633, 62503),
                        new Vehicle(62634, 62504),
                        new Vehicle(62635, 62505),
                        new Vehicle(62637, 62507)
                    }
                ),
                new Vehicles(62637,
                    new List<Vehicle>()
                    {
                        new Vehicle(62630, 62500),
                        new Vehicle(62631, 62501),
                        new Vehicle(62632, 62502),
                        new Vehicle(62633, 62503),
                        new Vehicle(62634, 62504),
                        new Vehicle(62635, 62505),
                        new Vehicle(62636, 62506)
                    }
                ),
                new Vehicles(62640,
                    new List<Vehicle>()
                    {
                        new Vehicle(62641, 62501),
                        new Vehicle(62642, 62502),
                        new Vehicle(62643, 62503),
                        new Vehicle(62644, 62504),
                        new Vehicle(62645, 62505),
                        new Vehicle(62646, 62506),
                        new Vehicle(62647, 62507)
                    }
                ),
                new Vehicles(62641,
                    new List<Vehicle>()
                    {
                        new Vehicle(62640, 62500),
                        new Vehicle(62642, 62502),
                        new Vehicle(62643, 62503),
                        new Vehicle(62644, 62504),
                        new Vehicle(62645, 62505),
                        new Vehicle(62646, 62506),
                        new Vehicle(62647, 62507),
                    }
                ),
                new Vehicles(62642,
                    new List<Vehicle>()
                    {
                        new Vehicle(62640, 62500),
                        new Vehicle(62641, 62501),
                        new Vehicle(62643, 62503),
                        new Vehicle(62644, 62504),
                        new Vehicle(62645, 62505),
                        new Vehicle(62646, 62506),
                        new Vehicle(62647, 62507)
                    }
                ),
                new Vehicles(62643,
                    new List<Vehicle>()
                    {
                        new Vehicle(62640, 62500),
                        new Vehicle(62641, 62501),
                        new Vehicle(62642, 62502),
                        new Vehicle(62644, 62504),
                        new Vehicle(62645, 62505),
                        new Vehicle(62646, 62506),
                        new Vehicle(62647, 62507)
                    }
                ),
                new Vehicles(62644,
                    new List<Vehicle>()
                    {
                        new Vehicle(62640, 62500),
                        new Vehicle(62641, 62501),
                        new Vehicle(62642, 62502),
                        new Vehicle(62643, 62503),
                        new Vehicle(62645, 62505),
                        new Vehicle(62646, 62506),
                        new Vehicle(62647, 62507)
                    }
                ),
                new Vehicles(62645,
                    new List<Vehicle>()
                    {
                        new Vehicle(62640, 62500),
                        new Vehicle(62641, 62501),
                        new Vehicle(62642, 62502),
                        new Vehicle(62643, 62503),
                        new Vehicle(62644, 62504),
                        new Vehicle(62646, 62506),
                        new Vehicle(62647, 62507)
                    }
                ),
                new Vehicles(62646,
                    new List<Vehicle>()
                    {
                        new Vehicle(62640, 62500),
                        new Vehicle(62641, 62501),
                        new Vehicle(62642, 62502),
                        new Vehicle(62643, 62503),
                        new Vehicle(62644, 62504),
                        new Vehicle(62645, 62505),
                        new Vehicle(62647, 62507)
                    }
                ),
                new Vehicles(62647,
                    new List<Vehicle>()
                    {
                        new Vehicle(62640, 62500),
                        new Vehicle(62641, 62501),
                        new Vehicle(62642, 62502),
                        new Vehicle(62643, 62503),
                        new Vehicle(62644, 62504),
                        new Vehicle(62645, 62505),
                        new Vehicle(62646, 62506)
                    }
                ),
                new Vehicles(62650,
                    new List<Vehicle>()
                    {
                        new Vehicle(62651, 62501),
                        new Vehicle(62652, 62502),
                        new Vehicle(62653, 62503),
                        new Vehicle(62654, 62504),
                        new Vehicle(62655, 62505),
                        new Vehicle(62656, 62506),
                        new Vehicle(62657, 62507)
                    }
                ),
                new Vehicles(62651,
                    new List<Vehicle>()
                    {
                        new Vehicle(62650, 62500),
                        new Vehicle(62652, 62502),
                        new Vehicle(62653, 62503),
                        new Vehicle(62654, 62504),
                        new Vehicle(62655, 62505),
                        new Vehicle(62656, 62506),
                        new Vehicle(62657, 62507),
                    }
                ),
                new Vehicles(62652,
                    new List<Vehicle>()
                    {
                        new Vehicle(62650, 62500),
                        new Vehicle(62651, 62501),
                        new Vehicle(62653, 62503),
                        new Vehicle(62654, 62504),
                        new Vehicle(62655, 62505),
                        new Vehicle(62656, 62506),
                        new Vehicle(62657, 62507)
                    }
                ),
                new Vehicles(62653,
                    new List<Vehicle>()
                    {
                        new Vehicle(62650, 62500),
                        new Vehicle(62651, 62501),
                        new Vehicle(62652, 62502),
                        new Vehicle(62654, 62504),
                        new Vehicle(62655, 62505),
                        new Vehicle(62656, 62506),
                        new Vehicle(62657, 62507)
                    }
                ),
                new Vehicles(62654,
                    new List<Vehicle>()
                    {
                        new Vehicle(62650, 62500),
                        new Vehicle(62651, 62501),
                        new Vehicle(62652, 62502),
                        new Vehicle(62653, 62503),
                        new Vehicle(62655, 62505),
                        new Vehicle(62656, 62506),
                        new Vehicle(62657, 62507)
                    }
                ),
                new Vehicles(62655,
                    new List<Vehicle>()
                    {
                        new Vehicle(62650, 62500),
                        new Vehicle(62651, 62501),
                        new Vehicle(62652, 62502),
                        new Vehicle(62653, 62503),
                        new Vehicle(62654, 62504),
                        new Vehicle(62656, 62506),
                        new Vehicle(62657, 62507)
                    }
                ),
                new Vehicles(62656,
                    new List<Vehicle>()
                    {
                        new Vehicle(62650, 62500),
                        new Vehicle(62651, 62501),
                        new Vehicle(62652, 62502),
                        new Vehicle(62653, 62503),
                        new Vehicle(62654, 62504),
                        new Vehicle(62655, 62505),
                        new Vehicle(62657, 62507)
                    }
                ),
                new Vehicles(62657,
                    new List<Vehicle>()
                    {
                        new Vehicle(62650, 62500),
                        new Vehicle(62651, 62501),
                        new Vehicle(62652, 62502),
                        new Vehicle(62653, 62503),
                        new Vehicle(62654, 62504),
                        new Vehicle(62655, 62505),
                        new Vehicle(62656, 62506)
                    }
                ),
                new Vehicles(62660,
                    new List<Vehicle>()
                    {
                        new Vehicle(62661, 62501),
                        new Vehicle(62662, 62502),
                        new Vehicle(62663, 62503),
                        new Vehicle(62664, 62504),
                        new Vehicle(62665, 62505),
                        new Vehicle(62666, 62506),
                        new Vehicle(62667, 62507)
                    }
                ),
                new Vehicles(62661,
                    new List<Vehicle>()
                    {
                        new Vehicle(62660, 62500),
                        new Vehicle(62662, 62502),
                        new Vehicle(62663, 62503),
                        new Vehicle(62664, 62504),
                        new Vehicle(62665, 62505),
                        new Vehicle(62666, 62506),
                        new Vehicle(62667, 62507),
                    }
                ),
                new Vehicles(62662,
                    new List<Vehicle>()
                    {
                        new Vehicle(62660, 62500),
                        new Vehicle(62661, 62501),
                        new Vehicle(62663, 62503),
                        new Vehicle(62664, 62504),
                        new Vehicle(62665, 62505),
                        new Vehicle(62666, 62506),
                        new Vehicle(62667, 62507)
                    }
                ),
                new Vehicles(62663,
                    new List<Vehicle>()
                    {
                        new Vehicle(62660, 62500),
                        new Vehicle(62661, 62501),
                        new Vehicle(62662, 62502),
                        new Vehicle(62664, 62504),
                        new Vehicle(62665, 62505),
                        new Vehicle(62666, 62506),
                        new Vehicle(62667, 62507)
                    }
                ),
                new Vehicles(62664,
                    new List<Vehicle>()
                    {
                        new Vehicle(62660, 62500),
                        new Vehicle(62661, 62501),
                        new Vehicle(62662, 62502),
                        new Vehicle(62663, 62503),
                        new Vehicle(62665, 62505),
                        new Vehicle(62666, 62506),
                        new Vehicle(62667, 62507)
                    }
                ),
                new Vehicles(62665,
                    new List<Vehicle>()
                    {
                        new Vehicle(62660, 62500),
                        new Vehicle(62661, 62501),
                        new Vehicle(62662, 62502),
                        new Vehicle(62663, 62503),
                        new Vehicle(62664, 62504),
                        new Vehicle(62666, 62506),
                        new Vehicle(62667, 62507)
                    }
                ),
                new Vehicles(62666,
                    new List<Vehicle>()
                    {
                        new Vehicle(62660, 62500),
                        new Vehicle(62661, 62501),
                        new Vehicle(62662, 62502),
                        new Vehicle(62663, 62503),
                        new Vehicle(62664, 62504),
                        new Vehicle(62665, 62505),
                        new Vehicle(62667, 62507)
                    }
                ),
                new Vehicles(62667,
                    new List<Vehicle>()
                    {
                        new Vehicle(62660, 62500),
                        new Vehicle(62661, 62501),
                        new Vehicle(62662, 62502),
                        new Vehicle(62663, 62503),
                        new Vehicle(62664, 62504),
                        new Vehicle(62665, 62505),
                        new Vehicle(62666, 62506)
                    }
                ),
                new Vehicles(62670,
                    new List<Vehicle>()
                    {
                        new Vehicle(62671, 62501),
                        new Vehicle(62672, 62502),
                        new Vehicle(62673, 62503),
                        new Vehicle(62674, 62504),
                        new Vehicle(62675, 62505),
                        new Vehicle(62676, 62506),
                        new Vehicle(62677, 62507)
                    }
                ),
                new Vehicles(62671,
                    new List<Vehicle>()
                    {
                        new Vehicle(62670, 62500),
                        new Vehicle(62672, 62502),
                        new Vehicle(62673, 62503),
                        new Vehicle(62674, 62504),
                        new Vehicle(62675, 62505),
                        new Vehicle(62676, 62506),
                        new Vehicle(62677, 62507),
                    }
                ),
                new Vehicles(62672,
                    new List<Vehicle>()
                    {
                        new Vehicle(62670, 62500),
                        new Vehicle(62671, 62501),
                        new Vehicle(62673, 62503),
                        new Vehicle(62674, 62504),
                        new Vehicle(62675, 62505),
                        new Vehicle(62676, 62506),
                        new Vehicle(62677, 62507)
                    }
                ),
                new Vehicles(62673,
                    new List<Vehicle>()
                    {
                        new Vehicle(62670, 62500),
                        new Vehicle(62671, 62501),
                        new Vehicle(62672, 62502),
                        new Vehicle(62674, 62504),
                        new Vehicle(62675, 62505),
                        new Vehicle(62676, 62506),
                        new Vehicle(62677, 62507)
                    }
                ),
                new Vehicles(62674,
                    new List<Vehicle>()
                    {
                        new Vehicle(62670, 62500),
                        new Vehicle(62671, 62501),
                        new Vehicle(62672, 62502),
                        new Vehicle(62673, 62503),
                        new Vehicle(62675, 62505),
                        new Vehicle(62676, 62506),
                        new Vehicle(62677, 62507)
                    }
                ),
                new Vehicles(62675,
                    new List<Vehicle>()
                    {
                        new Vehicle(62670, 62500),
                        new Vehicle(62671, 62501),
                        new Vehicle(62672, 62502),
                        new Vehicle(62673, 62503),
                        new Vehicle(62674, 62504),
                        new Vehicle(62676, 62506),
                        new Vehicle(62677, 62507)
                    }
                ),
                new Vehicles(62676,
                    new List<Vehicle>()
                    {
                        new Vehicle(62670, 62500),
                        new Vehicle(62671, 62501),
                        new Vehicle(62672, 62502),
                        new Vehicle(62673, 62503),
                        new Vehicle(62674, 62504),
                        new Vehicle(62675, 62505),
                        new Vehicle(62677, 62507)
                    }
                ),
                new Vehicles(62677,
                    new List<Vehicle>()
                    {
                        new Vehicle(62670, 62500),
                        new Vehicle(62671, 62501),
                        new Vehicle(62672, 62502),
                        new Vehicle(62673, 62503),
                        new Vehicle(62674, 62504),
                        new Vehicle(62675, 62505),
                        new Vehicle(62676, 62506)
                    }
                ),
            };
        }
    }
}
